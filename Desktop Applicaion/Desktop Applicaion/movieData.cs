﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Desktop_Applicaion
{
    class movieData
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\PAVANI EDIRISINGHE\Documents\movie.mdf"";Integrated Security=True;Connect Timeout=30";

        public int ID { get; set; }//0
        public string MovieID {  get; set; }//1
        public string MovieName { get; set; }//2
        public string Genre {  get; set; }//3
        public string Price { get; set; }//4
        public string Capacity {  get; set; }//5

        public string ShowTime { get; set; }//6
        public string Status { get; set; }//7
        public string Image {  get; set; }//8
        public string Date { get; set; }//9

        public List<movieData> movieListData()
        {
            List<movieData> listData = new List<movieData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM movies WHERE delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.ID = Convert.ToInt32(reader["id"]);
                        mData.MovieID = reader["movie_id"].ToString();
                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Capacity = reader["capacity"].ToString();
                        mData.ShowTime = reader["show_time"].ToString();
                        mData.Status = reader["status"].ToString();
                        mData.Image = reader["movie_image"].ToString();
                        mData.Date = reader["created_at"].ToString();

                        listData.Add(mData);
                    }
                }
            }

            return listData;

        }

        public List<movieData> movieAvailableListData()
        {
            List<movieData> listData = new List<movieData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM movies WHERE status = 'Available' AND delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.ID = Convert.ToInt32(reader["id"]);
                        mData.MovieID = reader["movie_id"].ToString();
                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Capacity = reader["capacity"].ToString();
                        mData.ShowTime = reader["show_time"].ToString();
                        mData.Status = reader["status"].ToString();
                        mData.Image = reader["movie_image"].ToString();
                        mData.Date = reader["created_at"].ToString();

                        listData.Add(mData);
                    }
                }
            }

            return listData;

        }

    }
}
