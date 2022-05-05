using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QAPlayer
{
    public partial class Form2 : Form
    {
        public static string username;
        readonly Database db = new Database();
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            var cnn = db.Connect();
            DatabaseCheckUsername(cnn);
        }

        //method which confirms that the username exists in the database and enables the player to be used
        private void DatabaseCheckUsername(SqlConnection cnn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM AgentsQA WHERE PCName = @username", cnn);
                cmd.Parameters.AddWithValue("@username", username.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Visible = false;
                }
                else
                {
                    msgbox box1 = new msgbox();
                    box1.Show();
                }
            }
            catch (Exception ex)
            {
                msgbox box1 = new msgbox();
                box1.lblBoxMessage.Text = ex.Message;
                box1.Show();
            }
            //exists = (int)cmd.ExecuteScalar() > 0;
            
        }

        //here the username is collected in globalscope variable
        private void txtBoxUsername_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxUsername.Text))
            {

            }
            username = txtBoxUsername.Text.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
