using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS.Forms
{
    public class BaseForm : UserControl
    {
        public virtual bool IsFullScreen()
        {
            return true;
        }

        public virtual void OnLoad() { }
    }
}
