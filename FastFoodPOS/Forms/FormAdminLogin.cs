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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User loggedIn = User.Login(TextEmail.Text, TextPassword.Text);
                if (loggedIn.Role.Equals("Cashier"))
                    MainForm.LoadForm(new FormCashierPanel());
                else
                    MainForm.LoadForm(new FormAdminPanel(loggedIn));
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }

    }
}
