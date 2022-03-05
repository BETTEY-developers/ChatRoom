using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmshControl;
using System.Windows.Forms;

namespace SMSH
{
    public partial class FileManger : Form
    {
        FileControl fileControl;
        public FileManger()
        {
            InitializeComponent();
            foreach(FileInfo fi in Static.filelist)
            {
                FileControl fileControl = new FileControl();
                fileControl.FileName = fi.FileName;
                fileControl.FileIntroduction = fi.Introduction;
                fileControl.UpdateUser = fi.Name;
                fileControl.InfoClicked += (sender, e) => { new InfoPage(fi.FileName, fi.Introduction, fi.FileName, fi.IsDownload, fi.Size).Show(); };
                List.Controls.Add(fileControl);    
            }
        }
    }
}
