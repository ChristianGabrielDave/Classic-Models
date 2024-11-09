using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicModels
{
    public partial class FrmCustomers : Form
    {
        ClassicModelsMain cm = new ClassicModelsMain();
        DataTable customers;
        int currentIndex = 0;

        private string connstring = @"server=localhost;userid=root;password=gabbydave3224;database=classicmodels";
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void EnableControls(bool enable) 
        {
            TxtbxCstmrNmbr.Enabled = enable;
            TxtbxCstmrNm.Enabled = enable;
            TxtbxCntctLN.Enabled = enable;
            TxtbxCntctFN.Enabled = enable;
            TxtbxPhnNmbr.Enabled = enable;
            TxtbxAddOne.Enabled = enable;
            TxtbxAddTwo.Enabled = enable;
            TxtbxCrdtLmt.Enabled = enable;
            TxtbxSlsRp.Enabled = enable;
            CmbbxCntry.Enabled = enable; 
            CmbbxCity.Enabled = enable;
            CmbbxState.Enabled = enable;
            CmbbxPstlCd.Enabled = enable;

            BttnSave.Enabled = enable;
            BttnUpdate.Enabled = enable;
            BttnDelete.Enabled = !enable;
            BttnCancel.Enabled = enable;

            BttnNew.Enabled = !enable;


            BttnFirst.Enabled = !enable;
            BttnNext.Enabled = !enable;
            BttnPrevious.Enabled = !enable;
            BttnLast.Enabled = !enable;
        }
        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            EnableControls(false);

            cm.SelectCustomers(DtgrdCstmrs);
            cm.BindCustomerCountry(CmbbxCntry);
            cm.BindCustomerState(CmbbxState, CmbbxCntry);
            cm.BindCustomerCity(CmbbxCity, CmbbxCntry);
            cm.BindPostalCode(CmbbxPstlCd, CmbbxCntry);

            CmbbxCity.Text = "";
            CmbbxCntry.Text = "";
            CmbbxPstlCd.Text = "";
            CmbbxState.Text = "";

        }
        private void DtgrdCstmrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlCstmrs.SelectedIndex = 0;
            BindCustomers(e.RowIndex);
        }

        private void BttnNew_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            BttnFirst.Enabled = false;
            BttnLast.Enabled = false;
            BttnNext.Enabled = false;
            BttnPrevious.Enabled = false;
            BttnCancel.Enabled = true;

            TxtbxCstmrNmbr.Clear();
            TxtbxCstmrNm.Clear();
            TxtbxCntctLN.Clear();
            TxtbxCntctFN.Clear();
            TxtbxPhnNmbr.Clear();
            TxtbxAddOne.Clear();
            TxtbxAddTwo.Clear();
            TxtbxCrdtLmt.Clear();
            TxtbxSlsRp.Clear(); 

            CmbbxCity.Text = "";
            CmbbxCntry.Text = "";
            CmbbxState.Text = "";
            CmbbxPstlCd.Text = "";


            TxtbxCstmrNmbr.Focus();
            currentIndex = DtgrdCstmrs.Rows.Count;
        }

        private void NewCstmrs_Click(object sender, EventArgs e)
        {

        }

        private void BindCustomers(int e)
        {
            TxtbxCstmrNmbr.Text = DtgrdCstmrs.Rows[e].Cells[0].Value.ToString();
            TxtbxCstmrNm.Text = DtgrdCstmrs.Rows[e].Cells[1].Value.ToString();
            TxtbxCntctLN.Text = DtgrdCstmrs.Rows[e].Cells[2].Value.ToString();
            TxtbxCntctFN.Text = DtgrdCstmrs.Rows[e].Cells[3].Value.ToString();
            TxtbxPhnNmbr.Text = DtgrdCstmrs.Rows[e].Cells[4].Value.ToString();
            TxtbxAddOne.Text = DtgrdCstmrs.Rows[e].Cells[5].Value.ToString();
            TxtbxAddTwo.Text = DtgrdCstmrs.Rows[e].Cells[6].Value.ToString();
            TxtbxCrdtLmt.Text = DtgrdCstmrs.Rows[e].Cells[12].Value.ToString();
            TxtbxSlsRp.Text = DtgrdCstmrs.Rows[e].Cells[11].Value.ToString();
            CmbbxCntry.Text = DtgrdCstmrs.Rows[e].Cells[10].Value.ToString();
            CmbbxCity.Text = DtgrdCstmrs.Rows[e].Cells[7].Value.ToString();
            CmbbxState.Text = DtgrdCstmrs.Rows[e].Cells[8].Value.ToString();
            CmbbxPstlCd.Text = DtgrdCstmrs.Rows[e].Cells[9].Value.ToString();

            BttnFirst.Enabled = (currentIndex != 0);
            BttnPrevious.Enabled = (currentIndex > 0);
            BttnNext.Enabled = (currentIndex < DtgrdCstmrs.Rows.Count - 2);
            BttnLast.Enabled = (currentIndex != DtgrdCstmrs.Rows.Count - 2);
        }

        private void dgCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlCstmrs.SelectedIndex = 0;
            currentIndex = 0;
            BindCustomers(e.RowIndex);
        }

        private void BttnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            BindCustomers(currentIndex);
            BttnPrevious.Enabled = false;
            BttnNext.Enabled = true;

            BttnSave.Enabled = false;
            BttnDelete.Enabled = true;
            BttnCancel.Enabled = false;

        }

        private void BttnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < DtgrdCstmrs.Rows.Count - 2)
            {
                currentIndex++;
                BindCustomers(currentIndex);
            }

            BttnNext.Enabled = (currentIndex < DtgrdCstmrs.Rows.Count - 2);

            BttnPrevious.Enabled = true;
            BttnCancel.Enabled = false;
        }

        private void BttnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                BindCustomers(currentIndex);
            }
            BttnPrevious.Enabled = (currentIndex > 0);
            BttnNext.Enabled = true;
            BttnCancel.Enabled = false;
        }

        private void BttnLast_Click(object sender, EventArgs e)
        {
            currentIndex = DtgrdCstmrs.Rows.Count - 2;
            BindCustomers(currentIndex);
            BttnPrevious.Enabled = true;
            BttnNext.Enabled = false;
            BttnFirst.Enabled = true;
            BttnLast.Enabled = false;

            BttnSave.Enabled = false;
            BttnDelete.Enabled = true;
            BttnCancel.Enabled = false;
        }

        private void BttnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connstring))
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO customers 
                            (customerNumber, customerName, contactFirstName, contactLastName, phone, addressLine1, 
                             addressLine2, city, postalCode, country, salesRepEmployeeNumber, creditLimit) 
                             VALUES (@customerNumber, @customerName, @contactFirstName, @contactLastName, @phone, 
                             @addressLine1, @addressLine2, @city, @postalCode, @country, @salesRepEmployeeNumber, @creditLimit)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerNumber", TxtbxCstmrNmbr.Text);
                        command.Parameters.AddWithValue("@customerName", TxtbxCstmrNm.Text);
                        command.Parameters.AddWithValue("@contactFirstName", TxtbxCntctFN.Text);
                        command.Parameters.AddWithValue("@contactLastName", TxtbxCntctLN.Text);
                        command.Parameters.AddWithValue("@phone", TxtbxPhnNmbr.Text);
                        command.Parameters.AddWithValue("@addressLine1", TxtbxAddOne.Text);
                        command.Parameters.AddWithValue("@addressLine2", TxtbxAddTwo.Text);
                        command.Parameters.AddWithValue("@city", CmbbxCity.Text);
                        command.Parameters.AddWithValue("@postalCode", CmbbxPstlCd.Text);
                        command.Parameters.AddWithValue("@country", CmbbxCntry.Text);

                        if (string.IsNullOrEmpty(TxtbxSlsRp.Text))
                        {
                            command.Parameters.AddWithValue("@salesRepEmployeeNumber", DBNull.Value);
                        }
                        else
                        {
                            using (MySqlCommand checkEmployee = new MySqlCommand("SELECT COUNT(*) FROM employees WHERE employeeNumber = @salesRep", connection))
                            {
                                checkEmployee.Parameters.AddWithValue("@salesRep", TxtbxSlsRp.Text);
                                int employeeExists = Convert.ToInt32(checkEmployee.ExecuteScalar());

                                if (employeeExists == 0)
                                {
                                    MessageBox.Show("The Sales Rep Employee Number does not exist in the employees table.", "Invalid Sales Rep", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                command.Parameters.AddWithValue("@salesRepEmployeeNumber", TxtbxSlsRp.Text);
                            }
                        }

                        command.Parameters.AddWithValue("@creditLimit", string.IsNullOrEmpty(TxtbxCrdtLmt.Text) ? (object)DBNull.Value : Convert.ToDecimal(TxtbxCrdtLmt.Text));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void BttnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtbxCstmrNmbr.Text))
            {
                MessageBox.Show("Please select a customer to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connstring))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("DELETE FROM customers WHERE customerNumber = @customerNumber", connection))
                    {
                        command.Parameters.AddWithValue("@customerNumber", TxtbxCstmrNmbr.Text);
                        command.ExecuteNonQuery();
                    }
                }

                cm.SelectCustomers(DtgrdCstmrs);
            }
        }

        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtbxCstmrNmbr.Text) || string.IsNullOrWhiteSpace(TxtbxCstmrNm.Text))
            {
                MessageBox.Show("Customer Number and Name are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connstring))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("UPDATE customers SET customerName = @customerName, contactLastName = @contactLastName, contactFirstName = @contactFirstName, phone = @phone, addressLine1 = @addressLine1, addressLine2 = @addressLine2, creditLimit = @creditLimit, salesRepEmployeeNumber = @salesRep, city = @city, country = @country, postalCode = @postalCode, state = @state WHERE customerNumber = @customerNumber", connection))
                {
                    command.Parameters.AddWithValue("@customerNumber", TxtbxCstmrNmbr.Text);
                    command.Parameters.AddWithValue("@customerName", TxtbxCstmrNm.Text);
                    command.Parameters.AddWithValue("@contactLastName", TxtbxCntctLN.Text);
                    command.Parameters.AddWithValue("@contactFirstName", TxtbxCntctFN.Text);
                    command.Parameters.AddWithValue("@phone", TxtbxPhnNmbr.Text);
                    command.Parameters.AddWithValue("@addressLine1", TxtbxAddOne.Text);
                    command.Parameters.AddWithValue("@addressLine2", TxtbxAddTwo.Text);
                    command.Parameters.AddWithValue("@creditLimit", TxtbxCrdtLmt.Text);
                    command.Parameters.AddWithValue("@salesRep", TxtbxSlsRp.Text);
                    command.Parameters.AddWithValue("@city", CmbbxCity.Text);
                    command.Parameters.AddWithValue("@country", CmbbxCntry.Text);
                    command.Parameters.AddWithValue("@postalCode", CmbbxPstlCd.Text);
                    command.Parameters.AddWithValue("@state", CmbbxState.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            cm.SelectCustomers(DtgrdCstmrs);
        }

        private void BttnCancel_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Are you sure you want to cancel? All unsaved changes will be lost.", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (result == DialogResult.Yes)
            //{
                TxtbxCstmrNmbr.Clear();
                TxtbxCstmrNm.Clear();
                TxtbxCntctLN.Clear();
                TxtbxCntctFN.Clear();
                TxtbxPhnNmbr.Clear();
                TxtbxAddOne.Clear();
                TxtbxAddTwo.Clear();
                TxtbxCrdtLmt.Clear();
                TxtbxSlsRp.Clear();

                CmbbxCity.Text = "";
                CmbbxCntry.Text = "";
                CmbbxState.Text = "";
                CmbbxPstlCd.Text = "";

                EnableControls(false);
            //}
        }
    }
}
