namespace Desktop_Applicaion
{
    partial class AddStaffsForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            panel1 = new Panel();
            addStaff_clearBtn = new Button();
            addStaff_deletBtn = new Button();
            addStaff_updateBtn = new Button();
            button1 = new Button();
            addStaff_status = new ComboBox();
            label5 = new Label();
            addStaff_password = new TextBox();
            label3 = new Label();
            addStaff_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(397, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 681);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(133, 19, 33);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(213, 10, 56);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(133, 19, 33);
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(213, 10, 56);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(26, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridView1.Size = new Size(693, 566);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(40, 27);
            label4.Name = "label4";
            label4.Size = new Size(100, 27);
            label4.TabIndex = 4;
            label4.Text = "All Staff";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addStaff_clearBtn);
            panel1.Controls.Add(addStaff_deletBtn);
            panel1.Controls.Add(addStaff_updateBtn);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(addStaff_status);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(addStaff_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addStaff_username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 681);
            panel1.TabIndex = 2;
            // 
            // addStaff_clearBtn
            // 
            addStaff_clearBtn.BackColor = Color.FromArgb(133, 19, 33);
            addStaff_clearBtn.FlatAppearance.BorderSize = 0;
            addStaff_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            addStaff_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            addStaff_clearBtn.FlatStyle = FlatStyle.Flat;
            addStaff_clearBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStaff_clearBtn.ForeColor = Color.White;
            addStaff_clearBtn.Location = new Point(188, 479);
            addStaff_clearBtn.Name = "addStaff_clearBtn";
            addStaff_clearBtn.Size = new Size(107, 44);
            addStaff_clearBtn.TabIndex = 18;
            addStaff_clearBtn.Text = "CLEAR";
            addStaff_clearBtn.UseVisualStyleBackColor = false;
            addStaff_clearBtn.Click += addStaff_clearBtn_Click;
            // 
            // addStaff_deletBtn
            // 
            addStaff_deletBtn.BackColor = Color.FromArgb(133, 19, 33);
            addStaff_deletBtn.FlatAppearance.BorderSize = 0;
            addStaff_deletBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            addStaff_deletBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            addStaff_deletBtn.FlatStyle = FlatStyle.Flat;
            addStaff_deletBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStaff_deletBtn.ForeColor = Color.White;
            addStaff_deletBtn.Location = new Point(28, 479);
            addStaff_deletBtn.Name = "addStaff_deletBtn";
            addStaff_deletBtn.Size = new Size(112, 44);
            addStaff_deletBtn.TabIndex = 17;
            addStaff_deletBtn.Text = "DELETE";
            addStaff_deletBtn.UseVisualStyleBackColor = false;
            addStaff_deletBtn.Click += addStaff_deletBtn_Click;
            // 
            // addStaff_updateBtn
            // 
            addStaff_updateBtn.BackColor = Color.FromArgb(133, 19, 33);
            addStaff_updateBtn.FlatAppearance.BorderSize = 0;
            addStaff_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            addStaff_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            addStaff_updateBtn.FlatStyle = FlatStyle.Flat;
            addStaff_updateBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStaff_updateBtn.ForeColor = Color.White;
            addStaff_updateBtn.Location = new Point(188, 385);
            addStaff_updateBtn.Name = "addStaff_updateBtn";
            addStaff_updateBtn.Size = new Size(107, 46);
            addStaff_updateBtn.TabIndex = 16;
            addStaff_updateBtn.Text = "UPDATE";
            addStaff_updateBtn.UseVisualStyleBackColor = false;
            addStaff_updateBtn.Click += addStaff_updateBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(133, 19, 33);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(28, 385);
            button1.Name = "button1";
            button1.Size = new Size(112, 46);
            button1.TabIndex = 15;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addStaff_status
            // 
            addStaff_status.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStaff_status.FormattingEnabled = true;
            addStaff_status.Items.AddRange(new object[] { "Active", "Inactive" });
            addStaff_status.Location = new Point(39, 305);
            addStaff_status.Name = "addStaff_status";
            addStaff_status.Size = new Size(253, 28);
            addStaff_status.TabIndex = 14;
            addStaff_status.SelectedIndexChanged += addStaff_status_SelectedIndexChanged;
            addStaff_status.SelectionChangeCommitted += addStaff_status_SelectedIndexChanged;
            addStaff_status.SelectedValueChanged += addStaff_status_SelectedIndexChanged;
            addStaff_status.VisibleChanged += addStaff_status_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(39, 278);
            label5.Name = "label5";
            label5.Size = new Size(57, 24);
            label5.TabIndex = 13;
            label5.Text = "Status";
            // 
            // addStaff_password
            // 
            addStaff_password.BackColor = Color.White;
            addStaff_password.BorderStyle = BorderStyle.FixedSingle;
            addStaff_password.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStaff_password.Location = new Point(39, 233);
            addStaff_password.Name = "addStaff_password";
            addStaff_password.Size = new Size(255, 27);
            addStaff_password.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 206);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // addStaff_username
            // 
            addStaff_username.BackColor = Color.White;
            addStaff_username.BorderStyle = BorderStyle.FixedSingle;
            addStaff_username.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStaff_username.Location = new Point(39, 157);
            addStaff_username.Name = "addStaff_username";
            addStaff_username.Size = new Size(255, 27);
            addStaff_username.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(39, 130);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(39, 47);
            label1.Name = "label1";
            label1.Size = new Size(238, 27);
            label1.TabIndex = 8;
            label1.Text = "Fill Staff Information";
            // 
            // AddStaffsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddStaffsForm";
            Size = new Size(1170, 737);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label4;
        private Panel panel1;
        private Button addStaff_clearBtn;
        private Button addStaff_deletBtn;
        private Button addStaff_updateBtn;
        private Button button1;
        private ComboBox addStaff_status;
        private Label label5;
        private TextBox addStaff_password;
        private Label label3;
        private TextBox addStaff_username;
        private Label label2;
        private Label label1;
    }
}
