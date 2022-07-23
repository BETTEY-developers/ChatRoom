using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Text.Json;
using System.Diagnostics;

namespace SMSH
{
    public partial class Form1 : Form
    {
        static public Group group;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            SendFile.Enabled = false;
            Exit.Enabled = false;
            menuStrip1.Enabled = false;
            group = new Group();
            group.PutMsg += PutMsg;
            group.PutError += PutError;
            group.SiteDownloadDone += Group_SiteDownloadDone;
        }

        private void PutError(object sender, string e)
        {
            MessageBox.AppendText(e);
            MessageBox.SelectedText = e;
            MessageBox.SelectionColor = System.Drawing.Color.Red;
        }

        private void Group_SiteDownloadDone(object sender, string e)
        {
            new WebSite(e).Show();
        }

        private void PutMsg(object sender, string e)
        {
            MessageBox.AppendText(e + Environment.NewLine);
        }

        private async void Link_Click(object sender, EventArgs e)
        {
            group = new Group();
            group.PutMsg += PutMsg;
            group.PutError += PutError;
            group.SiteDownloadDone += Group_SiteDownloadDone;
#if DEBUG
            group.Connect("127.0.0.1", 13002, Namef.Text);
#else
            group.Connect("103.46.128.49", 13002, Namef.Text);
#endif
            Exit.Enabled = true;
            Link.Enabled = false;
            menuStrip1.Enabled = true;
            SendFile.Enabled = true;
        }
        
        private void Sed_Click(object sender, EventArgs e)
        {
            /*
             * {Guid:*,Msg:"{"FileName":"test.txt","Content":"This is test content."}"}
             */
            group.Send(MsgText.Text.Replace("\n","{#NewLine}"));
            MsgText.Clear();
        }
        public void Exitf()
        {
            group.Exit();
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
                group.Send(Text);
                MsgText.Clear();
            }

        }

        private void synchronousPort_Click(object sender, EventArgs e)
        {
            Port.Text = new WebClient().DownloadString("https://gitee.com/cai_hongxuan/quenums/raw/master/ip.txt");
        }

        private void SendFile_Click(object sender, EventArgs e)
        {
            SelectFile selectFile = new SelectFile(group);
            selectFile.ShowDialog();
        }

        private void 文件管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManger fileManger = new FileManger();
            fileManger.ShowDialog();
        }

        private void MessageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void 访问我们的网站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group.VisitWebSite();
        }

        private void Emoji_Click(object sender, EventArgs e)
        {
            new EmojiForm().Show();
        }
    }
}
