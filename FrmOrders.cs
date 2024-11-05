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
    public partial class FrmOrders : Form
    {
        ClassicModelsMain cm = new ClassicModelsMain();
        public FrmOrders()
        {
            InitializeComponent();
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            cm.SelectOrders(DtgrdOrdrs);
            cm.BindOrdersStatus(CmbbxStts);

            BindOrders(0);
        }

        private void DtgrdOrdrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlOrdrs.SelectedIndex = 0;
            BindOrders(e.RowIndex);
        }
        private void BindOrders(int e)
        {
            TxtbxOrdrNmbr.Text = DtgrdOrdrs.Rows[e].Cells[0].Value.ToString();
            TxtbxCstmrNmbr.Text = DtgrdOrdrs.Rows[e].Cells[6].Value.ToString();
            TxtbxOrdrDt.Text = DtgrdOrdrs.Rows[e].Cells[1].Value.ToString();
            TxtbxShppDt.Text = DtgrdOrdrs.Rows[e].Cells[3].Value.ToString();
            TxtbxRqrdDt.Text = DtgrdOrdrs.Rows[e].Cells[2].Value.ToString();
            TxtbxCmmnts.Text = DtgrdOrdrs.Rows[e].Cells[5].Value.ToString();
            CmbbxStts.Text = DtgrdOrdrs.Rows[e].Cells[4].Value.ToString();
        }
    }
}
