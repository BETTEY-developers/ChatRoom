using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace SMSH
{
    public partial class InfoPage : Form
    {
        long Id;
        public InfoPage()
        {
            InitializeComponent();
        }

        public InfoPage(string Name, string Inroduction, string UserName, bool IsDownload, long Id)
        {
            NameFile.Text = Name;
            IntroductionFile.Text = Inroduction;
            UpUser.Text = UserName;
            this.Id = Id;
            if(IsDownload)
            {
                DownAOpen.Text = "打开";
                DownAOpen.Click += new EventHandler(Open);
            }
            else
            {
                DownAOpen.Text = "下载";
                DownAOpen.Click += new EventHandler(Download);
            }
        }

        private void Download(object sender, EventArgs e)
        {
            if (Directory.Exists("DownloadFile"))
                Directory.CreateDirectory("DownloadFile");
            Socket socket = Form1.socket;
            socket.Send(Encoding.UTF8.GetBytes($"Download:{{\"Id\":{Id}}}"));
            StreamWriter stream = new StreamWriter($"DownloadFile\\{NameFile.Text}");
            while(true)
            {
                byte[] data = new byte[1024 * 8];
                int len = socket.Receive(data);
                string str = Encoding.UTF8.GetString(data, 0, len);
                if (str.StartsWith("FileEnd"))
                {
                    stream.Close();
                    break;
                }
                stream.Write(str);
            }
            Close();
        }

        private void Open(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "DownloadFile\\" + NameFile.Text;
        }
    }
}
