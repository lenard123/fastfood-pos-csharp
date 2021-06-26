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
using FastFoodPOS.Components;

namespace FastFoodPOS.Forms.CashierForms
{
    partial class FormUpdatePassword : BaseForm
    {
        List<Validator> validators = new List<Validator>();
        User user;

        public FormUpdatePassword(User user)
        {
            InitializeComponent();
            this.user = user;

            validators.Add(new Validator(TextNewPassword, LabelNewPassword, "New Password", "required|min:8"));
            validators.Add(new Validator(TextConfirmPassword, LabelConfirmPassword, "Confirm Password", "required|min:8|compare") { compare_control = TextNewPassword });
            validators.Add(new Validator(TextOldPassword, LabelOldPassword, "Old Password", "required|min:8"));

        }

        public override void OnLoad()
        {
            ParentForm.AcceptButton = ButtonSave;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (validators.Count == validators.Count(validator => validator.IsValid()))
            {
                if (user.Password.Equals(Util.GetHashSHA256(TextOldPassword.Text)))
                {
                    User updated = user.Clone();
                    updated.Password = Util.GetHashSHA256(TextNewPassword.Text.Trim());
                    updated.Update();

                    user.Password = updated.Password;

                    AlertNotification.ShowAlertMessage("Password updated successfully", AlertNotification.AlertType.SUCCESS);

                    linkLabel1_LinkClicked(null, null);
                }
                else
                {
                    AlertNotification.ShowAlertMessage("Wrong Password", AlertNotification.AlertType.ERROR);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCashierPanel.LoadControl(new FormPOS(user));
        }
    }
}
