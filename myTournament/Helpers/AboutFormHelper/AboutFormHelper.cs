using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myTournament.Helpers.AboutFormHelper
{
    public partial class AboutFormHelper : UserControl
    {
        public AboutFormHelper(string _caption, string _copyright, string _licenseShort, string _linkLicense)
        {
            InitializeComponent();
            this.labelCaption.Text = _caption;
            this.labelCopyright.Text = _copyright;
            this.linkLicense.Text = _licenseShort;
            this.linkLicense.Links[0].LinkData = _linkLicense;
            this.linkLicense.LinkClicked += this.LinkClicked;
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
