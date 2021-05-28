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
    public partial class FormUsers : UserControl
    {
        List<User> AllUsers;
        public FormUsers()
        {
            InitializeComponent();
            RefreshUser();
        }

        void RefreshUser()
        {
            AllUsers = User.GetAll();
            PanelUsers.Controls.Clear();
            AllUsers.ForEach((User user) =>
            {
                if (user.Id != User.CurrentUser.Id)
                {
                    var user_component = new UserCardComponent(user);
                    user_component.OnUpdateButton_Click += component_OnUpdateButton_Click;
                    user_component.OnRemoveButton_Click += user_component_OnRemoveButton_Click;
                    user_component.OnActivityLogButton_Click += user_component_OnActivityLogButton_Click;
                    PanelUsers.Controls.Add(user_component);
                }
            });
        }

        void user_component_OnActivityLogButton_Click(object sender, User e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormActivityLog(e));
        }

        void user_component_OnRemoveButton_Click(object sender, User e)
        {
            DialogResult result = Dialog.ConfirmDialogBox.ShowDialog("Are you sure to remove " + e.Fullname);
            if (result == DialogResult.Yes)
            {
                e.Remove();
                MessageBox.Show("User successfully removed");
                RefreshUser();
            }
        }

        void component_OnUpdateButton_Click(object sender, User e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormUpdateUser(e));
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormAddUser());
        }
    }
}
