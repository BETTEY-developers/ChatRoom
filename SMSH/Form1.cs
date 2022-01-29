using System;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace SMSH
{
    public partial class Form1 : Form
    {
        Guid guid = Guid.NewGuid();
        const int ByteNums = 0b10000000000;
        Socket socket = null;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            foreach(var v in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                PutMsg(v.ToString());
            }
        }

        private void Link_Click(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(IPAddress.Parse("103.46.128.49"),int.Parse(Port.Text)));
            socket.Send(Encoding.Default.GetBytes($"{{\"Name\":\"{Namef.Text}\",\"Guid\":\"{guid}\"}}"));
            Thread recv = new Thread(RecvMsg);
            recv.IsBackground = true;
            recv.Start();
        }

        public void PutMsg(string Msg)
        {
            MessageBox.AppendText(Msg + Environment.NewLine);
        }
        private void RecvMsg()
        {
            try
            {
                byte[] msg = new byte[500 * ByteNums];
                int len = socket.Receive(msg);
                PutMsg(Encoding.UTF8.GetString(msg, 0, len).Replace("{#NewLine}",Environment.NewLine));
            }
            catch(SocketException sx)
            {
                PutMsg("Error:" + sx.Message);
                PutMsg("ErrorCode:" + sx.ErrorCode);
                return;
            }
            RecvMsg();
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
            Send("{\"Guid\":\"" + guid + "\",\"Msg\":\"" + MsgText.Text + "\"}");
            MsgText.Clear();
        }
        public void Exitf()
        {
            if (socket != null)
            {
                if (socket.Connected)
                {
                    socket.Send(Encoding.Default.GetBytes("Exit:" + guid));
                }
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
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
                Send("{\"Guid\":\"" + guid + "\",\"Msg\":\"" + Text + "\"}");
                MsgText.Clear();
            }
            
        }

        private void synchronousPort_Click(object sender, EventArgs e)
        {
            Port.Text = new WebClient().DownloadString("https://gitee.com/cai_hongxuan/quenums/raw/master/ip.txt");
        }
    }
}
