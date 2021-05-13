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
            AllUsers = User.GetAll();
            AllUsers.ForEach((User user) =>
            {
                PanelUsers.Controls.Add(new UserCardComponent(user));
            });
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            FormAdminPanel.Instance.LoadFormControl(new FormAddUser());
        }
    }
}
