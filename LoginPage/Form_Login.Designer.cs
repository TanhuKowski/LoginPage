namespace LoginPage
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.textBox_Username_L = new System.Windows.Forms.TextBox();
            this.textBox_Password_L = new System.Windows.Forms.TextBox();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.pictureBox_Username = new System.Windows.Forms.PictureBox();
            this.pictureBox_Password = new System.Windows.Forms.PictureBox();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.checkBox_Password = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Password)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Username_L
            // 
            this.textBox_Username_L.BackColor = System.Drawing.Color.Bisque;
            this.textBox_Username_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Username_L.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Username_L.ForeColor = System.Drawing.Color.Black;
            this.textBox_Username_L.Location = new System.Drawing.Point(78, 308);
            this.textBox_Username_L.Multiline = true;
            this.textBox_Username_L.Name = "textBox_Username_L";
            this.textBox_Username_L.Size = new System.Drawing.Size(382, 46);
            this.textBox_Username_L.TabIndex = 0;
            this.textBox_Username_L.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            // 
            // textBox_Password_L
            // 
            this.textBox_Password_L.BackColor = System.Drawing.Color.Bisque;
            this.textBox_Password_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Password_L.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Password_L.ForeColor = System.Drawing.Color.Black;
            this.textBox_Password_L.Location = new System.Drawing.Point(78, 436);
            this.textBox_Password_L.Multiline = true;
            this.textBox_Password_L.Name = "textBox_Password_L";
            this.textBox_Password_L.Size = new System.Drawing.Size(382, 46);
            this.textBox_Password_L.TabIndex = 1;
            this.textBox_Password_L.TextChanged += new System.EventHandler(this.textBox_Password_L_TextChanged);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::LoginPage.Properties.Resources.unnamed;
            this.pictureBox_Logo.Location = new System.Drawing.Point(78, 29);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(382, 206);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 2;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Username.Location = new System.Drawing.Point(78, 264);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(158, 41);
            this.label_Username.TabIndex = 3;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Password.Location = new System.Drawing.Point(78, 392);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(150, 41);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Password";
            // 
            // pictureBox_Username
            // 
            this.pictureBox_Username.Image = global::LoginPage.Properties.Resources.Sample_User_Icon;
            this.pictureBox_Username.Location = new System.Drawing.Point(12, 308);
            this.pictureBox_Username.Name = "pictureBox_Username";
            this.pictureBox_Username.Size = new System.Drawing.Size(60, 46);
            this.pictureBox_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Username.TabIndex = 6;
            this.pictureBox_Username.TabStop = false;
            // 
            // pictureBox_Password
            // 
            this.pictureBox_Password.Image = global::LoginPage.Properties.Resources.password;
            this.pictureBox_Password.Location = new System.Drawing.Point(12, 436);
            this.pictureBox_Password.Name = "pictureBox_Password";
            this.pictureBox_Password.Size = new System.Drawing.Size(60, 46);
            this.pictureBox_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Password.TabIndex = 7;
            this.pictureBox_Password.TabStop = false;
            // 
            // button_SignIn
            // 
            this.button_SignIn.BackColor = System.Drawing.Color.ForestGreen;
            this.button_SignIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_SignIn.ForeColor = System.Drawing.Color.White;
            this.button_SignIn.Location = new System.Drawing.Point(78, 545);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(130, 61);
            this.button_SignIn.TabIndex = 11;
            this.button_SignIn.Text = "Sign In";
            this.button_SignIn.UseVisualStyleBackColor = false;
            this.button_SignIn.Click += new System.EventHandler(this.button_SignIn_Click);
            // 
            // button_SignUp
            // 
            this.button_SignUp.BackColor = System.Drawing.Color.BlueViolet;
            this.button_SignUp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_SignUp.ForeColor = System.Drawing.Color.White;
            this.button_SignUp.Location = new System.Drawing.Point(334, 545);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(126, 61);
            this.button_SignUp.TabIndex = 12;
            this.button_SignUp.Text = "Sign Up";
            this.button_SignUp.UseVisualStyleBackColor = false;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Orange;
            this.button_Clear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Clear.Location = new System.Drawing.Point(334, 496);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(126, 43);
            this.button_Clear.TabIndex = 23;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // checkBox_Password
            // 
            this.checkBox_Password.AutoSize = true;
            this.checkBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Password.Location = new System.Drawing.Point(78, 501);
            this.checkBox_Password.Name = "checkBox_Password";
            this.checkBox_Password.Size = new System.Drawing.Size(180, 32);
            this.checkBox_Password.TabIndex = 22;
            this.checkBox_Password.Text = "Show Password";
            this.checkBox_Password.UseVisualStyleBackColor = true;
            this.checkBox_Password.CheckedChanged += new System.EventHandler(this.checkBox_Password_CheckedChanged);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(492, 618);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.checkBox_Password);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.pictureBox_Password);
            this.Controls.Add(this.pictureBox_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.textBox_Password_L);
            this.Controls.Add(this.textBox_Username_L);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Username_L;
        private TextBox textBox_Password_L;
        private PictureBox pictureBox_Logo;
        private Label label_Username;
        private Label label_Password;
        private PictureBox pictureBox_Username;
        private PictureBox pictureBox_Password;
        private Button button_SignIn;
        private Button button_SignUp;
        private Button button_Clear;
        private CheckBox checkBox_Password;
    }
}