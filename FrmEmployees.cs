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
    public partial class FrmEmployees : Form
    {
        ClassicModelsMain cm = new ClassicModelsMain();
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            cm.SelectEmployees(DtgrdEmplys);
            cm.BindEmployeesOfficeCode(CmbbxOffcCd);

            BindEmployees(0);
        }

        private void BttnFirst_Click(object sender, EventArgs e)
        {

        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }

        private void DtgrdEmplys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlEmplys.SelectedIndex = 0;
            BindEmployees(e.RowIndex);
        }

        private void BindEmployees(int e)
        {
            TxtbxEmplyNum.Text = DtgrdEmplys.Rows[e].Cells[0].Value.ToString();
            TxtbxLN.Text = DtgrdEmplys.Rows[e].Cells[1].Value.ToString();
            TxtbxFN.Text = DtgrdEmplys.Rows[e].Cells[2].Value.ToString();
            TxtbxExtnsn.Text = DtgrdEmplys.Rows[e].Cells[3].Value.ToString();
            TxtbxRprtsTo.Text = DtgrdEmplys.Rows[e].Cells[6].Value.ToString();
            TxtbxJbTtl.Text = DtgrdEmplys.Rows[e].Cells[7].Value.ToString();
            TxtbxEmail.Text = DtgrdEmplys.Rows[e].Cells[4].Value.ToString();
            CmbbxOffcCd.Text = DtgrdEmplys.Rows[e].Cells[5].Value.ToString();
        }
    }
}
