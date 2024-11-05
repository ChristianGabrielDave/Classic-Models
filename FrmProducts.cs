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
    public partial class FrmProducts : Form
    {
        ClassicModelsMain cm = new ClassicModelsMain();
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            cm.SelectProducts(DtgrdPrdcts);

            BindProducts(0);
        }

        private void TxtbxPrdctCd_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtgrdPrdcts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlPrdcts.SelectedIndex = 0;
            BindProducts(e.RowIndex);
        }

        private void BindProducts(int e)
        {
            TxtbxPrdctCd.Text = DtgrdPrdcts.Rows[e].Cells[0].Value.ToString();
            TxtbxPrdctLn.Text = DtgrdPrdcts.Rows[e].Cells[2].Value.ToString();
            TxtbxPrdctScl.Text = DtgrdPrdcts.Rows[e].Cells[3].Value.ToString();
            TxtbxPrdctNm.Text = DtgrdPrdcts.Rows[e].Cells[1].Value.ToString();
            TxtbxPrdctVndr.Text = DtgrdPrdcts.Rows[e].Cells[4].Value.ToString();
            TxtbxQntStck.Text = DtgrdPrdcts.Rows[e].Cells[6].Value.ToString();
            TxtbxBuyPrc.Text = DtgrdPrdcts.Rows[e].Cells[7].Value.ToString();
            TxtbxMSRP.Text = DtgrdPrdcts.Rows[e].Cells[8].Value.ToString();
            TxtbxPrdctDesc.Text = DtgrdPrdcts.Rows[e].Cells[5].Value.ToString();
        }
    }
}
