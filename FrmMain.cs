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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers();
            frmCustomers.MdiParent = this;
            frmCustomers.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployees frmEmployees = new FrmEmployees();
            frmEmployees.MdiParent = this;
            frmEmployees.Show();
        }

        private void productLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductLines frmProductLines = new FrmProductLines();
            frmProductLines.MdiParent = this;
            frmProductLines.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducts frmProducts = new FrmProducts();
            frmProducts.MdiParent = this;
            frmProducts.Show();
        }

        private void officesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOffices frmOffices = new FrmOffices();
            frmOffices.MdiParent = this;
            frmOffices.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrders frmOrders = new FrmOrders();
            frmOrders.MdiParent = this;
            frmOrders.Show();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayments frmPayments = new FrmPayments();
            frmPayments.MdiParent = this;
            frmPayments.Show();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderDetails frmOrderDetails = new FrmOrderDetails();
            frmOrderDetails.MdiParent = this;
            frmOrderDetails.Show();
        }
    }
}
