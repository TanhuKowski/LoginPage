using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form_Login frm = new Form_Login();
            this.Hide();
            frm.Show();
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Username.Text == "" || textBox_Password.Text == "" || textBox_Confirm.Text == "")
                {
                    MessageBox.Show("Please fill all fields!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((textBox_Password.Text == textBox_Confirm.Text) && !Account.AccountExists(textBox_Username.Text))
                {
                    Account.RegisterAccount(textBox_Username.Text.Trim(), textBox_Password.Text);
                    textBox_Username.Text = "";
                    textBox_Password.Text = "";
                    textBox_Confirm.Text = "";
                    MessageBox.Show("Your account has been succesfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (Account.AccountExists(textBox_Username.Text.Trim()))
                {
                    MessageBox.Show("Account with this username is already created! Please, create another username", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Username.Text = "";
                    textBox_Password.Text = "";
                    textBox_Confirm.Text = "";
                    textBox_Username.Focus();
                }
                else
                {
                    MessageBox.Show("Passwords do not match, Please Re-Enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Password.Text = "";
                    textBox_Confirm.Text = "";
                    textBox_Password.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Please, do all the steps correctly!");
            }
        }

        private void checkBox_Password_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_Password.Checked)
            {
                textBox_Password.PasswordChar = '\0';
                textBox_Confirm.PasswordChar = '\0';
            }
            else
            {
                textBox_Password.PasswordChar = '•';
                textBox_Confirm.PasswordChar = '•';
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = '•';
        }

        private void textBox_Confirm_TextChanged(object sender, EventArgs e)
        {
            textBox_Confirm.PasswordChar = '•';
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Username.Text = "";
            textBox_Password.Text = "";
            textBox_Confirm.Text = "";
            textBox_Username.Focus();
        }
    }
}

