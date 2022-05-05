using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAPlayer
{
    internal class Database
    {
        public string connetionString = @"data source=79.100.222.111;initial catalog=WMPlayer;user id=SA;password=Devos#!3@";

        internal SqlConnection Connect()
        {
            try
            {
                SqlConnection cnn;
                cnn = new SqlConnection(this.connetionString);
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

            internal void PushToBaseElapsedTime(string PCName, double elapsedTime, string date, SqlConnection cnn)
            {
                elapsedTime = Math.Round(elapsedTime, 2);
                String st = "INSERT INTO TimeWatched(PCName, ElapsedTime, CurrentDate) values (@PCName, @elapsedTime, @date)";
                SqlCommand cmd = new SqlCommand(st, cnn);
                cmd.Parameters.AddWithValue("@PCName", PCName);
                cmd.Parameters.AddWithValue("@elapsedTime", elapsedTime);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
            }
        }
    }


