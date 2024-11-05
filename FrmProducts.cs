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
        }

        private void TxtbxPrdctCd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
