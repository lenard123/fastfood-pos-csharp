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

namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormUpdateUser : UserControl
    {
        User user;
        List<Validator> validators = new List<Validator>();

        public FormUpdateUser(User user)
        {
            InitializeComponent();
            this.user = user;
            validators.Add(new Validator(TextName, LabelName, "Name", "required|min:5|name"));
            validators.Add(new Validator(TextEmail, LabelEmail, "Email", "required|email|unique:users,email") { unique_ignore = user.Email });
            AutoFillData();
        }

        private void AutoFillData()
        {
            PictureUserImage.ImageLocation = user.Image;
            TextName.Text = user.Fullname;
            TextEmail.Text = user.Email;
        }

        private void LinkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormUsers());
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            AutoFillData();
            validators.ForEach(validator => validator.Reset());
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (validators.Count((validator) => validator.IsValid()) == validators.Count)
            {
                User updated = user.Clone();
                updated.Fullname = TextName.Text;
                updated.Email = TextEmail.Text;
                updated.newImage = PictureUserImage.ImageLocation;
                updated.Update();
                MessageBox.Show("User Updated Successfully");
                LinkBack_LinkClicked(this, null);
            }
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogChangeImage.ShowDialog() == DialogResult.OK)
            {
                PictureUserImage.ImageLocation = OpenFileDialogChangeImage.FileName;
            }
        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
