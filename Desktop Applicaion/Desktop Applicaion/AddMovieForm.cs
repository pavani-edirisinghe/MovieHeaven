﻿using System;
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
using System.IO;

namespace Desktop_Applicaion
{

    public partial class AddMovieForm : UserControl
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\PAVANI EDIRISINGHE\Documents\movie.mdf"";Integrated Security=True;Connect Timeout=30";

        public AddMovieForm()
        {
            InitializeComponent();

            displayData();

        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayData();
        }


        public void displayData()
        {
            movieData mData = new movieData();

            List<movieData> listData = mData.movieListData();

            dataGridView1.DataSource = listData;
        }

        private void addMovie_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                string imagePath = "";

                file.Filter = "Image Files (*.jpg; *.png;*.jpeg)|*.jpg;*.png;*.jpeg";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addMovie_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string checkID = "SELECT movie_id FROM movies WHERE movie_id = @movieID";
                    using (SqlCommand cID = new SqlCommand(checkID, connect))
                    {
                        cID.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cID);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show($"Movie ID: " + addMovie_movieID.Text.Trim() + " is already taken",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO movies (movie_id, movie_name, genre, price, capacity, movie_image, show_time, status, created_at) " +
                                "VALUES(@movieID, @movieName, @genre, @price, @capacity, @movieImage, @showTime, @status, @date)";

                            string path = Path.Combine(@"C:\Users\PAVANI EDIRISINGHE\Desktop\Gui Project\MovieHeaven\Desktop Applicaion\Desktop Applicaion\Movie_Directory\",
                                                        addMovie_movieID.Text.Trim() + ".jpg");
                            string directoryPath = Path.GetDirectoryName(path);
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            if (pictureBox1.Image != null)
                            {
                                File.Copy(pictureBox1.ImageLocation, path, true);
                            }
                            else
                            {
                                MessageBox.Show("No image selected for the movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                                cmd.Parameters.AddWithValue("@movieName", addMovie_movieName.Text.Trim());
                                cmd.Parameters.AddWithValue("@genre", addMovie_genre.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@price", addMovie_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@capacity", addMovie_capacity.Text.Trim());
                                cmd.Parameters.AddWithValue("@movieImage", path);
                                cmd.Parameters.AddWithValue("@showTime", addMovie_showTime.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", addMovie_status.SelectedItem.ToString());
                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                displayData();
                                clearfields();

                                MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearfields()
        {
            addMovie_movieID.Text = "";
            addMovie_movieName.Text = "";
            addMovie_genre.SelectedIndex = -1;
            addMovie_price.Text = "";
            addMovie_capacity.Text = "";
            pictureBox1.Image = null;
            addMovie_showTime.SelectedIndex = -1;
            addMovie_status.SelectedIndex = -1;

        }

        private void addMovie_clearBtn_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private int id = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                addMovie_movieID.Text = row.Cells[1].Value.ToString();
                addMovie_movieName.Text = row.Cells[2].Value.ToString();
                addMovie_genre.Text = row.Cells[3].Value.ToString();
                addMovie_price.Text = row.Cells[4].Value.ToString();
                addMovie_capacity.Text = row.Cells[5].Value.ToString();
                addMovie_showTime.Text = row.Cells[6].Value.ToString();
                addMovie_status.Text = row.Cells[7].Value.ToString();

                pictureBox1.ImageLocation = row.Cells[8].Value.ToString();

            }
        }

        private void addMovie_updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update ID: " + addMovie_movieID.Text + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string checkID = "SELECT COUNT(id) FROM movies WHERE movie_id = @movieID AND id != @id";

                        using (SqlCommand cID = new SqlCommand(checkID, connect))
                        {
                            cID.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                            cID.Parameters.AddWithValue("@id", id);

                            int count = (int)cID.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show($"Movie ID: {addMovie_movieID.Text.Trim()} is already taken by another record.",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string updateData = "UPDATE movies SET movie_id = @movieID, movie_name = @movieName, genre = @genre, " +
                    "price = @price, capacity = @capacity, show_time = @showTime, status = @status, update_date = @updateDate " +
                    "WHERE id = @id";


                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                            cmd.Parameters.AddWithValue("@movieName", addMovie_movieName.Text.Trim());
                            cmd.Parameters.AddWithValue("@genre", addMovie_genre.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@price", addMovie_price.Text.Trim());
                            cmd.Parameters.AddWithValue("@capacity", addMovie_capacity.Text.Trim());
                            cmd.Parameters.AddWithValue("@showTime", addMovie_showTime.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@status", addMovie_status.SelectedItem?.ToString() ?? "");

                            DateTime today = DateTime.Now;
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@id", id);

                            cmd.ExecuteNonQuery();
                            displayData();
                        }

                        

                        MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        refreshData();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + addMovie_movieID.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string updateData = "UPDATE movies SET delete_date = @deleteDate, status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@status", "Deleted");
                            cmd.Parameters.AddWithValue("@id", id);

                            cmd.ExecuteNonQuery();

                            displayData();
                            clearfields();

                            MessageBox.Show("Updated successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {

        }

        private void addMovie_showTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
