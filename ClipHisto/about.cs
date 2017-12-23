using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipHisto
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void clearlist_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/TabishRafiq/ClipHisto");
        }
    }
}
