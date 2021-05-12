using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Forms.AdminForms
{
    interface IKeepable
    {
        bool ShouldKeepForm { get; set; }
        void OnMounted();
        void OnUnMounted();
    }
}
