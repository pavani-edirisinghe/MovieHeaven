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
    public partial class dashboardForm : UserControl
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\PAVANI EDIRISINGHE\Documents\movie.mdf"";Integrated Security=True;Connect Timeout=30";

        public dashboardForm()
        {
            InitializeComponent();
            displayAvailableMovies();
            displayTotalStaffs();
            displayTotalBuys();
            displayTotalIncome();

            displayAMTable();
        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {

        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAvailableMovies();
            displayTotalStaffs();
            displayTotalBuys();
            displayTotalIncome();
            displayAMTable(); 
        }

        public void displayAMTable()
        {
            movieData mData = new movieData();

            List<movieData> listData = mData.movieAvailableListData();

            dataGridView1.DataSource = listData;
        }

        public void displayAvailableMovies()
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as avMovie FROM movies WHERE status = 'Available'";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        if (reader["avMovie"] != DBNull.Value)
                        {
                            decimal totalMovie = Convert.ToDecimal(reader["avMovie"]);

                            dashbord_AM.Text = totalMovie.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalStaffs()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as totalStaff FROM users WHERE role = 'Staff' AND status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalStaff"] != DBNull.Value)
                        {
                            decimal totalStaff = Convert.ToDecimal(reader["totalStaff"]);

                            dashbord_TS.Text = totalStaff.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalBuys()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as totalBuys FROM buy_tickets WHERE status = 'PAID'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalBuys"] != DBNull.Value)
                        {
                            decimal totalBuys = Convert.ToDecimal(reader["totalBuys"]);

                            dashbord_TB.Text = totalBuys.ToString();
                        }
                    }
                }
            }
        }
       
        public void displayTotalIncome()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT SUM(price) as totalIncome FROM buy_tickets WHERE status = 'PAID'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalIncome"] != DBNull.Value)
                        {
                            decimal totalIncome = Convert.ToDecimal(reader["totalIncome"]);

                            dashbord_TI.Text = "Rs." + totalIncome.ToString("0.00");
                        }
                    }
                }
            }
        }
    }
}
