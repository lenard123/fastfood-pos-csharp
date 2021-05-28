using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS.Components
{
    public partial class AlertNotification : Form
    {

        private static List<AlertNotification> OpenForms = new List<AlertNotification>();
        Action action;

        public enum AlertType
        {
            SUCCESS,
            WARNING,
            ERROR,
            INFO
        }

        enum Action
        {
            WAIT,
            START,
            CLOSE
        }

        int x, y;

        public AlertNotification(string message, AlertType type)
        {
            InitializeComponent();
            string fname;
            Opacity = 0;
            StartPosition = FormStartPosition.Manual;
            for (int i = 1; i <= 10; i++)
            {
                fname = "alert" + i;
                var alert = OpenForms.FirstOrDefault((forms) => forms.Name == fname);
                if (alert == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    OpenForms.Add(this);
                    break;
                }
            }
            x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;

            switch (type)
            {
                case AlertType.SUCCESS:
                    pictureBox1.Image = Properties.Resources.check;
                    guna2Panel1.FillColor = Color.FromArgb(82, 152, 114);
                    break;
                case AlertType.WARNING:
                    pictureBox1.Image = Properties.Resources.error_white;
                    guna2Panel1.FillColor = Color.FromArgb(255, 164, 91);
                    break;
                case AlertType.ERROR:
                    pictureBox1.Image = Properties.Resources.error_white;
                    guna2Panel1.FillColor = Color.FromArgb(255, 70, 70);
                    break;
                case AlertType.INFO:
                    pictureBox1.Image = Properties.Resources.info;
                    guna2Panel1.FillColor = Color.FromArgb(71, 169, 248);
                    break;
            }

            Label1.Text = message;

        }


        public void showAlert()
        {
            action = Action.START;
            TopMost = true;
            Show();
            timer1.Start();
        }

        public static void ShowAlertMessage(string message, AlertType type)
        {
            var alert = (new AlertNotification(message, type));
            alert.showAlert();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case Action.START:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left -= 1;
                    }
                    else
                    {
                        if (Opacity == 1)
                        {
                            action = Action.WAIT;
                        }
                    }
                    break;
                case Action.WAIT:
                    timer1.Interval = 3000;
                    action = Action.CLOSE;
                    break;
                case Action.CLOSE:
                    timer1.Interval = 1;
                    Opacity -= 0.1;
                    Left += 1;
                    if (Opacity == 0)
                    {
                        OpenForms.Remove(this);
                        Dispose();
                    }
                    break;
            }
        }
    }
}
