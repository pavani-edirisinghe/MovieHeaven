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
        }

        public void displayAvailableMovies()
        {
            movieData mData = new movieData();

            List<movieData> listData = mData.movieAvailableListData();
        }
    }
}
