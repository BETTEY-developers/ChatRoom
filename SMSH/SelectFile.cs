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

namespace SMSH
{
    struct FormTag
    {
        public FormTag(string filename, string filepath, string sendtimingname, string introduction, long length)
        {
            this.filename = filename;
            this.filepath = filepath;
            this.sendtimingname = sendtimingname;
            this.introduction = introduction;
            this.length = length;
        }

        string filename;
        string filepath;
        string sendtimingname;
        string introduction;
        long length;

        public string Filename { get => filename; set => filename = value; }
        public string Filepath { get => filepath; set => filepath = value; }
        public string Sendtimingname { get => sendtimingname; set => sendtimingname = value; }
        public string Introduction { get => introduction; set => introduction = value; }
        public long Length { get => length; set => length = value; }
    }
    public partial class SelectFile : Form
    {
        public SelectFile()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            Openfile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Openfile.Multiselect = false;
            if(Openfile.ShowDialog() == DialogResult.OK)
            {
                FilePath = Openfile.FileName;
                
            }

        }
    }
}
