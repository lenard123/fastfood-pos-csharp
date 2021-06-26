using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS.Forms
{
    public partial class FormLoading : BaseForm
    {

        enum Result
        {
            SUCCESS,
            DATABASE_ERROR,
            NO_USER
        }

        public override void OnLoad()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        public override bool IsFullScreen()
        {
            return false;
        }

        public FormLoading()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(2500); //delay a little bit
            //Check database
            if (DatabaseUtil.Database.IsValidConnection())
            {
                if (Models.User.HasAdminUser())
                {
                    //Cache Data
                    Models.User.GetAll();
                    Models.Product.GetAllProducts();
                    e.Result = Result.SUCCESS;
                }
                else
                {
                    e.Result = Result.NO_USER;
                }
            }
            else
            {
                e.Result = Result.DATABASE_ERROR;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            guna2WinProgressIndicator1.Visible = false;
            switch ((Result)e.Result)
            {
                case Result.SUCCESS:
                    MainForm.LoadForm(new FormAdminLogin());
                    break;
                case Result.NO_USER:
                    MainForm.LoadForm(new FormRegistration());
                    break;
                case Result.DATABASE_ERROR:
                    MessageBox.Show("Oops!! Theres a problem while connecting to the database.");
                    Application.Exit();
                    break;
            }
        }


    }
}
