using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Desktop_Applicaion
{
    public partial class Form1 : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\PAVANI EDIRISINGHE\Documents\movie.mdf"";Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegForm regform = new RegForm();
            regform.Show();

            this.Hide();

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text==""|| login_password.Text=="")
            {
                MessageBox.Show("Please fill all blank fields","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

            }
        }
    }
}
