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
    public partial class FrmCustomers : Form
    {
        ClassicModels md = new ClassicModels();
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            md.SelectCustomers(dgCustomers);
        }
        private void DtgrdCstmrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
