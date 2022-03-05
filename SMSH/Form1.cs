using System;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Text.Json;
namespace SMSH
{
    public partial class Form1 : Form
    {
        internal static Guid guid = Guid.NewGuid();
        const int ByteNums = 0b10000000000;
        public static Socket socket = null;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            SendFile.Enabled = false;
            Exit.Enabled = false;
            menuStrip1.Enabled = false;
            foreach(var v in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                PutMsg(v.ToString());
            }
        }
        private async void Link_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
#if DEBUG
                    socket.Connect(IPAddress.Parse("127.0.0.1"), 13002);
#else
            socket.Connect(new IPEndPoint(IPAddress.Parse("103.46.128.49"),int.Parse(Port.Text)));
#endif
                    socket.Send(Encoding.Default.GetBytes($"{{\"Name\":\"{Namef.Text}\",\"Guid\":\"{guid}\"}}"));
                    Exit.Enabled = true;
                    Link.Enabled = false;
                    menuStrip1.Enabled = true;
                    SendFile.Enabled = true;
                    Thread recv = new Thread(RecvMsg);
                    recv.IsBackground = true;
                    recv.Start();
                }
                catch (SocketException ex)
                {
                    System.Windows.Forms.MessageBox.Show(this, "服务器连接不上哦，您可以检查一下网络或者检查端口号是否正常，也许是服务器未开启哦。(错误代码:" + ex.SocketErrorCode.ToString() + ")",
                                                         "错误",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Error
                    );
                }
            });
            task.Start();
        }

        public void PutMsg(string Msg)
        {
            MessageBox.AppendText(Msg + Environment.NewLine);
        }
        private void RecvMsg()
        {
            if (socket.Connected)
            {
                try
                {
                    byte[] msg = new byte[500 * ByteNums];
                    int len = socket.Receive(msg);
                    string str = Encoding.UTF8.GetString(msg, 0, len);
                    if(str.StartsWith("File:"))
                    {
                        FileInfo fileInfo = JsonSerializer.Deserialize<FileInfo>(str.Replace("File:", ""));
                        Static.filelist.Add(fileInfo);
                        return;
                    }
                    PutMsg(str.Replace("{#NewLine}", Environment.NewLine));
                }
                catch (SocketException sx)
                {
                    PutMsg("Error:" + sx.Message);
                    PutMsg("ErrorCode:" + sx.ErrorCode);
                    return;
                }
                RecvMsg();
            }
            else
            {
                return;
            }
        }
        public void Send(string str)
        {
            socket.Send(Encoding.UTF8.GetBytes(str));
        }
        private void Sed_Click(object sender, EventArgs e)
        {
            /*
             * {Guid:*,Msg:"{"FileName":"test.txt","Content":"This is test content."}"}
             */
            Send("Msg:{\"Guid\":\"" + guid + "\",\"Msg\":\"" + MsgText.Text + "\",\"IsFile\":\"False\"}");
            MsgText.Clear();
        }
        public void Exitf()
        {
            if (socket != null)
            {
                if (socket.Connected)
                {
                    socket.Send(Encoding.Default.GetBytes("Exit:" + guid));
                    socket.Close();
                }
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Link.Enabled = true;
            Exit.Enabled = false;
            SendFile.Enabled = false;
            menuStrip1.Enabled = false;
            Exitf();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exitf();
        }

        private void MsgText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.Enter)
            {
                
            }
            else if (e.KeyCode == Keys.Enter)
            {
                string Text = MsgText.Text;
                Text = Text.Replace(Environment.NewLine, "{#NewLine}");
                Send("Msg:{\"Guid\":\"" + guid + "\",\"Msg\":\"" + Text + "\"}");
                MsgText.Clear();
                e.Handled = false;
            }
            
        }

        private void synchronousPort_Click(object sender, EventArgs e)
        {
            Port.Text = new WebClient().DownloadString("https://gitee.com/cai_hongxuan/quenums/raw/master/ip.txt");
        }

        private void SendFile_Click(object sender, EventArgs e)
        {
            SelectFile selectFile = new SelectFile(socket);
            selectFile.ShowDialog();
        }

        private void 文件管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManger fileManger = new FileManger();
            fileManger.ShowDialog();
        }
    }
}
