namespace Desktop_Applicaion
{
    partial class buyTicketForm
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
            buyTicket_availableSeat = new Label();
            label12 = new Label();
            buyTicket_clear = new Button();
            buyTicket_selectMovie = new Button();
            buyTicket_regularPrice = new Label();
            label9 = new Label();
            buyTicket_genre = new Label();
            label7 = new Label();
            buyTicket_movieName = new Label();
            label5 = new Label();
            buyTicket_movieID = new Label();
            label2 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            buyTicket_clearFields = new Button();
            buyTicket_receiptBtn = new Button();
            buyTicket_buyBtn = new Button();
            label21 = new Label();
            buyTicket_change = new Label();
            buyTicket_amount = new TextBox();
            label19 = new Label();
            buyTicket_totalPrice = new Label();
            label17 = new Label();
            buyTicket_drinks = new ComboBox();
            label15 = new Label();
            buyTicket_foods = new ComboBox();
            label16 = new Label();
            label14 = new Label();
            buyTicket_availableChairs = new ComboBox();
            label13 = new Label();
            buyTicket_seatType = new ComboBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 281);
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
            dataGridView1.Location = new Point(20, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridView1.Size = new Size(572, 204);
            dataGridView1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(22, 23);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 6;
            label4.Text = "Available Movies";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(buyTicket_availableSeat);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(buyTicket_clear);
            panel2.Controls.Add(buyTicket_selectMovie);
            panel2.Controls.Add(buyTicket_regularPrice);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(buyTicket_genre);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(buyTicket_movieName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(buyTicket_movieID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(20, 327);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 286);
            panel2.TabIndex = 1;
            // 
            // buyTicket_availableSeat
            // 
            buyTicket_availableSeat.AutoSize = true;
            buyTicket_availableSeat.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_availableSeat.ForeColor = Color.Black;
            buyTicket_availableSeat.Location = new Point(330, 166);
            buyTicket_availableSeat.Name = "buyTicket_availableSeat";
            buyTicket_availableSeat.Size = new Size(40, 22);
            buyTicket_availableSeat.TabIndex = 26;
            buyTicket_availableSeat.Text = "------";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(228, 166);
            label12.Name = "label12";
            label12.Size = new Size(105, 22);
            label12.TabIndex = 25;
            label12.Text = "Available Seat:";
            // 
            // buyTicket_clear
            // 
            buyTicket_clear.BackColor = Color.FromArgb(133, 19, 33);
            buyTicket_clear.FlatAppearance.BorderSize = 0;
            buyTicket_clear.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            buyTicket_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            buyTicket_clear.FlatStyle = FlatStyle.Flat;
            buyTicket_clear.Font = new Font("Arial Rounded MT Bold", 10.2F);
            buyTicket_clear.ForeColor = Color.White;
            buyTicket_clear.Location = new Point(435, 221);
            buyTicket_clear.Name = "buyTicket_clear";
            buyTicket_clear.Size = new Size(157, 48);
            buyTicket_clear.TabIndex = 24;
            buyTicket_clear.Text = "CLEAR";
            buyTicket_clear.UseVisualStyleBackColor = false;
            // 
            // buyTicket_selectMovie
            // 
            buyTicket_selectMovie.BackColor = Color.FromArgb(133, 19, 33);
            buyTicket_selectMovie.FlatAppearance.BorderSize = 0;
            buyTicket_selectMovie.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            buyTicket_selectMovie.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            buyTicket_selectMovie.FlatStyle = FlatStyle.Flat;
            buyTicket_selectMovie.Font = new Font("Arial Rounded MT Bold", 10.2F);
            buyTicket_selectMovie.ForeColor = Color.White;
            buyTicket_selectMovie.Location = new Point(233, 221);
            buyTicket_selectMovie.Name = "buyTicket_selectMovie";
            buyTicket_selectMovie.Size = new Size(164, 48);
            buyTicket_selectMovie.TabIndex = 23;
            buyTicket_selectMovie.Text = "SELECT MOVIE";
            buyTicket_selectMovie.UseVisualStyleBackColor = false;
            // 
            // buyTicket_regularPrice
            // 
            buyTicket_regularPrice.AutoSize = true;
            buyTicket_regularPrice.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_regularPrice.ForeColor = Color.Black;
            buyTicket_regularPrice.Location = new Point(325, 135);
            buyTicket_regularPrice.Name = "buyTicket_regularPrice";
            buyTicket_regularPrice.Size = new Size(40, 22);
            buyTicket_regularPrice.TabIndex = 18;
            buyTicket_regularPrice.Text = "------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(228, 135);
            label9.Name = "label9";
            label9.Size = new Size(102, 22);
            label9.TabIndex = 17;
            label9.Text = "Regular Price:";
            // 
            // buyTicket_genre
            // 
            buyTicket_genre.AutoSize = true;
            buyTicket_genre.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_genre.ForeColor = Color.Black;
            buyTicket_genre.Location = new Point(325, 98);
            buyTicket_genre.Name = "buyTicket_genre";
            buyTicket_genre.Size = new Size(40, 22);
            buyTicket_genre.TabIndex = 16;
            buyTicket_genre.Text = "------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(276, 98);
            label7.Name = "label7";
            label7.Size = new Size(54, 22);
            label7.TabIndex = 15;
            label7.Text = "Genre:";
            // 
            // buyTicket_movieName
            // 
            buyTicket_movieName.AutoSize = true;
            buyTicket_movieName.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_movieName.ForeColor = Color.Black;
            buyTicket_movieName.Location = new Point(325, 63);
            buyTicket_movieName.Name = "buyTicket_movieName";
            buyTicket_movieName.Size = new Size(40, 22);
            buyTicket_movieName.TabIndex = 14;
            buyTicket_movieName.Text = "------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(233, 63);
            label5.Name = "label5";
            label5.Size = new Size(97, 22);
            label5.TabIndex = 13;
            label5.Text = "Movie Name:";
            // 
            // buyTicket_movieID
            // 
            buyTicket_movieID.AutoSize = true;
            buyTicket_movieID.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_movieID.ForeColor = Color.Black;
            buyTicket_movieID.Location = new Point(325, 26);
            buyTicket_movieID.Name = "buyTicket_movieID";
            buyTicket_movieID.Size = new Size(40, 22);
            buyTicket_movieID.TabIndex = 12;
            buyTicket_movieID.Text = "------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(259, 26);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 11;
            label2.Text = "Movie ID:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(20, 28);
            panel4.Name = "panel4";
            panel4.Size = new Size(171, 207);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 207);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(buyTicket_clearFields);
            panel3.Controls.Add(buyTicket_receiptBtn);
            panel3.Controls.Add(buyTicket_buyBtn);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(buyTicket_change);
            panel3.Controls.Add(buyTicket_amount);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(buyTicket_totalPrice);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(buyTicket_drinks);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(buyTicket_foods);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(buyTicket_availableChairs);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(buyTicket_seatType);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(651, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(341, 593);
            panel3.TabIndex = 2;
            // 
            // buyTicket_clearFields
            // 
            buyTicket_clearFields.BackColor = Color.FromArgb(133, 19, 33);
            buyTicket_clearFields.FlatAppearance.BorderSize = 0;
            buyTicket_clearFields.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            buyTicket_clearFields.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            buyTicket_clearFields.FlatStyle = FlatStyle.Flat;
            buyTicket_clearFields.Font = new Font("Arial Rounded MT Bold", 10.2F);
            buyTicket_clearFields.ForeColor = Color.White;
            buyTicket_clearFields.Location = new Point(24, 528);
            buyTicket_clearFields.Name = "buyTicket_clearFields";
            buyTicket_clearFields.Size = new Size(292, 48);
            buyTicket_clearFields.TabIndex = 29;
            buyTicket_clearFields.Text = "CLEAR";
            buyTicket_clearFields.UseVisualStyleBackColor = false;
            // 
            // buyTicket_receiptBtn
            // 
            buyTicket_receiptBtn.BackColor = Color.FromArgb(133, 19, 33);
            buyTicket_receiptBtn.FlatAppearance.BorderSize = 0;
            buyTicket_receiptBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            buyTicket_receiptBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            buyTicket_receiptBtn.FlatStyle = FlatStyle.Flat;
            buyTicket_receiptBtn.Font = new Font("Arial Rounded MT Bold", 10.2F);
            buyTicket_receiptBtn.ForeColor = Color.White;
            buyTicket_receiptBtn.Location = new Point(24, 463);
            buyTicket_receiptBtn.Name = "buyTicket_receiptBtn";
            buyTicket_receiptBtn.Size = new Size(292, 46);
            buyTicket_receiptBtn.TabIndex = 28;
            buyTicket_receiptBtn.Text = "RECEIPT";
            buyTicket_receiptBtn.UseVisualStyleBackColor = false;
            // 
            // buyTicket_buyBtn
            // 
            buyTicket_buyBtn.BackColor = Color.FromArgb(133, 19, 33);
            buyTicket_buyBtn.FlatAppearance.BorderSize = 0;
            buyTicket_buyBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(213, 10, 56);
            buyTicket_buyBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            buyTicket_buyBtn.FlatStyle = FlatStyle.Flat;
            buyTicket_buyBtn.Font = new Font("Arial Rounded MT Bold", 10.2F);
            buyTicket_buyBtn.ForeColor = Color.White;
            buyTicket_buyBtn.Location = new Point(24, 397);
            buyTicket_buyBtn.Name = "buyTicket_buyBtn";
            buyTicket_buyBtn.Size = new Size(292, 44);
            buyTicket_buyBtn.TabIndex = 27;
            buyTicket_buyBtn.Text = "BUY";
            buyTicket_buyBtn.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(75, 344);
            label21.Name = "label21";
            label21.Size = new Size(65, 22);
            label21.TabIndex = 26;
            label21.Text = "Change:";
            // 
            // buyTicket_change
            // 
            buyTicket_change.AutoSize = true;
            buyTicket_change.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_change.ForeColor = Color.Black;
            buyTicket_change.Location = new Point(146, 344);
            buyTicket_change.Name = "buyTicket_change";
            buyTicket_change.Size = new Size(60, 22);
            buyTicket_change.TabIndex = 25;
            buyTicket_change.Text = "Rs.0.00";
            // 
            // buyTicket_amount
            // 
            buyTicket_amount.BorderStyle = BorderStyle.FixedSingle;
            buyTicket_amount.Location = new Point(145, 307);
            buyTicket_amount.Name = "buyTicket_amount";
            buyTicket_amount.Size = new Size(171, 27);
            buyTicket_amount.TabIndex = 24;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(75, 307);
            label19.Name = "label19";
            label19.Size = new Size(64, 22);
            label19.TabIndex = 23;
            label19.Text = "Amount:";
            // 
            // buyTicket_totalPrice
            // 
            buyTicket_totalPrice.AutoSize = true;
            buyTicket_totalPrice.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_totalPrice.ForeColor = Color.Black;
            buyTicket_totalPrice.Location = new Point(145, 267);
            buyTicket_totalPrice.Name = "buyTicket_totalPrice";
            buyTicket_totalPrice.Size = new Size(70, 20);
            buyTicket_totalPrice.TabIndex = 22;
            buyTicket_totalPrice.Text = "Rs.0.00";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(36, 267);
            label17.Name = "label17";
            label17.Size = new Size(103, 20);
            label17.TabIndex = 21;
            label17.Text = "Total Price:";
            // 
            // buyTicket_drinks
            // 
            buyTicket_drinks.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_drinks.FormattingEnabled = true;
            buyTicket_drinks.Items.AddRange(new object[] { "Orange Juice", "Soft Drink" });
            buyTicket_drinks.Location = new Point(132, 222);
            buyTicket_drinks.Name = "buyTicket_drinks";
            buyTicket_drinks.Size = new Size(184, 26);
            buyTicket_drinks.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(75, 222);
            label15.Name = "label15";
            label15.Size = new Size(51, 22);
            label15.TabIndex = 19;
            label15.Text = "Drinks";
            // 
            // buyTicket_foods
            // 
            buyTicket_foods.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_foods.FormattingEnabled = true;
            buyTicket_foods.Items.AddRange(new object[] { "Popcorn", "Fries" });
            buyTicket_foods.Location = new Point(132, 184);
            buyTicket_foods.Name = "buyTicket_foods";
            buyTicket_foods.Size = new Size(184, 26);
            buyTicket_foods.TabIndex = 18;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(75, 184);
            label16.Name = "label16";
            label16.Size = new Size(50, 22);
            label16.TabIndex = 17;
            label16.Text = "Foods";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(24, 144);
            label14.Name = "label14";
            label14.Size = new Size(140, 20);
            label14.TabIndex = 16;
            label14.Text = "Available Foods";
            // 
            // buyTicket_availableChairs
            // 
            buyTicket_availableChairs.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_availableChairs.FormattingEnabled = true;
            buyTicket_availableChairs.Items.AddRange(new object[] { "1st Class Seat", "2nd Class Seat", "Normal Seat" });
            buyTicket_availableChairs.Location = new Point(132, 81);
            buyTicket_availableChairs.Name = "buyTicket_availableChairs";
            buyTicket_availableChairs.Size = new Size(184, 26);
            buyTicket_availableChairs.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(12, 81);
            label13.Name = "label13";
            label13.Size = new Size(114, 22);
            label13.TabIndex = 14;
            label13.Text = "Available Chairs";
            // 
            // buyTicket_seatType
            // 
            buyTicket_seatType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_seatType.FormattingEnabled = true;
            buyTicket_seatType.Items.AddRange(new object[] { "1st Class Seat", "2nd Class Seat", "Normal Seat" });
            buyTicket_seatType.Location = new Point(132, 37);
            buyTicket_seatType.Name = "buyTicket_seatType";
            buyTicket_seatType.Size = new Size(184, 26);
            buyTicket_seatType.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(51, 41);
            label10.Name = "label10";
            label10.Size = new Size(75, 22);
            label10.TabIndex = 12;
            label10.Text = "Seat Type";
            // 
            // buyTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "buyTicketForm";
            Size = new Size(1013, 635);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label buyTicket_genre;
        private Label label7;
        private Label buyTicket_movieName;
        private Label label5;
        private Label buyTicket_movieID;
        private Label label2;
        private Label buyTicket_regularPrice;
        private Label label9;
        private Button buyTicket_clear;
        private Button buyTicket_selectMovie;
        private ComboBox buyTicket_seatType;
        private Label label10;
        private Label buyTicket_availableSeat;
        private Label label12;
        private Label label14;
        private ComboBox buyTicket_availableChairs;
        private Label label13;
        private Label label19;
        private Label buyTicket_totalPrice;
        private Label label17;
        private ComboBox buyTicket_drinks;
        private Label label15;
        private ComboBox buyTicket_foods;
        private Label label16;
        private Button buyTicket_clearFields;
        private Button buyTicket_receiptBtn;
        private Button buyTicket_buyBtn;
        private Label label21;
        private Label buyTicket_change;
        private TextBox buyTicket_amount;
    }
}
