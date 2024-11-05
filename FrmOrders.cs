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
        }

        private void DtgrdOrdrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
