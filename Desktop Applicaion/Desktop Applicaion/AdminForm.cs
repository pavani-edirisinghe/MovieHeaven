using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Applicaion
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?", "Confirmation Message"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }


        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm2.Show();
            addStaffsForm1.Hide();
            addMovieForm3.Hide();

            dashboardForm dForm = dashboardForm2 as dashboardForm;

            if (dForm != null)
            {
                dForm.refreshData();
            }

        }

        private void addStaff_btn_Click_1(object sender, EventArgs e)
        {
            dashboardForm2.Hide();
            addStaffsForm1.Show();
            addMovieForm3.Hide();

            AddStaffsForm asForm = addStaffsForm1 as AddStaffsForm;

            if (asForm != null)
            {
                asForm.refreshData();
            }
        }

        private void addMovie_btn_Click(object sender, EventArgs e)
        {
            dashboardForm2.Hide();
            addStaffsForm1.Hide();
            addMovieForm3.Show();

            AddMovieForm amForm = addMovieForm3 as AddMovieForm;

            if (amForm != null)
            {
                amForm.refreshData();
            }
        }

        private void addMovieForm2_Load(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
