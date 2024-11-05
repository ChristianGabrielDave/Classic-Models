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
        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
