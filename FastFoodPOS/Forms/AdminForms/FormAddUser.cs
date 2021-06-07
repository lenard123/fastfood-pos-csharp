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

namespace FastFoodPOS.Forms.AdminForms
{
    public partial class FormAddUser : UserControl
    {

        List<Validator> validators;

        public FormAddUser()
        {
            InitializeComponent();
            PictureUserImage.ImageLocation = User.DEFAULT_IMAGE_PATH;
            validators = new List<Validator>();
            validators.Add(new Validator(TextName, LabelName, "Name", "required|min:5|name"));
            validators.Add(new Validator(TextEmail, LabelEmail, "Email", "required|email|unique:users,email"));
            validators.Add(new Validator(TextPassword, LabelPassword, "Password", "required|min:8"));
            validators.Add(new Validator(TextConfirmPassword, LabelConfirmPassword, "Confirm Password", "required|min:8|compare"){ compare_control = TextPassword});
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormUsers());
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogChangeImage.ShowDialog() == DialogResult.OK)
            {
                PictureUserImage.ImageLocation = OpenFileDialogChangeImage.FileName;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validators.Count((validator) => validator.IsValid()) == validators.Count)
                {
                    var user = new User
                    {
                        Fullname = TextName.Text,
                        Email = TextEmail.Text,
                        Role = ComboBoxRole.Text,
                        Password = Util.GetHashSHA256(TextPassword.Text),
                        Image = PictureUserImage.ImageLocation
                    };
                    user.Save();
                    MessageBox.Show("User added successfully");
                    ButtonBack.PerformClick();
                }
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }
    }
}
