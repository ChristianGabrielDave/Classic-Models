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
        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
