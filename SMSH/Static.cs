using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSH
{
    public class FileInfo
    {
        static int FileNum;
        public FileInfo()
        {
            FileNum++;
        }
        public string FileName { get; set; }
        public string Introduction { get; set; }
        public long Size { get; set; }
        public long Id { get; private set; }
        public string Name { get; set; }
        public bool IsDownload { get; set; }
    }
    public class Static
    {
        static public List<FileInfo> filelist = new List<FileInfo>();  
    }
}
