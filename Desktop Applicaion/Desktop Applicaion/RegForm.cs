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
    public partial class RegForm : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\PAVANI EDIRISINGHE\Documents\movie.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (reg_username.Text == "" || reg_password.Text == "" || reg_cPassword.Text == "")
            {
                MessageBox.Show("Please filll all blank fields", "Error Messeage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reg_password.Text != reg_cPassword.Text)
            {
                MessageBox.Show("Password does not match", "Error Messeage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reg_password.Text.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string checkUsername = "SELECT * FROM users WHERE username = @usern";
                    using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(reg_username.Text.Substring(0, 1).ToUpper() + reg_username.Text.Substring(1)
                                + " is taken already", "Erro Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username,password,role,status,date_reg) " +
                                "VALUES(@usern,@pass,@role,@status,@date)";

                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", reg_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Staff");
                                cmd.Parameters.AddWithValue("@status", "Active");
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();


                                MessageBox.Show("Registered Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 loginForm = new Form1();
                                loginForm.Show();
                                this.Hide();
                            }
                        }
                    }

                }
            }
        }

        private void reg_showPass_CheckedChanged(object sender, EventArgs e)
        {
            reg_password.PasswordChar = reg_showPass.Checked ? '\0' : '*';
            reg_cPassword.PasswordChar = reg_showPass.Checked ? '\0' : '*';
        }

        private void reg_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reg_signInbtn_Click(object sender, EventArgs e)
        {
            Form loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }
    }
}
