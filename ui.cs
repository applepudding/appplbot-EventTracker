using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace appplbot_EventTracker
{
    public partial class ui : Form
    {
        private static string pluginPath = Directory.GetCurrentDirectory();
        public ui()
        {
            InitializeComponent();
        }

        private void ui_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.BackColor = Color.Magenta;
            //this.TransparencyKey = Color.Magenta;
            this.TopMost = true;
            
            this.timer1.Interval = 250;
            this.timer1.Enabled = true;
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/applbot-eventTracker/ui/index.html", pluginPath));
            //this.ShowInTaskbar = false;
        }

    }
}
