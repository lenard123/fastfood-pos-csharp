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
            PictureProductImage.ImageLocation = Product.DEFAULT_IMAGE_PATH;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Product nProduct = new Product
            {
                Name = TextName.Text,
                Category = ComboBoxType.Text,
                Price = decimal.Parse(TextPrice.Text),
                IsAvailable = ToggleAvailability.Checked,
                Image = PictureProductImage.ImageLocation
            };
            nProduct.Save();
            MessageBox.Show("Product added Successfully");
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogChangeImage.ShowDialog() == DialogResult.OK)
            {
                PictureProductImage.ImageLocation = OpenFileDialogChangeImage.FileName;
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            PictureProductImage.ImageLocation = Product.DEFAULT_IMAGE_PATH;
            TextName.Text = "";
            ComboBoxType.SelectedIndex = 0;
            ToggleAvailability.Checked = true;
            TextPrice.Text = "";
        }
    }
}
