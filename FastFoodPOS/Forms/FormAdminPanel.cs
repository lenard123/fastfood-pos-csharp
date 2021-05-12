using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodPOS.Forms.AdminForms;
using Guna.UI2.WinForms;
using FastFoodPOS.Models;

namespace FastFoodPOS.Forms
{
    partial class FormAdminPanel : BaseForm
    {
        User LoggedInUser = null;

        public static FormAdminPanel Instance;


        public FormAdminPanel(User _LoggedInUser)
        {
            InitializeComponent();

            Instance = this;
            LoggedInUser = _LoggedInUser;

            LabelUserName.Text = LoggedInUser.Fullname;
            LabelUserRole.Text = LoggedInUser.Role;

            UserControl manageProducts = new FormUsers();
            manageProducts.Dock = DockStyle.Fill;
            panel5.Controls.Add(manageProducts);
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            Guna2Button ButtonMenu = (Guna2Button)sender;

            switch (Convert.ToInt16(ButtonMenu.Tag))
            {
                case 2:
                    LoadFormControl(new FormAddProduct());
                    break;
                case 3:
                    LoadFormControl(new FormManageProducts());
                    break;
                case 4:
                    LoadFormControl(new FormTransactions());
                    break;
                case 6:
                    LoadFormControl(new FormUsers());
                    break;
            }

        }

        public void LoadFormControl(UserControl uc)
        {
            DisposeAdminForm();

            IKeepable ucKeepable = uc as IKeepable;
            
            uc.Dock = DockStyle.Fill;
            panel5.Controls.Add(uc);

            if (ucKeepable != null) ((IKeepable)uc).OnMounted();
        }

        private void DisposeAdminForm()
        {
            while (panel5.Controls.Count >= 1)
            {
                IKeepable ucToRemove = panel5.Controls[0] as IKeepable;
                if (ucToRemove != null)
                {
                    ucToRemove.OnUnMounted();
                    if (ucToRemove.ShouldKeepForm)
                        panel5.Controls.RemoveAt(0);
                    else
                        panel5.Controls[0].Dispose();
                }
                else
                {
                    panel5.Controls[0].Dispose();
                }
            }
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new FormAdminLogin());
        }

    }
}
