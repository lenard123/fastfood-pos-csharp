using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodPOS.Components;
using FastFoodPOS.Models;

namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormUpdateCurrentUser : UserControl
    {
        List<Validator> validators;
        User uuser;

        public event EventHandler<User> OnUpdate_Success;

        public FormUpdateCurrentUser(User uuser)
        {
            InitializeComponent();
            this.uuser = uuser;
            validators = new List<Validator>();
            validators.Add(new Validator(TextName, LabelName, "Name", "required|min:5|name"));
            validators.Add(new Validator(TextEmail, LabelEmail, "Email", "required|email|unique:users,email") { unique_ignore = uuser.Email });
            Reset();   
        }

        void Reset()
        {
            PictureUserImage.ImageLocation = uuser.Image;
            TextName.Text = uuser.Fullname;
            TextEmail.Text = uuser.Email;
            validators.ForEach((validator) => validator.Reset());

            if (User.CurrentUser.Role == "SubAdministrator")
            {
                TextName.Enabled = false;
                TextEmail.Enabled = false;
            }

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (validators.Count((validator) => validator.IsValid()) == validators.Count)
            {
                User updated = uuser.Clone();
                updated.Fullname = TextName.Text;
                updated.Email = TextEmail.Text;
                updated.newImage = PictureUserImage.ImageLocation;
                updated.Update();
                MessageBox.Show("Updated Successfully");

                if (uuser.Image != PictureUserImage.ImageLocation) Log.AddLog("Changed Profile picture");

                if (OnUpdate_Success != null)
                {
                    OnUpdate_Success(this, updated);
                }
            }
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogChangeImage.ShowDialog() == DialogResult.OK)
            {
                PictureUserImage.ImageLocation = OpenFileDialogChangeImage.FileName;
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormChangePassword());
        }
    }
}
