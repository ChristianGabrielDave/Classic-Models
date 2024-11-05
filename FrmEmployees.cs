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
        }

        private void BttnFirst_Click(object sender, EventArgs e)
        {

        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
