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
            SuspendLayout();
            // 
            // reg_signInbtn
            // 
            reg_signInbtn.BackColor = Color.FromArgb(133, 19, 33);
            reg_signInbtn.FlatAppearance.BorderSize = 0;
            reg_signInbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            reg_signInbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            reg_signInbtn.FlatStyle = FlatStyle.Flat;
            reg_signInbtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_signInbtn.ForeColor = Color.White;
            reg_signInbtn.Location = new Point(37, 560);
            reg_signInbtn.Name = "reg_signInbtn";
            reg_signInbtn.Size = new Size(295, 43);
            reg_signInbtn.TabIndex = 19;
            reg_signInbtn.Text = "Sign In Here";
            reg_signInbtn.UseVisualStyleBackColor = false;
            reg_signInbtn.Click += reg_signInbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(105, 524);
            label4.Name = "label4";
            label4.Size = new Size(168, 21);
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
            reg_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_btn.ForeColor = Color.White;
            reg_btn.Location = new Point(37, 399);
            reg_btn.Name = "reg_btn";
            reg_btn.Size = new Size(295, 43);
            reg_btn.TabIndex = 17;
            reg_btn.Text = "REGISTER";
            reg_btn.UseVisualStyleBackColor = false;
            reg_btn.Click += reg_btn_Click;
            // 
            // reg_showPass
            // 
            reg_showPass.AutoSize = true;
            reg_showPass.Location = new Point(37, 351);
            reg_showPass.Name = "reg_showPass";
            reg_showPass.Size = new Size(132, 24);
            reg_showPass.TabIndex = 16;
            reg_showPass.Text = "Show Password";
            reg_showPass.UseVisualStyleBackColor = true;
            reg_showPass.CheckedChanged += reg_showPass_CheckedChanged;
            // 
            // reg_password
            // 
            reg_password.BorderStyle = BorderStyle.FixedSingle;
            reg_password.Location = new Point(37, 249);
            reg_password.Name = "reg_password";
            reg_password.PasswordChar = '*';
            reg_password.Size = new Size(295, 27);
            reg_password.TabIndex = 15;
            reg_password.TextChanged += reg_password_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 225);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // reg_username
            // 
            reg_username.BorderStyle = BorderStyle.FixedSingle;
            reg_username.ForeColor = Color.DimGray;
            reg_username.Location = new Point(37, 185);
            reg_username.Name = "reg_username";
            reg_username.Size = new Size(295, 27);
            reg_username.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 161);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 12;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 80);
            label1.Name = "label1";
            label1.Size = new Size(213, 27);
            label1.TabIndex = 11;
            label1.Text = "Registration Form";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(331, 21);
            close.Name = "close";
            close.Size = new Size(24, 27);
            close.TabIndex = 10;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // reg_cPassword
            // 
            reg_cPassword.BorderStyle = BorderStyle.FixedSingle;
            reg_cPassword.Location = new Point(37, 319);
            reg_cPassword.Name = "reg_cPassword";
            reg_cPassword.PasswordChar = '*';
            reg_cPassword.Size = new Size(295, 27);
            reg_cPassword.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 295);
            label5.Name = "label5";
            label5.Size = new Size(173, 21);
            label5.TabIndex = 20;
            label5.Text = "Confirm Password";
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(368, 651);
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
    }
}