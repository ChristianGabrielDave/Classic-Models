﻿using System;
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
    public partial class FrmProductLines : Form
    {
        ClassicModelsMain cm = new ClassicModelsMain();
        public FrmProductLines()
        {
            InitializeComponent();
        }

        private void FrmProductLines_Load(object sender, EventArgs e)
        {
            cm.SelectProductLines(DtgrdPrdctLns);
        }

        private void BttnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
