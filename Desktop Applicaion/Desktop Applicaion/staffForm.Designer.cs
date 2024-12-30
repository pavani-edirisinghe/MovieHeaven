namespace Desktop_Applicaion
{
    partial class staffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffForm));
            panel1 = new Panel();
            button1 = new Button();
            logout_btn = new Button();
            custormers_btn = new Button();
            dashboard_btn = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            buyTicketForm1 = new buyTicketForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(133, 19, 33);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(logout_btn);
            panel1.Controls.Add(custormers_btn);
            panel1.Controls.Add(dashboard_btn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 800);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 12F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 318);
            button1.Name = "button1";
            button1.Size = new Size(220, 49);
            button1.TabIndex = 6;
            button1.Text = "BUY TICKET";
            button1.UseVisualStyleBackColor = true;
            // 
            // logout_btn
            // 
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial Narrow", 12F);
            logout_btn.ForeColor = Color.White;
            logout_btn.Image = Properties.Resources.icons8_logout_rounded_30;
            logout_btn.ImageAlign = ContentAlignment.MiddleLeft;
            logout_btn.Location = new Point(12, 674);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(220, 49);
            logout_btn.TabIndex = 5;
            logout_btn.Text = "LOG OUT";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // custormers_btn
            // 
            custormers_btn.FlatAppearance.BorderSize = 0;
            custormers_btn.FlatStyle = FlatStyle.Flat;
            custormers_btn.Font = new Font("Arial Narrow", 12F);
            custormers_btn.ForeColor = Color.White;
            custormers_btn.Image = Properties.Resources.user;
            custormers_btn.ImageAlign = ContentAlignment.MiddleLeft;
            custormers_btn.Location = new Point(12, 410);
            custormers_btn.Name = "custormers_btn";
            custormers_btn.Size = new Size(220, 49);
            custormers_btn.TabIndex = 4;
            custormers_btn.Text = " CUSTORMERS";
            custormers_btn.UseVisualStyleBackColor = true;
            // 
            // dashboard_btn
            // 
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial Narrow", 12F);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Image = (Image)resources.GetObject("dashboard_btn.Image");
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(12, 228);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(220, 49);
            dashboard_btn.TabIndex = 1;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1170, 63);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_user_30;
            pictureBox2.Location = new Point(886, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(934, 25);
            label3.Name = "label3";
            label3.Size = new Size(156, 17);
            label3.TabIndex = 1;
            label3.Text = "Welcome,MarcoMan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 18);
            label2.Name = "label2";
            label2.Size = new Size(287, 20);
            label2.TabIndex = 1;
            label2.Text = "Movie Ticket Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1112, 22);
            label1.Name = "label1";
            label1.Size = new Size(21, 21);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buyTicketForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(1170, 737);
            panel3.TabIndex = 3;
            // 
            // buyTicketForm1
            // 
            buyTicketForm1.Location = new Point(0, 0);
            buyTicketForm1.Name = "buyTicketForm1";
            buyTicketForm1.Size = new Size(1462, 921);
            buyTicketForm1.TabIndex = 0;
            // 
            // staffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 800);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "staffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "staffForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button logout_btn;
        private Button custormers_btn;
        private Button dashboard_btn;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Panel panel3;
        private buyTicketForm buyTicketForm1;
    }
}