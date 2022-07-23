using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Resources;

namespace SMSH
{
    internal class Emoji
    {
        public string Description { get; set; }
        public string EChar { get; set; }
        int n = 0;
        public Emoji(string Line,int n)
        {
            this.n = n;
            Description = new Regex(@"(?<=\[)(.*)(?=\])").Match(Line).Value;
            EChar = Covu(new Regex(@"(?<=\<)(.*)(?=\>)").Match(Line).Value);
        }
        private string Covu(string U)
        {
            StringBuilder dst = new StringBuilder();
            string[] src = U.Replace("U+","0x").Split(' ');
            int len = src.Length;
            for (int i = 0; i <= len - 1; i++)
            {
                dst.Append(Convert.ToChar(Convert.ToInt32(src[i],16)));
                UTF32Encoding v = new UTF32Encoding();
                //v.GetString()
            }
            return dst.ToString();
        }
    }
    internal class EmojiList
    {
        public List<Emoji> Emojis { get; private set; }
        public EmojiList()
        {
            Emojis = new List<Emoji>();
            ResourceManager resources = new ResourceManager("SMSH.Properties.Resources", typeof(Properties.Resources).Assembly);
            string stre = (string)resources.GetObject("Emoji");
            string[] lines = stre.Split('\n');
            int n = 0;
            foreach(string line in lines)
            {
                Emoji emoji = new Emoji(line, n);
                Emojis.Add(emoji);
                n++;
            }
        }
    }
}
