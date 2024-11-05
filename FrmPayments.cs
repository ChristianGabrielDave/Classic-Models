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
    public partial class FrmPayments : Form
    {
        ClassicModelsMain cm = new ClassicModelsMain();
        public FrmPayments()
        {
            InitializeComponent();
        }

        private void FrmPayments_Load(object sender, EventArgs e)
        {
            cm.SelectPayments(DtgrdPymnts);

            BindPayments(0);
        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }

        private void DtgrdPymnts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlPymnts.SelectedIndex = 0;
            BindPayments(e.RowIndex);
        }

        private void BindPayments(int e)
        {
            TxtbxCstmrNmbr.Text = DtgrdPymnts.Rows[e].Cells[0].Value.ToString();
            TxtbxChckNmbr.Text = DtgrdPymnts.Rows[e].Cells[1].Value.ToString();
            TxtbxPymntDt.Text = DtgrdPymnts.Rows[e].Cells[2].Value.ToString();
            TxtbxAmnt.Text = DtgrdPymnts.Rows[e].Cells[3].Value.ToString();
        }
    }
}
