namespace Desktop_Applicaion
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            reg_signInbtn = new Button();
            label4 = new Label();
            reg_btn = new Button();
            reg_showPass = new CheckBox();
            reg_password = new TextBox();
            label3 = new Label();
            reg_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            close = new Label();
            reg_cPassword = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // reg_signInbtn
            // 
            reg_signInbtn.BackColor = Color.FromArgb(133, 19, 33);
            reg_signInbtn.FlatAppearance.BorderSize = 0;
            reg_signInbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            reg_signInbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            reg_signInbtn.FlatStyle = FlatStyle.Flat;
            reg_signInbtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_signInbtn.ForeColor = Color.White;
            reg_signInbtn.Location = new Point(37, 584);
            reg_signInbtn.Name = "reg_signInbtn";
            reg_signInbtn.Size = new Size(332, 43);
            reg_signInbtn.TabIndex = 19;
            reg_signInbtn.Text = "Sign In Here";
            reg_signInbtn.UseVisualStyleBackColor = false;
            reg_signInbtn.Click += reg_signInbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 558);
            label4.Name = "label4";
            label4.Size = new Size(183, 23);
            label4.TabIndex = 18;
            label4.Text = "Ceate an Account";
            // 
            // reg_btn
            // 
            reg_btn.BackColor = Color.FromArgb(133, 19, 33);
            reg_btn.FlatAppearance.BorderSize = 0;
            reg_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            reg_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            reg_btn.FlatStyle = FlatStyle.Flat;
            reg_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_btn.ForeColor = Color.White;
            reg_btn.Location = new Point(39, 442);
            reg_btn.Name = "reg_btn";
            reg_btn.Size = new Size(330, 43);
            reg_btn.TabIndex = 17;
            reg_btn.Text = "REGISTER";
            reg_btn.UseVisualStyleBackColor = false;
            reg_btn.Click += reg_btn_Click;
            // 
            // reg_showPass
            // 
            reg_showPass.AutoSize = true;
            reg_showPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_showPass.Location = new Point(39, 357);
            reg_showPass.Name = "reg_showPass";
            reg_showPass.Size = new Size(148, 27);
            reg_showPass.TabIndex = 16;
            reg_showPass.Text = "Show Password";
            reg_showPass.UseVisualStyleBackColor = true;
            reg_showPass.CheckedChanged += reg_showPass_CheckedChanged;
            // 
            // reg_password
            // 
            reg_password.BorderStyle = BorderStyle.FixedSingle;
            reg_password.Location = new Point(37, 246);
            reg_password.Name = "reg_password";
            reg_password.PasswordChar = '*';
            reg_password.Size = new Size(332, 27);
            reg_password.TabIndex = 15;
            reg_password.TextChanged += reg_password_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 220);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // reg_username
            // 
            reg_username.BorderStyle = BorderStyle.FixedSingle;
            reg_username.ForeColor = Color.DimGray;
            reg_username.Location = new Point(37, 182);
            reg_username.Name = "reg_username";
            reg_username.Size = new Size(332, 27);
            reg_username.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 156);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 12;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 65);
            label1.Name = "label1";
            label1.Size = new Size(233, 29);
            label1.TabIndex = 11;
            label1.Text = "Registration Form";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(370, 19);
            close.Name = "close";
            close.Size = new Size(29, 32);
            close.TabIndex = 10;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // reg_cPassword
            // 
            reg_cPassword.BorderStyle = BorderStyle.FixedSingle;
            reg_cPassword.Location = new Point(37, 324);
            reg_cPassword.Name = "reg_cPassword";
            reg_cPassword.PasswordChar = '*';
            reg_cPassword.Size = new Size(332, 27);
            reg_cPassword.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 298);
            label5.Name = "label5";
            label5.Size = new Size(190, 23);
            label5.TabIndex = 20;
            label5.Text = "Confirm Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(280, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 670);
            Controls.Add(pictureBox1);
            Controls.Add(reg_cPassword);
            Controls.Add(label5);
            Controls.Add(reg_signInbtn);
            Controls.Add(label4);
            Controls.Add(reg_btn);
            Controls.Add(reg_showPass);
            Controls.Add(reg_password);
            Controls.Add(label3);
            Controls.Add(reg_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegForm";
            Load += RegForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reg_signInbtn;
        private Label label4;
        private Button reg_btn;
        private CheckBox reg_showPass;
        private TextBox reg_password;
        private Label label3;
        private TextBox reg_username;
        private Label label2;
        private Label label1;
        private Label close;
        private TextBox reg_cPassword;
        private Label label5;
        private PictureBox pictureBox1;
    }
}