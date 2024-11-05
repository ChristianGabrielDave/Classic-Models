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
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            cm.SelectCustomers(DtgrdCstmrs);
            cm.BindCustomerCountry(CmbbxCntry);
            cm.BindCustomerState(CmbbxState, CmbbxCntry);
            cm.BindCustomerCity(CmbbxCity, CmbbxCntry);
            cm.BindPostalCode(CmbbxPstlCd, CmbbxCntry);
        }
        private void DtgrdCstmrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }

        private void NewCstmrs_Click(object sender, EventArgs e)
        {

        }
    }
}
