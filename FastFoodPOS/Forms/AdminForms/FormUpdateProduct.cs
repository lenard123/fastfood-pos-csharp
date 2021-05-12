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
using FastFoodPOS.Components;

namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormUpdateProduct : UserControl, IKeepable
    {
        ProductCardComponent pcc;
        Product product;
        FormManageProducts context;
        public FormUpdateProduct(FormManageProducts context, ProductCardComponent pcc)
        {
            InitializeComponent();
            this.pcc = pcc;
            this.product = pcc.product;
            this.context = context;
            ResetData();
        }

        void ResetData()
        {
            PictureProductImage.ImageLocation = product.Image;
            TextName.Text = product.Name;
            ComboBoxType.Text = product.Category;
            TextPrice.Text = product.Price.ToString();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormAdminPanel.Instance.LoadFormControl(context);
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            product.Update(
                TextName.Text,
                ComboBoxType.Text,
                decimal.Parse(TextPrice.Text),
                PictureProductImage.ImageLocation
                );
            MessageBox.Show("Product updated successfully");
            pcc.UpdateData();
            ButtonBack.PerformClick();
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogChangeImage.ShowDialog() == DialogResult.OK)
            {
                PictureProductImage.ImageLocation = OpenFileDialogChangeImage.FileName;
            }
        }

        public bool ShouldKeepForm { get; set; }

        public void OnMounted()
        {

        }

        public void OnUnMounted()
        {
            context.ShouldKeepForm = false;
        }
    }
}
