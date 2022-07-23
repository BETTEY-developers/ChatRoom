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
    public partial class SendRtfMessageWindow : Form
    {
        List<RtfText.RtfBlock> blocks;
        RtfText.RtfBlock CurrentBlock; 
        public SendRtfMessageWindow()
        {
            InitializeComponent();
        }

        private void SetFont_Click(object sender, EventArgs e)
        {
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                Rtf.Font = fontDialog.Font;
            }
        }

        private void SetForeColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                Rtf.ForeColor = colorDialog.Color;
            }
        }

        private void SetBackColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                Rtf.BackColor = colorDialog.Color;
            }
        }

        private void Parse_Click(object sender, EventArgs e)
        {
            Rtf.Paste();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            Rtf.Cut();
        }

        private void Clone_Click(object sender, EventArgs e)
        {
            Rtf.Copy();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Rtf.SelectedText = "";
        }

        private void SetSlectedForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                Rtf.SelectionColor = colorDialog.Color;
            }
            blocks.Add(block);
        }

        private void Rtf_SelectionChanged(object sender, System.EventArgs e)
        {
            if(CurrentBlock == null)
            {
                CurrentBlock = new RtfText.RtfBlock();
                CurrentBlock.StartIndex = Rtf.SelectionStart;
                CurrentBlock.EndIndex = Rtf.SelectionStart + Rtf.SelectionLength;   
            }
        }
    }
}
