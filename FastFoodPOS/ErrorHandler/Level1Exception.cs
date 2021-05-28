using FastFoodPOS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS.ErrorHandler
{
    class Level1Exception : Exception
    {
        public Level1Exception(string message) : base(message)
        {
        }

        public void DisplayMessage()
        {
            //MessageBox.Show(Message);
            AlertNotification.ShowAlertMessage(Message, AlertNotification.AlertType.ERROR);
        }
    }
}
