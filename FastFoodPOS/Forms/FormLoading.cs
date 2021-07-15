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
            INVALID_DATABASE_VERION,
            WRONG_PASSWORD,
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

            try
            {
                DatabaseUtil.Database.GetConnection().Open();
                DatabaseUtil.Database.GetConnection().Close();

                //Import tables
                DatabaseUtil.Database.GetProvider().ImportTables();

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
            catch (System.InvalidOperationException ex)
            {
                e.Result = Result.INVALID_DATABASE_VERION;
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                if (ex.Message.Equals("Not a valid password."))
                {
                    e.Result = Result.WRONG_PASSWORD;
                }
                else
                {
                    e.Result = Result.DATABASE_ERROR;
                }
            }

            //////Check database
            ////if (DatabaseUtil.Database.IsValidConnection())
            ////{
            ////    if (Models.User.HasAdminUser())
            ////    {
            ////        //Cache Data
            ////        Models.User.GetAll();
            ////        Models.Product.GetAllProducts();
            ////        e.Result = Result.SUCCESS;
            ////    }
            ////    else
            ////    {
            ////        e.Result = Result.NO_USER;
            ////    }
            ////}
            ////else
            ////{
            ////    e.Result = Result.DATABASE_ERROR;
            ////}
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
                case Result.INVALID_DATABASE_VERION:
                    MessageBox.Show("Please try the other variant or install Microsoft Access 2010 redistributable");
                    Application.Exit();
                    break;
                case Result.WRONG_PASSWORD:
                    MessageBox.Show("Wrong Password!");
                    MessageBox.Show("Contact me here at my email lenard.mangayayam@gmail.com" + Environment.NewLine + "to get the password");
                    Application.Exit();
                    break;
                case Result.DATABASE_ERROR:
                    MessageBox.Show("Oops!! Theres a problem while connecting to the database.");
                    Application.Exit();
                    break;
            }
        }


    }
}
