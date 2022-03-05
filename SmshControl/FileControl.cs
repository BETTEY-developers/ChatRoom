using SmshControl.Properties;
using System;
using System.Windows.Forms;

namespace SmshControl
{
    public partial class FileControl : UserControl
    {
        public event EventHandler InfoClicked;
        public string FileName {
            get
            {
                return FileName;
            }
            set
            {
                SetPicture(System.IO.Path.GetExtension(value));
                NameFile.Text = value;
            } 
        }
        public string FileIntroduction 
        {
            set 
            { 
                IntroductionFile.Text = value; 
            }
            get
            {
                return FileIntroduction;
            }
        }
        public string UpdateUser
        {
            set
            {
                UserUpdate.Text = $"由 {value} 上传";
            }
            get
            {
                return UpdateUser;
            }
        }
        public FileControl()
        {
            InitializeComponent();
        }

        public void SetPicture(string FileExtension)
        {
            if(FileExtension == "exe" || FileExtension == "com")
            {
                Picture.Image = Resources.Execute;
            }
            else if(FileExtension == "txt" || FileExtension == "doc" || FileExtension == "log" || FileExtension == "sys")
            {
                Picture.Image = Resources.Text;
            }
            else if(FileExtension == "pdf")
            {
                Picture.Image = Resources.Pdf;
            }
            else if(FileExtension == "mp4" || FileExtension == "mkv")
            {
                Picture.Image = Resources.Video;
            }
            else if(FileExtension == "apk")
            {
                Picture.Image = Resources.Apk;
            }
            else if(FileExtension == "zip")
            {
                Picture.Image = Resources.Zip;
            }
            else if(FileExtension == "cs" || FileExtension == "cpp" || FileExtension == "i" || FileExtension == "c" ||
                    FileExtension == "html" || FileExtension == "htm" || FileExtension == "js" || FileExtension == "css" ||
                    FileExtension == "py" || FileExtension == "resx" || FileExtension == "cc")
            {
                Picture.Image = Resources.Code;
            }
            else
            {
                Picture.Image = Resources.Unknown;
            }
        }
    }
}
