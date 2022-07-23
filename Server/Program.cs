using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Input;
using System.Collections.Generic;
    #pragma warning disable


namespace Server
{
    #region Json格式实体化定义类
    public class ID
    {
        public string Start { get; set; }
        public string Id { get; set; }
    }
    public class UserInfo
    {
        public string Name { get; set; }
        public string Guid { get; set; }
        public string IP { get; set; }
    }
    public class FileInfo
    {
        public FileInfo()
        {
            Id = DateTime.Now.Ticks.ToString();
        }
        public string FileName { get; set; }
        public string Introduction { get; set; }
        public long Size { get; set; }
        public string Id { get; private set; }
        public string Guid { get; set; }
    }
    public class Message
    {
        public string Guid { get; set; }
        public string Msg { get; set; }
    }

    
    public class RtfText
    {
        public struct Color
        {
            public int Red { get; set; }
            public int Green { get; set; }
            public int Blue { get; set; }
        }
        public struct FontInfo
        {
            public string FontFamliy { get; set; }
            public int Height { get; set; }
            public float Size { get; set; }
            public bool Italic { get; set; }
            public bool Underline { get; set; }
            public bool Bold { get; set; } 
        }
        public class RtfBlock
        {
            public int StartIndex { get; set; }
            public int EndIndex { get; set; }
            public Color Color { get; set; }
            public FontInfo FontInfo { get; set; }
            public Color BackColor { get; set; }
            
        }
        public List<RtfBlock> Blocks = new List<RtfBlock>();
        public RtfBlock AllFont { get; set; }
        public string OriginalString { get; set; }
        public int TextAlign { get; set; }
    }
    #endregion
    public class Server
    {
        Socket cs = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<UserInfo> userInfos = new List<UserInfo>();
        List<Socket> sockets = new List<Socket>();
        List<FileInfo> fileInfos = new List<FileInfo>();
        FileStreamOptions FileStreamOptions = new FileStreamOptions();
        FileStream log;
        StreamReader json;
        string flog = "";

        public void Manger(string str)
        {
            string v = str.Split(':')[1];
            if (v == "Close")
            {
                Close();
            }
        }
        public Server()
        {
            if (!File.Exists("FileData.json"))
                File.Create("FileData.json");
            else
            {
                json = new StreamReader("FileData.json");
                if(!(json.ReadToEnd() == ""))
                    fileInfos = (List<FileInfo>)JsonSerializer.Deserialize("FileData.json", typeof(List<FileInfo>));
                json.Close();
            }
        }

        public void WriteLine(string line)
        {
            Console.WriteLine($"[{Now()}] " + line);
            flog += $"[{Now()}] " + line;
        }
        public void Start()
        {
            cs.Bind(new IPEndPoint(IPAddress.Any, 13002));
            cs.Listen(10);
            Thread thr = new Thread(Acc);
            thr.IsBackground = false;
            thr.Start();
        }

        private void Acc()
        {
            try
            {
                Socket acc = cs.Accept();
                byte[] msg = new byte[1024 * 500];
                int len = acc.Receive(msg);
                string str = Encoding.UTF8.GetString(msg, 0, len);
                userInfos.Add((UserInfo)JsonSerializer.Deserialize(str, typeof(UserInfo)));
                acc.Send(Encoding.UTF8.GetBytes($"\"FileNum\":{fileInfos.Count}|"));
                if(fileInfos.Count > 0)
                {
                    foreach(FileInfo fileInfo in fileInfos)
                    {
                        acc.Send(Encoding.UTF8.GetBytes($"{{\"FileName\":\"{fileInfo.FileName}\",\"Id\":\"{fileInfo.Id}\",\"Name\":\"{Getname(fileInfo.Guid)}\",\"Size\":{fileInfo.Size}}}"));
                    }
                }
                sockets.Add(acc);
                WriteLine($"[{Now()}] {userInfos[userInfos.Count - 1].Name} 进入聊天室");
                BoradClient(userInfos[userInfos.Count - 1].Name + " 进入聊天室");
                Thread rcMsg = new Thread(ReceMsg);
                rcMsg.IsBackground = false;
                rcMsg.Start(acc);
            }
            catch { }
            Acc();
        }
        public string Now()
        {
            return DateTime.Now.ToString();
        }
        public string Getname(string Guid)
        {
            foreach(UserInfo info in userInfos)
            {
                if(info.Guid == Guid)
                    return info.Name;
            }
            throw null;
        }
        [Obsolete("The mothod is OBSOLETE!")]
        private void ReceMsg(object objects)
        {
            try
            {
                Socket socket = objects as Socket;
                byte[] msg = new byte[0x7FFF];
                int len = socket.Receive(msg);
                string str = Encoding.Default.GetString(msg, 0, len);
                string fm = "";
                if (str.StartsWith("Exit:"))
                {
                    UserInfo reinfo = new();
                    foreach (UserInfo info in userInfos)
                    {
                        if (info.Guid == str.Replace("Exit:", ""))
                        {
                            WriteLine(info.Name + " 退出聊天室");
                            fm = info.Name + " 退出聊天室";
                            reinfo = info;
                        }
                    }
                    userInfos.Remove(reinfo);
                    sockets.Remove(socket);
                    socket.Close();
                    BoradClient(fm);
                    return;
                }
                else if (str.StartsWith("File:"))
                {
                    FileInfo fileInfo = (FileInfo)JsonSerializer.Deserialize(str.Replace("File:", ""), typeof(FileInfo));
                    fileInfos.Add(fileInfo);
                    string Name = Getname(fileInfo.Guid);
                    BoradClient($"{{\"FileName\":\"{fileInfo.FileName}\",\"Id\":\"{fileInfo.Id}\",\"Name\":\"{Name}\",\"Size\":{fileInfo.Size}}}","File:");
                    ReceFile(socket);
                }
                else if(str.StartsWith("ID:"))
                {
                    ID id = new ID();
                    id = (ID)JsonSerializer.Deserialize(str.Replace("ID:", ""),typeof(ID));
                    if (id.Start == "DownloadFile")
                    {
                        var beginSendFileData = Encoding.UTF8.GetBytes("beginSendFile");
                        socket.Send(beginSendFileData, beginSendFileData.Length, SocketFlags.None);
                        foreach (FileInfo fileInfo in fileInfos)
                        {
                            if (fileInfo.Id == id.Id)
                            {
                                SendFile(fileInfo, socket);
                            }
                        }
                    }
                    else if(id.Start == "GetWebSite")
                    {
                        MyWebSite.SendFile(socket);
                    }
                }
                else if(str.StartsWith("Manger:"))
                {
                    
                }
                else if(str.StartsWith("Msg:"))
                {
                    Message msgs = (Message)JsonSerializer.Deserialize(str.Replace("Msg:",""), typeof(Message));
                    string Name = Getname(msgs.Guid);
                    fm = $"{Name} : {msgs.Msg}";
                    WriteLine($"[{Now}] {fm.Replace("{#NewLine}",Environment.NewLine)}");
                    BoradClient(fm);
                }
                ReceMsg(socket);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Error] " + ex.Message);
                Process.GetCurrentProcess().Kill();
            }
        }
        public byte[] GetByte(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }
        private void SendFile(FileInfo fileInfo,Socket socket)
        {
            Stream stream = new FileStream($"ClientUpdateFile\\{fileInfo.FileName}",FileMode.Open);
            while(true)
            {
                byte[] data = new byte[1024 * 8];
                if(stream.Position == stream.Length)
                {
                    socket.Send(GetByte("FileEnd"), GetByte("FileEnd").Length,SocketFlags.None);
                    return;
                }
                stream.Read(data, 0, data.Length);
                Thread.Sleep(10);
                socket.Send(data);
            }
        }

        private void ReceFile(object? obj)
        {
            Socket socket = obj as Socket;
            FileInfo info = fileInfos[fileInfos.Count - 1];
            if (!Directory.Exists("ClientUpdateFile"))
                Directory.CreateDirectory("ClientUpdateFile");
            Stream stream = new FileStream("ClientUpdateFile\\" + info.FileName, FileMode.Create);
            long RecvLength = 0;
            while(true)
            {
                byte[] data = new byte[1024 * 8];
                int len = socket.Receive(data);
                RecvLength += len;
                stream.Write(data, 0, len);
                if (RecvLength == info.Size)
                {
                    stream.Close();
                    break;
                }
            }
            return;
        }

        private void BoradClient(string str, string Start = "")
        {
            if (Start == "")
            {
                foreach (Socket socket in sockets)
                {
                    socket.Send(Encoding.UTF8.GetBytes("Msg|" + str));
                }
            }
            else
            {
                foreach (Socket socket in sockets)
                {
                    socket.Send(Encoding.UTF8.GetBytes(Start + str));
                }
            }
        }

        private void Close()
        {
            BoradClient("Server:即将关闭服务器");
            cs.Shutdown(SocketShutdown.Both);
            cs.Close(1);
            cs.Dispose();
            string value = JsonSerializer.Serialize(fileInfos,typeof(List<FileInfo>));
            if(value != new StreamReader("FileData.json").ReadToEnd())
            {
                FileStreamOptions fileStreamOptions = new FileStreamOptions();
                fileStreamOptions.Access = FileAccess.Write;
                fileStreamOptions.Mode = FileMode.Truncate;
                var write = new StreamWriter("FileData.json", fileStreamOptions);
                write.Write(value);
                write.Flush();
                write.Close();
            }
            WriteLine($"服务器关闭");
            Directory.CreateDirectory("log");
            log = File.Create($"log\\{Now().Replace("/", ".").Replace(':', '_')}.svrlog");
            log.Write(Encoding.UTF8.GetBytes(flog));
            log.Close();
        }
    }
    public class Program
    {
        static public void Main()
        {
            
            try
            {
                Console.WriteLine((string)((Dictionary<string, object>)((Dictionary<string, object>)((List<Dictionary<string, object>>)data["Blocks"])[0])["FontInfo"])["FontFamliy"]);
                Server server = new Server();
                server.Start();
            }
            catch (SocketException ex)
            {
                Console.WriteLine("[Error]:" + ex.Message + "\n" + ex.StackTrace + "\n" + ex.ErrorCode);
                Console.ReadLine();
            }
        }
    }
}
