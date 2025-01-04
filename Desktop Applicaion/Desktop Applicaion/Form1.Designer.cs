namespace Desktop_Applicaion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            close = new Label();
            label1 = new Label();
            label2 = new Label();
            login_username = new TextBox();
            label3 = new Label();
            login_password = new TextBox();
            login_showPass = new CheckBox();
            login_btn = new Button();
            label4 = new Label();
            login_signupBtn = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(373, 19);
            close.Name = "close";
            close.Size = new Size(29, 32);
            close.TabIndex = 0;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 61);
            label1.Name = "label1";
            label1.Size = new Size(189, 29);
            label1.TabIndex = 1;
            label1.Text = "Login Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 145);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.FixedSingle;
            login_username.ForeColor = Color.DimGray;
            login_username.Location = new Point(51, 182);
            login_username.Name = "login_username";
            login_username.Size = new Size(332, 27);
            login_username.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 236);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // login_password
            // 
            login_password.BorderStyle = BorderStyle.FixedSingle;
            login_password.Location = new Point(54, 272);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(332, 27);
            login_password.TabIndex = 5;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(54, 304);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(148, 27);
            login_showPass.TabIndex = 6;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(133, 19, 33);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(54, 371);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(327, 43);
            login_btn.TabIndex = 7;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(120, 532);
            label4.Name = "label4";
            label4.Size = new Size(183, 23);
            label4.TabIndex = 8;
            label4.Text = "Ceate an Account";
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.FromArgb(133, 19, 33);
            login_signupBtn.FlatAppearance.BorderSize = 0;
            login_signupBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            login_signupBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            login_signupBtn.FlatStyle = FlatStyle.Flat;
            login_signupBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_signupBtn.ForeColor = Color.White;
            login_signupBtn.Location = new Point(54, 570);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(327, 43);
            login_signupBtn.TabIndex = 9;
            login_signupBtn.Text = "Sign Up Here";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(262, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 670);
            Controls.Add(pictureBox3);
            Controls.Add(login_signupBtn);
            Controls.Add(label4);
            Controls.Add(login_btn);
            Controls.Add(login_showPass);
            Controls.Add(login_password);
            Controls.Add(label3);
            Controls.Add(login_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label close;
        private Label label1;
        private Label label2;
        private TextBox login_username;
        private Label label3;
        private TextBox login_password;
        private CheckBox login_showPass;
        private Button login_btn;
        private Label label4;
        private Button login_signupBtn;
        private PictureBox pictureBox3;
    }
}
