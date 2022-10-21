namespace LoginPage
{
    public partial class Form_Captcha : Form
    {
        private string captcha = "";
        Random random = new Random();
        public Form_Captcha()
        {
            InitializeComponent();
        }



        private void getCaptcha()
        {
            string captcha = "";
            for (int i = 0; i < random.Next(6, 10); i++)
            {
                if (random.Next(2) % 2 == 0)
                {
                    captcha += char.ConvertFromUtf32(random.Next(65, 91));
                    continue;
                }
                captcha += char.ConvertFromUtf32(random.Next(48, 58));
            }
            this.captcha = captcha;
            label_Captcha.Text = captcha;
        }
        private void Form_Captcha_Load(object sender, EventArgs e)
        {
            getCaptcha();
        }
        private void button_Check_Click(object sender, EventArgs e)
        {
            if (textBox_Captcha.Text.ToLower().Trim() != label_Captcha.Text.ToLower().Trim())
            {
                MessageBox.Show("Captcha is incorrect!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                getCaptcha();
                textBox_Captcha.Text = "";
                textBox_Captcha.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Captcha Succeed!");
            }
        }

        private void button_Captcha_Click(object sender, EventArgs e)
        {
            getCaptcha();
        }
    }
}
