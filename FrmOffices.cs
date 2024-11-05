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
    public partial class FrmOffices : Form
    {
        ClassicModelsMain cm = new ClassicModelsMain();
        public FrmOffices()
        {
            InitializeComponent();
        }
        private void FrmOffices_Load(object sender, EventArgs e)
        {
            cm.SelectOffices(DtgrdOffcs);
            cm.BindOfficesCity(CmbbxCity);
            cm.BindOfficesCountry(CmbbxCntry);
            cm.BindOfficesState(CmbbxState);
            cm.BindOfficesTerritory(CmbbxTrrtry);
            cm.BindOfficesPostalCode(CmbbxPstlCd);

            BindOffices(0);
        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }

        private void DtgrdOffcs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbcntrlOffcs.SelectedIndex = 0;
            BindOffices(e.RowIndex);
        }

        private void BindOffices(int e)
        {
            TxtbxOffcCd.Text = DtgrdOffcs.Rows[e].Cells[0].Value.ToString();
            TxtbxPhnNmbr.Text = DtgrdOffcs.Rows[e].Cells[2].Value.ToString();
            TxtbxAddOne.Text = DtgrdOffcs.Rows[e].Cells[3].Value.ToString();
            TxtbxAddTwo.Text = DtgrdOffcs.Rows[e].Cells[4].Value.ToString();
            CmbbxTrrtry.Text = DtgrdOffcs.Rows[e].Cells[8].Value.ToString();
            CmbbxState.Text = DtgrdOffcs.Rows[e].Cells[5].Value.ToString();
            CmbbxCity.Text = DtgrdOffcs.Rows[e].Cells[1].Value.ToString();
            CmbbxPstlCd.Text = DtgrdOffcs.Rows[e].Cells[7].Value.ToString();
            CmbbxCntry.Text = DtgrdOffcs.Rows[e].Cells[6].Value.ToString();
        }
    }
}
