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

        private static FormAdminPanel Instance;

        public static FormAdminPanel GetInstance()
        {
            return Instance;
        }

        public FormAdminPanel(User _LoggedInUser)
        {
            InitializeComponent();

            Instance = this;
            LoggedInUser = _LoggedInUser;


        }

        public override void OnLoad()
        {
            Reset();

            ButtonDashboard.PerformClick();
        }

        private void Reset()
        {
            PictureUserImage.Image = Util.GetImageFromFile(LoggedInUser.Image);
            LabelUserName.Text = LoggedInUser.Fullname;
            LabelUserRole.Text = LoggedInUser.Role;

            if (LoggedInUser.Role == "SubAdministrator")
            {
                ButtonUsers.Visible = false;
                ButtonArchives.Visible = false;
            }

        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            Guna2Button ButtonMenu = (Guna2Button)sender;

            switch (Convert.ToInt16(ButtonMenu.Tag))
            {
                case 1:
                    LoadFormControl(new FormDashboard());
                    break;
                case 3:
                    LoadFormControl(new FormManageProducts());
                    break;
                case 4:
                    LoadFormControl(new FormTransactions());
                    break;
                case 5:
                    LoadFormControl(new FormSalesReport());
                    break;
                case 6:
                    LoadFormControl(new FormUsers());
                    break;
                case 7:
                    LoadFormControl(new FormProductArchive());
                    break;
            }

        }

        public void LoadFormControl(UserControl uc)
        {
            ParentForm.AcceptButton = null;
            DisposeAdminForm(ref uc);

            IKeepable ucKeepable = uc as IKeepable;
            
            uc.Dock = DockStyle.Fill;
            panel5.Controls.Add(uc);

            if (ucKeepable != null) ((IKeepable)uc).OnMounted();
        }

        private void DisposeAdminForm(ref UserControl next)
        {
            while (panel5.Controls.Count >= 1)
            {
                IKeepable ucToRemove = panel5.Controls[0] as IKeepable;
                if (ucToRemove != null)
                {
                    ucToRemove.OnUnMounted(ref next);
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
            if(Dialog.ConfirmDialogBox.ShowDialog("Are you sure to logout?") == DialogResult.Yes)
                MainForm.LoadForm(new FormAdminLogin());
        }

        private void ButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            FormUpdateCurrentUser fuu = new FormUpdateCurrentUser(LoggedInUser);
            fuu.OnUpdate_Success += fuu_OnUpdate_Success;
            LoadFormControl(fuu);
            foreach (Guna2Button btn in ButtonsMenuPanel.Controls)
            {
                if (btn.Checked) btn.Checked = false;
            }
        }

        void fuu_OnUpdate_Success(object sender, User e)
        {
            this.LoggedInUser = e;
            User.CurrentUser = e;
            Reset();
            ButtonDashboard.PerformClick();
        }

    }
}
