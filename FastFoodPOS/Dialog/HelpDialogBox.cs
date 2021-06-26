using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS.Dialog
{
    public partial class HelpDialogBox : Form
    {
        public HelpDialogBox()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }

        public static void ShowHelpDialog()
        {
            HelpDialogBox x = new HelpDialogBox();
            x.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
