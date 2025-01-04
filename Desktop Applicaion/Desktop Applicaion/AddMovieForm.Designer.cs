namespace Desktop_Applicaion
{
    partial class AddMovieForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            panel2 = new Panel();
            addMovie_status = new ComboBox();
            label7 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            addMovie_clearBtn = new Button();
            addMovie_deleteBtn = new Button();
            addMovie_updateBtn = new Button();
            addMovie_addBtn = new Button();
            addMovie_capacity = new TextBox();
            label6 = new Label();
            addMovie_importBtn = new Button();
            addMovie_price = new TextBox();
            label5 = new Label();
            addMovie_genre = new ComboBox();
            label3 = new Label();
            addMovie_movieName = new TextBox();
            label1 = new Label();
            addMovie_movieID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(25, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 272);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(133, 19, 33);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(213, 10, 56);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(133, 19, 33);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(213, 10, 56);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(33, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridView1.Size = new Size(1058, 192);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(34, 21);
            label4.Name = "label4";
            label4.Size = new Size(124, 27);
            label4.TabIndex = 5;
            label4.Text = "All Movies";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(addMovie_status);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(addMovie_clearBtn);
            panel2.Controls.Add(addMovie_deleteBtn);
            panel2.Controls.Add(addMovie_updateBtn);
            panel2.Controls.Add(addMovie_addBtn);
            panel2.Controls.Add(addMovie_capacity);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addMovie_importBtn);
            panel2.Controls.Add(addMovie_price);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addMovie_genre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addMovie_movieName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(addMovie_movieID);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(25, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(1117, 398);
            panel2.TabIndex = 1;
            // 
            // addMovie_status
            // 
            addMovie_status.FormattingEnabled = true;
            addMovie_status.Items.AddRange(new object[] { "Available", "Unavailable", "Deleted" });
            addMovie_status.Location = new Point(576, 163);
            addMovie_status.Name = "addMovie_status";
            addMovie_status.Size = new Size(208, 28);
            addMovie_status.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(503, 163);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 27;
            label7.Text = "Status :";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(906, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 150);
            panel3.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // addMovie_clearBtn
            // 
            addMovie_clearBtn.BackColor = Color.FromArgb(133, 19, 33);
            addMovie_clearBtn.FlatAppearance.BorderSize = 0;
            addMovie_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            addMovie_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            addMovie_clearBtn.FlatStyle = FlatStyle.Flat;
            addMovie_clearBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMovie_clearBtn.ForeColor = Color.White;
            addMovie_clearBtn.Location = new Point(704, 272);
            addMovie_clearBtn.Name = "addMovie_clearBtn";
            addMovie_clearBtn.Size = new Size(120, 47);
            addMovie_clearBtn.TabIndex = 25;
            addMovie_clearBtn.Text = "CLEAR";
            addMovie_clearBtn.UseVisualStyleBackColor = false;
            addMovie_clearBtn.Click += addMovie_clearBtn_Click;
            // 
            // addMovie_deleteBtn
            // 
            addMovie_deleteBtn.BackColor = Color.FromArgb(133, 19, 33);
            addMovie_deleteBtn.FlatAppearance.BorderSize = 0;
            addMovie_deleteBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            addMovie_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            addMovie_deleteBtn.FlatStyle = FlatStyle.Flat;
            addMovie_deleteBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMovie_deleteBtn.ForeColor = Color.White;
            addMovie_deleteBtn.Location = new Point(514, 273);
            addMovie_deleteBtn.Name = "addMovie_deleteBtn";
            addMovie_deleteBtn.Size = new Size(125, 46);
            addMovie_deleteBtn.TabIndex = 24;
            addMovie_deleteBtn.Text = "DELETE";
            addMovie_deleteBtn.UseVisualStyleBackColor = false;
            addMovie_deleteBtn.Click += button5_Click;
            // 
            // addMovie_updateBtn
            // 
            addMovie_updateBtn.BackColor = Color.FromArgb(133, 19, 33);
            addMovie_updateBtn.FlatAppearance.BorderSize = 0;
            addMovie_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            addMovie_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            addMovie_updateBtn.FlatStyle = FlatStyle.Flat;
            addMovie_updateBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMovie_updateBtn.ForeColor = Color.White;
            addMovie_updateBtn.Location = new Point(323, 273);
            addMovie_updateBtn.Name = "addMovie_updateBtn";
            addMovie_updateBtn.Size = new Size(120, 47);
            addMovie_updateBtn.TabIndex = 23;
            addMovie_updateBtn.Text = "UPDATE";
            addMovie_updateBtn.UseVisualStyleBackColor = false;
            addMovie_updateBtn.Click += addMovie_updateBtn_Click;
            // 
            // addMovie_addBtn
            // 
            addMovie_addBtn.BackColor = Color.FromArgb(133, 19, 33);
            addMovie_addBtn.FlatAppearance.BorderSize = 0;
            addMovie_addBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            addMovie_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            addMovie_addBtn.FlatStyle = FlatStyle.Flat;
            addMovie_addBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMovie_addBtn.ForeColor = Color.White;
            addMovie_addBtn.Location = new Point(132, 274);
            addMovie_addBtn.Name = "addMovie_addBtn";
            addMovie_addBtn.Size = new Size(120, 47);
            addMovie_addBtn.TabIndex = 22;
            addMovie_addBtn.Text = "ADD";
            addMovie_addBtn.UseVisualStyleBackColor = false;
            addMovie_addBtn.Click += addMovie_addBtn_Click;
            // 
            // addMovie_capacity
            // 
            addMovie_capacity.BorderStyle = BorderStyle.FixedSingle;
            addMovie_capacity.Location = new Point(576, 98);
            addMovie_capacity.Name = "addMovie_capacity";
            addMovie_capacity.Size = new Size(208, 27);
            addMovie_capacity.TabIndex = 21;
            addMovie_capacity.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(486, 101);
            label6.Name = "label6";
            label6.Size = new Size(84, 24);
            label6.TabIndex = 20;
            label6.Text = "Capacity :";
            // 
            // addMovie_importBtn
            // 
            addMovie_importBtn.BackColor = Color.FromArgb(133, 19, 33);
            addMovie_importBtn.FlatAppearance.BorderSize = 0;
            addMovie_importBtn.FlatStyle = FlatStyle.Flat;
            addMovie_importBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMovie_importBtn.ForeColor = Color.White;
            addMovie_importBtn.Location = new Point(906, 208);
            addMovie_importBtn.Name = "addMovie_importBtn";
            addMovie_importBtn.Size = new Size(150, 42);
            addMovie_importBtn.TabIndex = 19;
            addMovie_importBtn.Text = "IMPORT";
            addMovie_importBtn.UseVisualStyleBackColor = false;
            addMovie_importBtn.Click += addMovie_importBtn_Click;
            // 
            // addMovie_price
            // 
            addMovie_price.BorderStyle = BorderStyle.FixedSingle;
            addMovie_price.Location = new Point(577, 41);
            addMovie_price.Name = "addMovie_price";
            addMovie_price.Size = new Size(207, 27);
            addMovie_price.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(514, 41);
            label5.Name = "label5";
            label5.Size = new Size(56, 24);
            label5.TabIndex = 16;
            label5.Text = "Price :";
            // 
            // addMovie_genre
            // 
            addMovie_genre.FormattingEnabled = true;
            addMovie_genre.Items.AddRange(new object[] { "Educational", "Comedy", "Drama", "Action", "Horror" });
            addMovie_genre.Location = new Point(164, 163);
            addMovie_genre.Name = "addMovie_genre";
            addMovie_genre.Size = new Size(207, 28);
            addMovie_genre.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(93, 163);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 14;
            label3.Text = "Genre :";
            // 
            // addMovie_movieName
            // 
            addMovie_movieName.BorderStyle = BorderStyle.FixedSingle;
            addMovie_movieName.Location = new Point(165, 97);
            addMovie_movieName.Name = "addMovie_movieName";
            addMovie_movieName.Size = new Size(206, 27);
            addMovie_movieName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(43, 101);
            label1.Name = "label1";
            label1.Size = new Size(115, 24);
            label1.TabIndex = 12;
            label1.Text = "Movie Name :";
            // 
            // addMovie_movieID
            // 
            addMovie_movieID.BorderStyle = BorderStyle.FixedSingle;
            addMovie_movieID.Location = new Point(165, 41);
            addMovie_movieID.Name = "addMovie_movieID";
            addMovie_movieID.Size = new Size(206, 27);
            addMovie_movieID.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(76, 41);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 10;
            label2.Text = "Movie ID :";
            // 
            // AddMovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddMovieForm";
            Size = new Size(1170, 737);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox addMovie_movieName;
        private Label label1;
        private TextBox addMovie_movieID;
        private Label label2;
        private TextBox addMovie_price;
        private Label label5;
        private ComboBox addMovie_genre;
        private Label label3;
        private Button addMovie_importBtn;
        private PictureBox pictureBox1;
        private TextBox addMovie_capacity;
        private Label label6;
        private Button addMovie_clearBtn;
        private Button addMovie_deleteBtn;
        private Button addMovie_updateBtn;
        private Button addMovie_addBtn;
        private Panel panel3;
        private ComboBox addMovie_status;
        private Label label7;
    }
}
