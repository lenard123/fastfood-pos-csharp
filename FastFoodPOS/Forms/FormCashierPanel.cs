using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodPOS.Models;
using FastFoodPOS.Forms.CashierForms;

namespace FastFoodPOS.Forms
{
    partial class FormCashierPanel : BaseForm
    {
        User cashier;

        static FormCashierPanel Instance;

        public FormCashierPanel(User loggedin)
        {
            InitializeComponent();

            Instance = this;

            this.cashier = loggedin;
            LinkLabelName.Text = cashier.Fullname;
            PictureUserImage.Image = Util.GetImageFromFile(loggedin.Image);

            LoadControl(new FormPOS(loggedin));

        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            if (Dialog.ConfirmDialogBox.ShowDialog("Are you sure to logout?") == DialogResult.Yes)
                MainForm.LoadForm(new FormAdminLogin());
        }

        public static void LoadControl(BaseForm form)
        {
            Instance.panel2.Controls.Clear();
            GC.Collect();
            form.Dock = DockStyle.Fill;
            Instance.panel2.Controls.Add(form);
        }

        private void LinkLabelName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadControl(new FormUpdatePassword(cashier));
        }
    }
}
