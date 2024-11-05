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
    public partial class FrmOrderDetails : Form
    {
        ClassicModelsMain cm = new ClassicModelsMain();
        public FrmOrderDetails()
        {
            InitializeComponent();
        }
        private void FrmOrders_Load(object sender, EventArgs e)
        {
            cm.SelectOrderDetails(DtgrdOrdrDtls);

            BindOrderDetails(0);
        }

        private void BttnNew_Click(object sender, EventArgs e)
        {
        }

        private void DtgrdOrdrDtls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlOrdrDtls.SelectedIndex = 0;
            BindOrderDetails(e.RowIndex);
        }

        private void BindOrderDetails(int e)
        {
            TxtbxOrdrNmbr.Text = DtgrdOrdrDtls.Rows[e].Cells[0].Value.ToString();
            TxtbxOrdrLnNmbr.Text = DtgrdOrdrDtls.Rows[e].Cells[4].Value.ToString();
            TxtbxPrdctCd.Text = DtgrdOrdrDtls.Rows[e].Cells[1].Value.ToString();
            TxtbxPrcEach.Text = DtgrdOrdrDtls.Rows[e].Cells[3].Value.ToString();
            TxtbxQnttOrdrd.Text = DtgrdOrdrDtls.Rows[e].Cells[2].Value.ToString();
        }
    }
}
