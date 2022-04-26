using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAPlayer
{
    public class Database
    {
        private string connetionString;

        //    public string ConnectionString
        //    {
        //        //get { }
        //        //set { ConnectionString = value; }
        //    }

        //}

        //public void Connect(string connectionString)
        //{
        //    SqlConnection cnn;
        //    connectionString = @"";
        //    cnn = new SqlConnection(connectionString);
        //    cnn.Open();
        //}

        //private void PushToBase(string PCName, double elapsedTime, DateTime date)
        //{
        //    String st = "INSERT INTO Listened Time(PCName, Elapsed Time, Date) values (@PCName, @elapsedTime, @date)";
        //    //SqlCommand cmd = new SqlCommand(st, cnn);
        //    //cmd.Parameters.AddWithValue("@PCName", PCName);
        //    //cmd.Parameters.AddWithValue("@elapsed Time", elapsedTime);
        //    //cmd.Parameters.AddWithValue("@date", date);
        //    //cmd.ExecuteNonQuery();
        //}
    }
}

