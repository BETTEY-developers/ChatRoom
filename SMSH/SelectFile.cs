using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace SMSH
{
    public partial class SelectFile : Form
    {
        Stream stream;
        Socket socket;
        const int BUFSIZE = 1024 * 8;
        public SelectFile(Socket sock)
        {
            socket = sock;
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            Openfile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Openfile.Multiselect = false;
            if(Openfile.ShowDialog() == DialogResult.OK)
            {
                stream = new FileStream(Openfile.FileName, FileMode.Open);
                FilePath.Text = Openfile.FileName;
                SendTimingName.Text = Path.GetFileName(Openfile.FileName);
                FileSize.Text = (stream.Length / 1024).ToString();
                if (stream.Length / 1024 > 1048576)
                    Error.Show();
                else
                    Error.Hide();
            }
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sendst = Encoding.UTF8.GetBytes($"File:{{\"FileName\":\"{SendTimingName.Text}\",\"Introduction\":\"{FileIntroduction.Text}\",\"Size\":{stream.Length.ToString()},\"Guid\":\"{Form1.guid}\"}}");
            socket.Send(sendst,sendst.Length,SocketFlags.None);
            button1.Enabled = false;
            SendFileData();
        }

        private void SendFileData()
        {
            byte[] data = new byte[BUFSIZE];
            if (stream.Position == stream.Length)
            {
                stream.Close();
                return;
            }
            int len = stream.Read(data, 0, BUFSIZE);
            socket.Send(data,len,SocketFlags.None);
            SendFileData();
        }
    }
}
