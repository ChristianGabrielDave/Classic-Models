using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicModels
{
    class ClassicModels
    {

        private MySqlConnection myConn = null;
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataAdapter mydataAdapter = new MySqlDataAdapter();
        private DataTable dt = new DataTable();
        private MySqlDataReader MySqlDataReader = null;

        private string connstring = @"server=localhost;userid=root;password=gabbydave3224;database=classicmodels";

        public bool Authentication1(string username, string password)
        {
            try
            {
                using (myConn = new MySqlConnection(connstring))
                {
                    myConn.Open();

                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT count(*) AS Record FROM login WHERE username=@username AND password=@password";

                        using (MySqlCommand cmd = new MySqlCommand(query, myConn))
                        {

                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);


                            int recordCount = Convert.ToInt32(cmd.ExecuteScalar());

                            if (recordCount > 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error message is: " + e.Message);
            }

            return false;
        }

        public bool Authentication(string username, string password)
        {
            try
            {

                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    string query = String.Format("SELECT count(*) AS Record FROM login WHERE username='{0}' AND password='{1}", username, password);

                    MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "login");
                    dt = ds.Tables["login"];

                    int recordCount = Convert.ToInt32(dt.Rows[0]["Record"]);

                    if (recordCount > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Error message is: " +e.Message);
            }

            return false;
        }

        public void SelectCustomers(DataGridView dgCustomers)
        {
            try 
            {
                myConn = new MySqlConnection(connstring);
                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if(myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT * FROM customers";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn)
                    }
                }
            }
        }

    }
}


