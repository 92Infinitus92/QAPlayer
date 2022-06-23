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
        public string connetionString = @Environment.GetEnvironmentVariable("connectionString");

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

            internal void PushToBaseElapsedTime(string PCName, double elapsedTime, DateTime date, SqlConnection cnn)
            {
                elapsedTime = Math.Round(elapsedTime, 2);
                String st = "INSERT INTO TimeListened(Username, ElapsedTime, CurrentDate) values (@PCName, @elapsedTime, @date)";
                SqlCommand cmd = new SqlCommand(st, cnn);
                cmd.Parameters.AddWithValue("@PCName", PCName);
                cmd.Parameters.AddWithValue("@elapsedTime", elapsedTime);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
                cnn.Close();
                cnn.Dispose();
            }
        }
    }


