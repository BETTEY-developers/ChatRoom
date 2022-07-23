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
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDownload { get; set; }
    }
    public class Static
    {
        static public List<FileInfo> filelist = new List<FileInfo>();  
    }

    public class RtfText
    {
        public struct Color
        {
            public int Red { get; set; }
            public int Green { get; set; }
            public int Blue { get; set; }
        }
        public struct FontInfo
        {
            public string FontFamliy { get; set; }
            public int Height { get; set; }
            public float Size { get; set; }
            public bool Italic { get; set; }
            public bool Underline { get; set; }
            public bool Bold { get; set; }
        }
        public class RtfBlock
        {
            public int StartIndex { get; set; }
            public int EndIndex { get; set; }
            public Color Color { get; set; }
            public FontInfo FontInfo { get; set; }
            public Color BackColor { get; set; }

        }
        public List<RtfBlock> Blocks = new List<RtfBlock>();
        public RtfBlock AllFont { get; set; }
        public string OriginalString { get; set; }
        public int TextAlign { get; set; }
    }
}
