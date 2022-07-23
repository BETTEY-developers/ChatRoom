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
        const int BUFSIZE = 1024 * 8;
        Group group;
        public SelectFile(Group group)
        {
            this.group = group;
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
                {
                    Error.Show();
                    stream.Close();
                    return;
                }
                else
                    Error.Hide();
            }
            button1.Enabled = true;
            stream.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            group.SendFileData(FilePath.Text, SendTimingName.Text, FileIntroduction.Text);
            button1.Enabled = false;
        }
    }
}
