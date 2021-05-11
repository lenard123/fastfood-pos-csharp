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
    public partial class FormAddProduct : UserControl
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Product nProduct = new Product
            {
                Name = TextName.Text,
                Category = ComboBoxType.Text,
                Price = decimal.Parse(TextPrice.Text),
                IsAvailable = ToggleAvailability.Checked
            };
            nProduct.Save();
            MessageBox.Show("Product added Successfully");
        }
    }
}
