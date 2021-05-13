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

namespace FastFoodPOS.Forms.AdminForms
{
    public partial class FormAddUser : UserControl
    {
        public FormAddUser()
        {
            InitializeComponent();
            PictureUserImage.ImageLocation = User.DEFAULT_IMAGE_PATH;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormAdminPanel.Instance.LoadFormControl(new FormUsers());
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
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }
    }
}
