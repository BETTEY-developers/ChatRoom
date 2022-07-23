using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SMSH
{
    using System.Collections.Generic;
    using System.IO;

    public class Group
    {

        const int ByteNums = 0b10000000000;
        public event EventHandler<string> PutMsg;
        public event EventHandler<string> PutError;
        public event EventHandler<string> SiteDownloadDone;
        public Guid UserGuid { get; set; }
        public Socket socket { get; set; }
        /// <summary>
        /// 妈的，下策
        /// </summary>
        bool Sleepb;
        /// <summary>
        /// 使用IP地址和端口号初始化socket
        /// </summary>
        /// <param name="socket">套接字</param>
        /// <param name="ip">IP地址</param>
        /// <param name="port">端口号</param>
        public Group()
        {
           socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            UserGuid = Guid.NewGuid();
        }

        public async void Connect(string ip, int port,string Name)
        {
            await Task.Run(() =>
            {
                try
                {
                    socket.Connect(IPAddress.Parse(ip), port);
                    socket.Send(Encoding.Default.GetBytes($"{{\"Name\":\"{Name}\",\"Guid\":\"{UserGuid}\"}}"));
                    Thread recv = new Thread(RecvMsg);
                    recv.IsBackground = true;
                    recv.Start();
                }
                catch (SocketException ex)
                {
                    System.Windows.Forms.MessageBox.Show("服务器连接不上哦，您可以检查一下网络或者检查端口号是否正常，也许是服务器未开启哦。(错误代码:" + ex.SocketErrorCode.ToString() + ")",
                                                         "错误",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Error
                    );

                }
            });
        }
        /// <summary>
        /// 接收消息时的处理
        /// </summary>
        private void RecvMsg()
        {
            if (socket.Connected)
            {
                try
                {
                    byte[] msg = new byte[500 * ByteNums];
                    int len = socket.Receive(msg);
                    string str = Encoding.UTF8.GetString(msg, 0, len);
                    if (str.StartsWith("File:"))
                    {
                        FileInfo fileInfo = JsonSerializer.Deserialize<FileInfo>(str.Replace("File:", ""));
                        Static.filelist.Add(fileInfo);
                    }
                    else if (str.StartsWith("Msg|"))
                    {
                        PutMsg(this, str.Replace("{#NewLine}", Environment.NewLine).Replace("Msg|", ""));
                    }
                    else if(str == "beginSendFile")
                    {
                        Sleep();
                    }
                }
                catch (SocketException sx)
                {
                    PutError(this,"Error:" + sx.Message);
                    return;
                }
                RecvMsg();
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// 向聊天服务器发送信息
        /// </summary>
        /// <param name="msg">要发送的信息数据</param>
        public void Send(string msg)
        {
            socket.Send(Encoding.UTF8.GetBytes($"Msg:{{\"Guid\":\"{UserGuid}\",\"Msg\":\"{msg}\"}}"));
        }
        /// <summary>
        /// 发送文件到聊天服务器上
        /// </summary>
        /// <param name="file">文件原路径</param>
        /// <param name="timfliename">发送时文件名称</param>
        /// <param name="intr">文件简介</param>
        public async void SendFileData(string file, string timfliename, string intr)
        {
            Stream stream = File.OpenRead(file);
            var m = Encoding.UTF8.GetBytes($"File:{{\"FileName\":\"{timfliename}\",\"Introduction\":\"{intr}\",\"Size\":{stream.Length.ToString()},\"Guid\":\"{UserGuid}\"}}");
            socket.Send(m,m.Length,SocketFlags.None);
            await Task.Run(() =>
            {
                while(true)
                {
                    byte[] data = new byte[1024 * 8];
                    if (stream.Position == stream.Length)
                    {
                        stream.Close();
                        return;
                    }
                    int len = stream.Read(data, 0, 1024 * 8);
                    socket.Send(data, len, SocketFlags.None);
                }
            });
            stream.Close();
        }
        /// <summary>
        /// 退出聊天服务器
        /// </summary>
        public void Exit()
        {
            if (socket.Connected)
            {
                socket.Send(Encoding.Default.GetBytes("Exit:" + UserGuid));
                socket.Close();
            }
        }
        /// <summary>
        /// 下载/接收聊天服务器文件
        /// </summary>
        /// <param name="Index">文件列表<see cref="Static"/>.filelist的索引</param>
        public void RecvFile(int Index)
        {
            lock (socket)
            {
                var v = Static.filelist[Index];
                if (!Directory.Exists("DownloadFile"))
                    Directory.CreateDirectory("DownloadFile");
                socket.Send(Encoding.UTF8.GetBytes($"ID:{{\"Start\":\"DownloadFile\",\"Id\":\"{v.Id}\"}}"));
                Sleepb = true;
                Stream stream = File.Create($"DownloadFile\\{v.FileName}");

                while (true)
                {
                    byte[] data = new byte[1024 * 8];
                    int len = socket.Receive(data);
                    if (Encoding.UTF8.GetString(data, 0, len) == "FileEnd")
                    {
                        stream.Close();
                        break;
                    }
                    else
                    {
                        stream.Write(data, 0, len);
                    }
                }
                Sleepb = false;
            }
        }
        /// <summary>
        /// 访问服务器网站（测试中）
        /// </summary>
        public void VisitWebSite()
        {
            var dir = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Marika\\WebSiteFile");
            socket.Send(Encoding.UTF8.GetBytes($"ID:{{\"Start\":\"GetWebSite\",\"Id\":\"0\"}}"));
            byte[] head = new byte[65535];
            int len = socket.Receive(head);
            head = GetGraterThanZeroBytes(head);
            File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Marika\\WebSiteFile\\index.html", head);
            SiteDownloadDone(this, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Marika\\WebSiteFile\\index.html");
        }

        private byte[] GetGraterThanZeroBytes(byte[] head)
        {
            List<byte> result = new List<byte>();
            foreach (byte b in head)
            {
                if (b > 0)
                {
                    result.Add(b);
                }
            }
            return result.ToArray();
        }

        private void Sleep()
        {
            while(Sleepb)
            {
                Thread.Sleep(1);
            }
        }
    }
}
