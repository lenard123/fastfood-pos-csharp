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
using FastFoodPOS.ErrorHandler;
using FastFoodPOS.Components;
using FastFoodPOS.Forms.CashierForms;

namespace FastFoodPOS.Forms
{
    public partial class FormAdminLogin : BaseForm
    {
        public override bool IsFullScreen()
        {
            return false;
        }

        public FormAdminLogin()
        {
            InitializeComponent();
        }

        public override void OnLoad()
        {
            TextEmail.Focus();
            ParentForm.AcceptButton = ButtonLogin;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User loggedIn = User.Login(TextEmail.Text, TextPassword.Text);
                AlertNotification.ShowAlertMessage("Logged in successfully", AlertNotification.AlertType.SUCCESS);
                if (loggedIn.Role.Equals("Cashier")){
                    MainForm.LoadForm(new FormCashierPanel(loggedIn));
                }else
                    MainForm.LoadForm(new FormAdminPanel(loggedIn));

            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
                TextEmail.Focus();
            }
        }

        private void VisibilityToggler_Click(object sender, EventArgs e)
        {
            TextPassword.UseSystemPasswordChar = !TextPassword.UseSystemPasswordChar;
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            Dialog.HelpDialogBox.ShowHelpDialog();
        }

    }
}
