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
    partial class FormActivityLog : UserControl
    {
        public FormActivityLog(User user)
        {
            InitializeComponent();
            var logs = Log.GetLogs(user);
            logs.ForEach(log =>
            {
                DataGridViewLogs.Rows.Add(
                    log.date_created.ToString(),
                    user.Fullname,
                    log.activity
                );
            });
            if (logs.Count == 0)
            {
                DataGridViewLogs.Rows.Add(
                    "", "There is no activity made by this user", ""
                );
            }
        }
    }
}
