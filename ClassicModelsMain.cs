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
    class ClassicModelsMain
    {

        private MySqlConnection myConn = null;
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataAdapter mydataAdapter = new MySqlDataAdapter();
        private DataTable dt = new DataTable();
        private MySqlDataReader MySqlDataReader = null;

        private string connstring = @"server=localhost;userid=root;password=minecraft24;database=classicmodels";


        public bool Authentication1(string username, string password)
        {
            try
            {
                using (myConn = new MySqlConnection(connstring))
                {
                    myConn.Open();

                    if (myConn.State == ConnectionState.Open)
                    {
                        string query =
                            "SELECT count(*) AS Record FROM users WHERE username=@username AND password=@password";

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

        public void SelectCustomers(DataGridView DtgrdCstmrs)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT * FROM customers";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "customers");
                        dt = ds.Tables["customers"];



                        DtgrdCstmrs.DataSource = dt;
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

        public void BindCustomerState(ComboBox cb, ComboBox CmbbxCntry)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct state AS State FROM customers WHERE country = '" +
                                       CmbbxCntry.Text + "' ORDER BY State ASC";

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

        public void BindCustomerCity(ComboBox cb, ComboBox CmbbxCntry)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct city AS City FROM customers WHERE country = '" +
                                       CmbbxCntry.Text + "' ORDER BY City ASC";

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


        public void BindPostalCode(ComboBox cb, ComboBox CmbbxCntry)
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
                            string query = "SELECT Distinct postalCode AS postalCode FROM customers WHERE country = '" +
                                           CmbbxCntry.Text + "' ORDER BY postalCode ASC";


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

        public void SelectEmployees(DataGridView DtgrdEmplys)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT * FROM employees";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "employees");
                        dt = ds.Tables["employees"];



                        DtgrdEmplys.DataSource = dt;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindEmployeesOfficeCode(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct officeCode AS OfficeCode FROM employees ORDER BY OfficeCode ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "OfficeCode";
                        cb.ValueMember = "OfficeCode";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void SelectProductLines(DataGridView DtgrdPrdctLns)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT * FROM productlines";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "productlines");
                        dt = ds.Tables["productlines"];

                        DtgrdPrdctLns.DataSource = dt;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }

            return;
        }

        public void SelectProducts(DataGridView DtgrdPrdcts)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT * FROM products";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "products");
                        dt = ds.Tables["products"];

                        DtgrdPrdcts.DataSource = dt;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }

            return;
        }

        public void SelectOffices(DataGridView DtgrdOffcs)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT * FROM offices";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "offices");
                        dt = ds.Tables["offices"];

                        DtgrdOffcs.DataSource = dt;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }

            return;
        }

        public void BindOfficesTerritory(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct territory AS Territory FROM offices ORDER BY Territory ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "Territory";
                        cb.ValueMember = "Territory";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindOfficesCountry(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct country AS Country FROM offices ORDER BY Country ASC";

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

        public void BindOfficesCity(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct city AS City FROM offices ORDER BY City ASC";

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

        public void BindOfficesState(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct state AS State FROM offices ORDER BY State ASC";

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

        public void BindOfficesPostalCode(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct postalCode AS PostalCode FROM offices ORDER BY PostalCode ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "PostalCode";
                        cb.ValueMember = "PostalCode";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void SelectOrders(DataGridView DtgrdOrdrs)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT * FROM orders";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "orders");
                        dt = ds.Tables["orders"];

                        DtgrdOrdrs.DataSource = dt;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }

            return;
        }

        public void BindOrdersStatus(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct status AS Status FROM orders ORDER BY Status ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "Status";
                        cb.ValueMember = "Status";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void SelectOrderDetails(DataGridView DtgrdOrdrDtls)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT * FROM orderdetails";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "orderdetails");
                        dt = ds.Tables["orderdetails"];

                        DtgrdOrdrDtls.DataSource = dt;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }

            return;
        }

        public void SelectPayments(DataGridView DtgrdPymnts)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT * FROM payments";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "payments");
                        dt = ds.Tables["payments"];

                        DtgrdPymnts.DataSource = dt;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }

            return;
        }
    }
}