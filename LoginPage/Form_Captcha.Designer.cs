namespace LoginPage
{
    partial class Form_Captcha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Captcha));
            this.button_Captcha = new System.Windows.Forms.Button();
            this.label_Captcha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Captcha = new System.Windows.Forms.TextBox();
            this.button_Check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Captcha
            // 
            this.button_Captcha.BackgroundImage = global::LoginPage.Properties.Resources.arrow_refresh_reload_icon_29;
            this.button_Captcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Captcha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Captcha.Location = new System.Drawing.Point(122, 25);
            this.button_Captcha.Name = "button_Captcha";
            this.button_Captcha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Captcha.Size = new System.Drawing.Size(57, 40);
            this.button_Captcha.TabIndex = 14;
            this.button_Captcha.UseVisualStyleBackColor = false;
            this.button_Captcha.Click += new System.EventHandler(this.button_Captcha_Click);
            // 
            // label_Captcha
            // 
            this.label_Captcha.AutoSize = true;
            this.label_Captcha.BackColor = System.Drawing.Color.DarkOrange;
            this.label_Captcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Captcha.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Captcha.ForeColor = System.Drawing.Color.White;
            this.label_Captcha.Location = new System.Drawing.Point(185, 25);
            this.label_Captcha.Name = "label_Captcha";
            this.label_Captcha.Size = new System.Drawing.Size(2, 40);
            this.label_Captcha.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginPage.Properties.Resources.RecaptchaLogo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(375, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Captcha
            // 
            this.textBox_Captcha.BackColor = System.Drawing.Color.Bisque;
            this.textBox_Captcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Captcha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Captcha.ForeColor = System.Drawing.Color.Black;
            this.textBox_Captcha.Location = new System.Drawing.Point(122, 85);
            this.textBox_Captcha.Multiline = true;
            this.textBox_Captcha.Name = "textBox_Captcha";
            this.textBox_Captcha.Size = new System.Drawing.Size(247, 46);
            this.textBox_Captcha.TabIndex = 11;
            this.textBox_Captcha.Text = "\r\n\r\n\r\n";
            // 
            // button_Check
            // 
            this.button_Check.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Check.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Check.ForeColor = System.Drawing.Color.White;
            this.button_Check.Location = new System.Drawing.Point(35, 85);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(69, 46);
            this.button_Check.TabIndex = 15;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = false;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // Form_Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 179);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.button_Captcha);
            this.Controls.Add(this.label_Captcha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Captcha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Captcha";
            this.Text = "Form_Captcha";
            this.Load += new System.EventHandler(this.Form_Captcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Captcha;
        private Label label_Captcha;
        private PictureBox pictureBox1;
        private TextBox textBox_Captcha;
        private Button button_Check;
    }
}