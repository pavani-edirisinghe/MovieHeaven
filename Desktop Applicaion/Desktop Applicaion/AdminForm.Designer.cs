namespace Desktop_Applicaion
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panel3 = new Panel();
            dashboardForm1 = new dashboardForm();
            addStaffsForm1 = new AddStaffsForm();
            addMovieForm2 = new AddMovieForm();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            dashboard_btn = new Button();
            addStaff_btn = new Button();
            addMovie_btn = new Button();
            logout_btn = new Button();
            panel1 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboardForm1);
            panel3.Controls.Add(addStaffsForm1);
            panel3.Controls.Add(addMovieForm2);
            panel3.Location = new Point(250, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(1170, 737);
            panel3.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            dashboardForm1.Location = new Point(0, 0);
            dashboardForm1.Name = "dashboardForm1";
            dashboardForm1.Size = new Size(1462, 921);
            dashboardForm1.TabIndex = 2;
            // 
            // addStaffsForm1
            // 
            addStaffsForm1.Location = new Point(0, 0);
            addStaffsForm1.Name = "addStaffsForm1";
            addStaffsForm1.Size = new Size(1462, 921);
            addStaffsForm1.TabIndex = 1;
            // 
            // addMovieForm2
            // 
            addMovieForm2.Location = new Point(0, 0);
            addMovieForm2.Name = "addMovieForm2";
            addMovieForm2.Size = new Size(1462, 921);
            addMovieForm2.TabIndex = 0;
            addMovieForm2.Load += addMovieForm2_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1123, 17);
            label1.Name = "label1";
            label1.Size = new Size(26, 27);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 18);
            label2.Name = "label2";
            label2.Size = new Size(390, 27);
            label2.TabIndex = 1;
            label2.Text = "Movie Ticket Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(896, 18);
            label3.Name = "label3";
            label3.Size = new Size(194, 27);
            label3.TabIndex = 1;
            label3.Text = "Welcome,Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(840, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
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
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dashboard_btn
            // 
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Image = (Image)resources.GetObject("dashboard_btn.Image");
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(12, 206);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(220, 49);
            dashboard_btn.TabIndex = 1;
            dashboard_btn.Text = "  DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = true;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // addStaff_btn
            // 
            addStaff_btn.FlatAppearance.BorderSize = 0;
            addStaff_btn.FlatStyle = FlatStyle.Flat;
            addStaff_btn.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStaff_btn.ForeColor = Color.White;
            addStaff_btn.Image = Properties.Resources.icons8_add_male_user_30;
            addStaff_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addStaff_btn.Location = new Point(12, 282);
            addStaff_btn.Name = "addStaff_btn";
            addStaff_btn.Size = new Size(220, 49);
            addStaff_btn.TabIndex = 2;
            addStaff_btn.Text = "ADD STAFF";
            addStaff_btn.UseVisualStyleBackColor = true;
            addStaff_btn.Click += addStaff_btn_Click_1;
            // 
            // addMovie_btn
            // 
            addMovie_btn.FlatAppearance.BorderSize = 0;
            addMovie_btn.FlatStyle = FlatStyle.Flat;
            addMovie_btn.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMovie_btn.ForeColor = Color.White;
            addMovie_btn.Image = Properties.Resources.icons8_movie_30;
            addMovie_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addMovie_btn.Location = new Point(12, 358);
            addMovie_btn.Name = "addMovie_btn";
            addMovie_btn.Size = new Size(220, 49);
            addMovie_btn.TabIndex = 3;
            addMovie_btn.Text = "ADD MOVIE";
            addMovie_btn.UseVisualStyleBackColor = true;
            addMovie_btn.Click += addMovie_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Image = Properties.Resources.icons8_logout_rounded_30;
            logout_btn.ImageAlign = ContentAlignment.MiddleLeft;
            logout_btn.Location = new Point(12, 651);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(200, 49);
            logout_btn.TabIndex = 5;
            logout_btn.Text = "LOG OUT";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(133, 19, 33);
            panel1.Controls.Add(logout_btn);
            panel1.Controls.Add(addMovie_btn);
            panel1.Controls.Add(addStaff_btn);
            panel1.Controls.Add(dashboard_btn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 800);
            panel1.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 800);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private AddMovieForm addMovieForm1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button dashboard_btn;
        private Button addStaff_btn;
        private Button addMovie_btn;
        private Button logout_btn;
        private Panel panel1;
        private dashboardForm dashboardForm1;
        private AddStaffsForm addStaffsForm1;
        private AddMovieForm addMovieForm2;
    }
}