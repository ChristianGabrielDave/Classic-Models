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
        ClassicModels cm = new ClassicModels();
        bool newOrEdit;
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            //cm.SelectCustomers(dgCustomers);
            //FirstPrevNextLast(0);
            //cm.BindCustomerCountry(cmbcountry);
            //FirstPrevNextLast(0);
            //cm.BindCustomerState(cmbstate, cmbcountry);
            //cm.BindCustomerCity(cmbcity, cmbcountry);
            //cm.BindPostalCode(cmbpostalcode, cmbcountry);
            //cm.BindSalesRep(salesRep);
            //FirstPrevNextLast(0);
        }
        private void DtgrdCstmrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
