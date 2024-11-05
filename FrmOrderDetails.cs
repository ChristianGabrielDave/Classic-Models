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
        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
