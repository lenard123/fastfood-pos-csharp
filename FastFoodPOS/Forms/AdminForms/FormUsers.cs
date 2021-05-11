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

namespace FastFoodPOS.Forms.AdminForms
{
    public partial class FormUsers : UserControl
    {
        public FormUsers()
        {
            InitializeComponent();
            List<UserModel> list = new List<UserModel>();
            User.fakeData().ForEach((User user) => { list.Add(new UserModel(user)); });
            userModelBindingSource.DataSource = list;
        }
    }

    class UserModel
    {
        public int UserID
        {
            get;
            set;
        }

        public string Fullname
        {
            get;
            set;
        }


        public string Email
        {
            get;
            set;
        }

        public string Role
        {
            get;
            set;
        }

        public UserModel(User user)
        {
            UserID = user.Id;
            Fullname = user.Fullname;
            Email = user.Email;
            Role = user.Role;
        }
    }
}
