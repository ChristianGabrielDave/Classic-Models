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
    public partial class FrmLogin : Form
    {
        ClassicModelsMain cm = new ClassicModelsMain();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BttnLgn_Click(object sender, EventArgs e)
        {
            if (cm.Authentication(TxtbxUsn.Text.Trim(), TxtbxPass.Text.Trim()))
            {
                FrmMain mainFrm = new FrmMain();
                this.Hide();
                mainFrm.ShowDialog();
                this.Close();
            }

        }

        private void BttnCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
