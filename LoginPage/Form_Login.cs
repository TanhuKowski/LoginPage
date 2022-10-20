using System;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace LoginPage
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void button_SignIn_Click(object sender, EventArgs e)
        {
                if (Account.Login(textBox_Username_L.Text, textBox_Password_L.Text))
                {
                    MessageBox.Show($"Welcome, {textBox_Username_L.Text}", "Successfully logged into account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Captcha frm = new Form_Captcha();
                    this.Hide();
                    frm.Show();
            }

                else
                {
                    MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        private void button_SignUp_Click(object sender, EventArgs e)
        {
            FormSignUp frm = new FormSignUp();
            this.Hide();
            frm.Show();
        }
        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void checkBox_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Password.Checked)
            {
                textBox_Password_L.PasswordChar = '\0';

            }
            else
            {
                textBox_Password_L.PasswordChar = '•';

            }
        }

        private void textBox_Password_L_TextChanged(object sender, EventArgs e)
        {
            textBox_Password_L.PasswordChar = '•';
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Username_L.Text = "";
            textBox_Password_L.Text = "";
            textBox_Username_L.Focus();
        }
    }
}
