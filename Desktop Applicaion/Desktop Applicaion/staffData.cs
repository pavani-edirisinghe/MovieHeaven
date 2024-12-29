using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Desktop_Applicaion
{
     class staffData
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\PAVANI EDIRISINGHE\Documents\movie.mdf"";Integrated Security=True;Connect Timeout=30";

        public int Id { get; set; } //0
        public string Username { get; set; } //1
        public string Password { get; set; } //2
        public string Role { get; set; } //3
        public string Status { get; set; } //4

        public List<staffData> staffDatsListData()
        {
            List<staffData> listData = new List<staffData>();

            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectdata = "SELECT * FROM users WHERE role = 'Staff' AND status != 'Deleted'";

                using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        staffData sData = new staffData();

                        sData.Id = (int)reader[0];
                        sData.Username = reader[1].ToString();
                        sData.Password = reader[2].ToString();
                        sData.Role = reader[3].ToString();
                        sData.Status = reader[4].ToString();

                        listData.Add(sData);
                    }
                }
            }

            return listData;
        }

    }
}
