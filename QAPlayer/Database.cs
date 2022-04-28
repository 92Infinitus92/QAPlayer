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
        public string connetionString = @"data source=192.168.180.131;initial catalog=WMPlayer;user id=sa;password=Devos#!3@";



        internal SqlConnection Connect()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(this.connetionString);
            cnn.Open();
            return cnn;
        }

        internal void PushToBase(string PCName, double elapsedTime, string date, SqlConnection cnn)
        {
            try
            {
                elapsedTime = Math.Round(elapsedTime, 2);
                String st = "INSERT INTO TimeWatched(PCName, ElapsedTime, CurrentDate) values (@PCName, @elapsedTime, @date)";
                SqlCommand cmd = new SqlCommand(st, cnn);
                cmd.Parameters.AddWithValue("@PCName", PCName);
                cmd.Parameters.AddWithValue("@elapsedTime", elapsedTime);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
            }
            catch (ArithmeticException)
            {
                throw;
            }
        }
    }
}


