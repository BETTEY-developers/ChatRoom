using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSH
{
    public partial class EmojiForm : Form
    {
        EmojiList EmojiList = new EmojiList();
        public EmojiForm()
        {
            InitializeComponent();
            LoadEmojis();
        }

        private async void LoadEmojis()
        {
            await Task.Run(() =>
            {
                foreach (Emoji emoji in EmojiList.Emojis)
                {
                    var item = new ListViewItem();
                    item.Text = emoji.EChar;
                    item.Tag = emoji;
                    item.ToolTipText = emoji.Description;
                    emojiView.Items.Add(item);
                }
            });
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
