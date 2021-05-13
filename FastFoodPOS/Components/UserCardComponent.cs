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

namespace FastFoodPOS.Components
{
    partial class UserCardComponent : UserControl
    {
        User user;
        public UserCardComponent(User user)
        {
            InitializeComponent();

            this.user = user;

            LabelNameRole.Text = user.Fullname + " (" + user.Role + ")";
            LabelEmail.Text = user.Email;
            PictureImage.Image = Image.FromFile(user.Image);

            BackColor = Color.Transparent;
            Dock = DockStyle.Top;

            foreach (Control control in Controls)
            {
                control.MouseEnter += this.UserCardComponent_MouseHover;
                control.MouseLeave += this.UserCardComponent_MouseLeave;
            }

        }

        private void UserCardComponent_MouseHover(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void UserCardComponent_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }
    }
}
