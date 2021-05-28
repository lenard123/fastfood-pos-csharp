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
using FastFoodPOS.Forms;
using FastFoodPOS.Forms.AdminForms;

namespace FastFoodPOS.Components
{
    partial class UserCardComponent : UserControl
    {
        User user;

        public event EventHandler<User> OnUpdateButton_Click;
        public event EventHandler<User> OnRemoveButton_Click;
        public event EventHandler<User> OnActivityLogButton_Click;

        public UserCardComponent(User user)
        {
            InitializeComponent();

            this.user = user;

            LabelNameRole.Text = user.Fullname + " (" + user.Role + ")";
            LabelEmail.Text = user.Email;
            PictureImage.Image = Util.GetImageFromFile(user.Image);

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

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (OnUpdateButton_Click != null)
            {
                OnUpdateButton_Click(this, user);
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (OnRemoveButton_Click != null)
            {
                OnRemoveButton_Click(this, user);
            }
        }

        private void ButtonActivityLogs_Click(object sender, EventArgs e)
        {
            if (OnActivityLogButton_Click != null)
            {
                OnActivityLogButton_Click(this, user);
            }
        }
    }
}
