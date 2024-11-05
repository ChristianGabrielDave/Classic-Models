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

            BindCustomers(0);
        }
        private void DtgrdCstmrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlCstmrs.SelectedIndex = 0;
            BindCustomers(e.RowIndex);
        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

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
        }

        private void dgCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlCstmrs.SelectedIndex = 0;
            BindCustomers(e.RowIndex);
        }

    }
}
