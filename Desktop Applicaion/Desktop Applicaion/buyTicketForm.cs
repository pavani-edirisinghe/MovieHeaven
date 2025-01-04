using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Desktop_Applicaion
{
    public partial class buyTicketForm : UserControl
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\PAVANI EDIRISINGHE\Documents\movie.mdf"";Integrated Security=True;Connect Timeout=30";

        public buyTicketForm()
        {
            InitializeComponent();

            displayAvailableMovies();

            displayAvailableSeats();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAvailableMovies();
        }

        public void displayAvailableMovies()
        {
            movieData mData = new movieData();

            List<movieData> listData = mData.movieAvailableListData();

            dataGridView1.DataSource = listData;
        }

        private int id = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                buyTicket_movieID.Text = row.Cells[1].Value.ToString();
                buyTicket_movieName.Text = row.Cells[2].Value.ToString();
                buyTicket_genre.Text = row.Cells[3].Value.ToString();
                buyTicket_regularPrice.Text = row.Cells[4].Value.ToString();

                pictureBox1.ImageLocation = row.Cells[7].Value.ToString();
            }
        }

        string movie_id;

        private void buyTicket_selectMovie_Click(object sender, EventArgs e)
        {
            movie_id = buyTicket_movieID.Text.Trim();
            displayAvailableSeats();
        }

        public void displayAvailableSeats()
        {
            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\PAVANI EDIRISINGHE\Documents\movie.mdf"";Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectAvailableSeat = "SELECT capacity FROM movies WHERE delete_date IS NULL AND status != 'Deleted' AND movie_id = '" + movie_id + "'";
                int seatAvailable = 0;

                using (SqlCommand cmdSelectSeat = new SqlCommand(selectAvailableSeat, connect))
                {
                    SqlDataReader reader = cmdSelectSeat.ExecuteReader();

                    if (reader.Read())
                    {
                        seatAvailable = (int)reader["capacity"];
                    }
                    reader.Close();
                }

                if (seatAvailable > 0)
                {
                    string selectBookSeats = "SELECT seat_number FROM buy_tickets WHERE movie_id= @movie_id";

                    List<int> bookSeat = new List<int>();

                    using (SqlCommand cmd = new SqlCommand(selectBookSeats, connect))
                    {
                        cmd.Parameters.AddWithValue("@movie_id", movie_id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            bookSeat.Add((int)reader["seat_number"]);
                        }
                        reader.Close();

                        List<int> allSeats = Enumerable.Range(1, seatAvailable).ToList();

                        List<int> availableSeats = allSeats.Except(bookSeat).ToList();

                        DataTable table = new DataTable();
                        table.Columns.Add("seat_number", typeof(int));

                        foreach (int seat in availableSeats)
                        {
                            table.Rows.Add(seat);
                        }

                        if (table.Rows.Count > 0)
                        {
                            buyTicket_availableChairs.DataSource = table;
                            buyTicket_availableChairs.DisplayMember = "seat_number";
                            buyTicket_availableChairs.ValueMember = "seat_number";
                        }
                        else
                        {
                            buyTicket_availableChairs.DataSource = null;
                        }
                    }
                }
                else
                {
                    buyTicket_availableChairs.DataSource = null;
                }
            }
        }


        double getTotal = 0;
        private void buyTicket_calculateBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectPrice = "SELECT movie_id, price FROM movies WHERE movie_id = '" + movie_id + "'";

                double getPrice = 0;
                using (SqlCommand cmd = new SqlCommand(selectPrice, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        getPrice = Convert.ToDouble((reader["price"].Equals(null)) ? 0 : reader["price"]);
                    }

                    reader.Close();
                }

                double getFoodPrice = (buyTicket_foods.SelectedIndex == -1) ? 0 : 100;

                double getDrinkPrice = (buyTicket_drinks.SelectedIndex == -1) ? 0 : 150;

                getTotal = (getPrice + getFoodPrice + getDrinkPrice);

                buyTicket_totalPrice.Text = "Rs. " + getTotal.ToString("0.00");
            }
        }


        public void clearSelected()
        {
            id = 0;
            buyTicket_movieID.Text = "";
            buyTicket_movieName.Text = "";
            buyTicket_genre.Text = "";
            buyTicket_regularPrice.Text = "";

            pictureBox1.ImageLocation = null;
        }
        private void buyTicket_clear_Click(object sender, EventArgs e)
        {
            clearSelected();
        }

        private void buyTicket_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void buyTicketForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void buyTicket_amount_Enter(object sender, EventArgs e)
        //{
        //    if (id == 0 && getTotal == 0)
        //    {
        //        MessageBox.Show("Please select movie and foods first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            if (Convert.ToDouble(buyTicket_amount.Text) >= getTotal)
        //            {
        //                getChange = Convert.ToDouble(buyTicket_amount.Text) - getTotal;
        //            }
        //            else
        //            {
        //                getChange = 0;
        //            }

        //            buyTicket_change.Text = getChange.ToString("0.00");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Please enter numbers only", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            buyTicket_amount.Text = "";
        //        }
        //    }
        //}

        double getChange = 0;
        double getAmount = 0;

        //private void buyTicket_amount_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (id == 0 && getTotal == 0)
        //        {
        //            MessageBox.Show("Please select movie and foods first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            try
        //            {
        //                if (Convert.ToDouble(buyTicket_amount.Text) >= getTotal)
        //                {
        //                    getChange = Convert.ToDouble(buyTicket_amount.Text) - getTotal;
        //                    getAmount = Convert.ToDouble(buyTicket_amount.Text);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Error :3 should amount > total", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    getChange = 0;
        //                    getAmount = 0;
        //                }

        //                buyTicket_change.Text = "Rs." + getChange.ToString("0.00");
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Please enter numbers only", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                buyTicket_amount.Text = "";
        //                getAmount = 0;
        //            }
        //        }
        //    }
        //}

        private void buyTicket_amount_Enter(object sender, EventArgs e)
        {
            if (id == 0 && getTotal == 0)
            {
                MessageBox.Show("Please select movie and foods first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Don't show error message on just clicking the textbox
            }
        }

        private void buyTicket_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (id == 0 && getTotal == 0)
                {
                    MessageBox.Show("Please select movie and foods first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double inputAmount;
                    // Use TryParse to handle invalid characters more gracefully
                    if (double.TryParse(buyTicket_amount.Text, out inputAmount))
                    {
                        if (inputAmount >= getTotal)
                        {
                            getChange = inputAmount - getTotal;
                            getAmount = inputAmount;
                            buyTicket_change.Text = "Rs." + getChange.ToString("0.00");
                        }
                        else
                        {
                            MessageBox.Show("Error: Amount should be greater than or equal to the total.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            getChange = 0;
                            getAmount = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter numbers only", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buyTicket_amount.Text = "";
                        getAmount = 0;
                    }
                }
            }
        }


        private void buyTicket_buyBtn_Click(object sender, EventArgs e)
        {
            if (movie_id == null || getTotal == 0)
            {
                MessageBox.Show("Please select movie first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))    
                {
                    connect.Open();

                    string insertData = "INSERT INTO buy_tickets (movie_id, seat_number, price, amount, change, status, created_at) " +
                        "VALUES(@movieID, @seatNum, @price, @amount, @change, @status, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@movieID", movie_id);
                        cmd.Parameters.AddWithValue("@seatNum", buyTicket_availableChairs.Text);
                        cmd.Parameters.AddWithValue("@price", getTotal);
                        cmd.Parameters.AddWithValue("@amount", getAmount);
                        cmd.Parameters.AddWithValue("@change", getChange);
                        cmd.Parameters.AddWithValue("@status", "PAID");

                        DateTime today = DateTime.Now;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Successful! occupied: {buyTicket_availableChairs.Text}"
                            , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        

        
        private void buyTicket_receiptBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private int rowIndex = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = e.MarginBounds.Top;
            int colWidth = 100;
            int rowHeight = 25;
            int tableMargin = 15;

            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10);
            Font footerFont = new Font("Arial", 14, FontStyle.Bold);


            StringFormat centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            // Print Header
            string headerText = "Marcon's Cinema";
            y += tableMargin;
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black,
                new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width, headerFont.GetHeight()), centerFormat);
            y += headerFont.GetHeight() + tableMargin;

            // Print Column Headers
            string[] headers = { "ID", "MovieID", "MovieName", "Genre", "RegPrice", "Capacity", "Status" };
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], boldFont, Brushes.Black, e.MarginBounds.Left + (i * colWidth), y);
            }
            y += boldFont.GetHeight() + rowHeight;

            // Print Table Rows
            while (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                for (int i = 0; i < dataGridView1.Columns.Count - 2; i++) // Adjusted for column count
                {
                    object cellValue = row.Cells[i].Value;
                    string cellText = cellValue != null ? cellValue.ToString() : string.Empty;
                    e.Graphics.DrawString(cellText, regularFont, Brushes.Black, e.MarginBounds.Left + (i * colWidth), y);
                }

                y += regularFont.GetHeight() + rowHeight;
                rowIndex++;

                // Check if more pages are needed
                if (y + regularFont.GetHeight() > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Print Footer
            y = e.MarginBounds.Bottom - 400;
            DateTime today = DateTime.Now;
            string footerText = $"Total Price: Rs. {getTotal.ToString("0.00")}\n" +
                                $"Amount Paid: Rs. {buyTicket_amount.Text}\n" +
                                $"Change: Rs. {buyTicket_change.Text}\n" +
                                today.ToString("dd/MM/yyyy HH:mm:ss");

            e.Graphics.DrawString(footerText, footerFont, Brushes.Black,
                new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width, 100));
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }
        private void buyTicket_clearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        public void clearFields()
        {
            buyTicket_availableChairs.SelectedIndex = -1;
            buyTicket_foods.SelectedIndex = -1;
            buyTicket_drinks.SelectedIndex = -1;
            buyTicket_totalPrice.Text = "Rs.0.00";
            buyTicket_amount.Text = "";
            buyTicket_change.Text = "Rs.0.00";
        }
    }
}
