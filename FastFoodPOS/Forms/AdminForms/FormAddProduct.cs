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
    public partial class FormAddProduct : UserControl
    {
        List<Validator> validators;
        string category;
        public FormAddProduct(string from)
        {
            InitializeComponent();
            PictureProductImage.ImageLocation = Product.DEFAULT_IMAGE_PATH;

            category = from;

            ComboBoxType.Text = category;

            validators = new List<Validator>();
            validators.Add(new Validator(TextName, LabelName, "Name", "required"));

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(IsValid()){
                Product nProduct = new Product
                {
                    Name = TextName.Text,
                    Category = ComboBoxType.Text,
                    Price = TextPrice.Value,
                    IsAvailable = ToggleAvailability.Checked,
                    Image = PictureProductImage.ImageLocation
                };
                nProduct.Save();
                category = ComboBoxType.Text;
                Log.AddLog("Add new product name " + TextName.Text);
                AlertNotification.ShowAlertMessage("Product added Successfully", AlertNotification.AlertType.SUCCESS);
                LinkBack_LinkClicked(null, null);
            }
        }

        private bool IsValid()
        {
            return validators.All((validator) => validator.IsValid());
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
            validators.ForEach((validator) => validator.Reset());
        }

        private void TextPrice_Leave(object sender, EventArgs e)
        {
            if (TextPrice.Text.Length == 0)
            {
                TextPrice.Text = "0";
            }
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            ParentForm.AcceptButton = ButtonSave;
        }

        private void LinkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormManageProducts(category));
        }
    }
}
