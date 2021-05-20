using FastFoodPOS.DatabaseUtil;
using FastFoodPOS.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS.Components
{
    class Validator
    {
        private Color default_border_color;
        private Guna2TextBox control;
        private Label error_message;
        private string name;
        private string rules;
        private bool is_validated;
        private bool is_valid = false;

        public Guna2TextBox compare_control { get; set; }

        public Validator(Guna2TextBox control, Label error_message, string name, string rules)
        {
            this.control = control;
            this.default_border_color = control.BorderColor;
            this.error_message = error_message;
            this.name = name;
            this.rules = rules;
            this.control.Leave += control_LostFocus;
            ResetStyle();
        }

        void control_LostFocus(object sender, EventArgs e)
        {
            if (is_validated)
            {
                Validate();
            }
        }

        public void Validate()
        {
            is_validated = true;

            ResetStyle();
            is_valid = true;
            string text = control.Text.Trim();
            string[] rules = this.rules.Split('|');
            foreach(string ruleString in rules) 
            {
                
                string[] rule = ruleString.Split(':');
                string ruleBody = rule[0];
                string ruleParam = rule.Length > 1 ? rule[1] : "";

                if(ruleBody.Equals("required")) {
                    if(text.Length == 0) {
                        is_valid = false;
                        control.BorderColor = Color.Red;
                        error_message.Text = "The " + name + " field is required";
                        break;
                    }
                }
                else if (ruleBody.Equals("min"))
                {
                    if (text.Length < Int32.Parse(ruleParam))
                    {
                        is_valid = false;
                        control.BorderColor = Color.Red;
                        error_message.Text = "The " + name + " field must have atleast " + ruleParam + " characters";
                        break;
                    }
                }
                else if (ruleBody.Equals("email"))
                {
                    if (!Util.IsEmail(text))
                    {
                        is_valid = false;
                        control.BorderColor = Color.Red;
                        error_message.Text = "The " + name + " field must be a valid email";
                        break;
                    }
                }
                else if (ruleBody.Equals("unique"))
                {
                    string table = ruleParam.Split(',')[0];
                    string column = ruleParam.Split(',')[1];
                    if (Database.IsExist(table, column, text.Trim()))
                    {
                        is_valid = false;
                        control.BorderColor = Color.Red;
                        error_message.Text = "The " + name + " already exists";
                        break;
                    }
                }
                else if (ruleBody.Equals("compare"))
                {
                    if (!text.Equals(compare_control.Text))
                    {
                        is_valid = false;
                        control.BorderColor = Color.Red;
                        error_message.Text = "The " + name + " field does not match";
                        break;
                    }
                }
            }
        }

        public void Reset()
        {
            is_validated = false;
            ResetStyle();
        }

        public bool IsValid()
        {
            Validate();
            return is_valid;
        }

        void ResetStyle()
        {
            error_message.Text = "";
            control.BorderColor = default_border_color;
        }

    }
}
