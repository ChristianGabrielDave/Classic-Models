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
    public partial class FrmProductLines : Form
    {
        ClassicModelsMain cm = new ClassicModelsMain();
        public FrmProductLines()
        {
            InitializeComponent();
        }

        private void FrmProductLines_Load(object sender, EventArgs e)
        {
            cm.SelectProductLines(DtgrdPrdctLns);

            BindProductLines(0);
        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }

        private void DtgrdPrdctLns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlPrdctLns.SelectedIndex = 0;
            BindProductLines(e.RowIndex);
        }

        private void BindProductLines(int e)
        {
            TxtbxPrdctLn.Text = DtgrdPrdctLns.Rows[e].Cells[0].Value.ToString();
            TxtbxTxtDesc.Text = DtgrdPrdctLns.Rows[e].Cells[1].Value.ToString();
            TxtbxHTMLDesc.Text = DtgrdPrdctLns.Rows[e].Cells[2].Value.ToString();
            TxtbxImg.Text = DtgrdPrdctLns.Rows[e].Cells[3].Value.ToString();
        }
    }
}
