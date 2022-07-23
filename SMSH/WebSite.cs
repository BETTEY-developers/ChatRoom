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
    public partial class WebSite : Form
    {
        public WebSite(string Uri)
        {
            InitializeComponent();
            webBrowser.Url = new Uri(Uri);
        }
    }
}
