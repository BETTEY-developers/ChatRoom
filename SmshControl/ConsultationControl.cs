using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmshControl.Consultation
{
    public delegate (string Title, string Introduction) ClickLinkNext(string title, string Introduction);
    public partial class ConsultationControl : UserControl
    {
        public event ClickLinkNext ClickLink;
        public ConsultationControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return Title;
            }
            set
            {
                tile.Text = value;
            }
        }

        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                ThisIntroduction.Text = value;
            }
        }

        private void Next_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClickLink(Title, Description);
        }
    }
}
