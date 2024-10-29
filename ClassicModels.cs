using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
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
                        string query = "SELECT count(*) AS Record FROM users WHERE username=@username AND password=@password";

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
                    myConn.Open();

                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = String.Format("SELECT count(*) AS Record FROM users " +
                                             "WHERE username='{0}' AND password='{1}'", username, password);

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);
                        DataSet ds = new DataSet();

                        da.Fill(ds, "users");
                        dt = ds.Tables["users"];

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
            }
            catch (Exception e)
            {
                MessageBox.Show("Error message is: " + e.Message);
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
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT customerNumber AS 'Customer Number', customerName AS 'Customer Name', " +
                            "country AS Country, state, contactLastName, contactFirstName, Phone, addressLine1, " +
                            "addressLine2, postalCode, salesRepEmployeeNumber ,creditLimit, city FROM customers";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "customers");
                        dt = ds.Tables["customers"];



                        dgCustomers.DataSource = dt;
                        dgCustomers.Columns[0].Width = 200;
                        dgCustomers.Columns[1].Width = 450;
                        dgCustomers.Columns[2].Width = 200;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
            //totalRows = dt.Rows.Count - 1;
            //EnabledCustomerForm("000000");
            //ClearForms();
            //EnabledButton("1000001");
            //EnabledNavButtons("1110");
        }

        public void BindCustomerCountry(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct country AS Country FROM customers ORDER BY Country ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "Country";
                        cb.ValueMember = "Country";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindCustomerState(ComboBox cb, ComboBox cmbcountry)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct state AS State FROM customers WHERE country = '" + cmbcountry.Text + "' ORDER BY State ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "State";
                        cb.ValueMember = "State";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindCustomerCity(ComboBox cb, ComboBox cmbcountry)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct city AS City FROM customers WHERE country = '" + cmbcountry.Text + "' ORDER BY City ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "City";
                        cb.ValueMember = "City";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }


        public void BindPostalCode(ComboBox cb, ComboBox cmbcountry)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        {
                            string query = "SELECT Distinct postalCode AS postalCode FROM customers WHERE country = '" + cmbcountry.Text + "' ORDER BY postalCode ASC";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "postalCode";
                            cb.ValueMember = "postalCode";

                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindSalesRep(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct salesRepEmployeeNumber AS salesRep FROM customers ORDER BY salesRep ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "salesRep";
                        cb.ValueMember = "salesRep";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }
    }
}