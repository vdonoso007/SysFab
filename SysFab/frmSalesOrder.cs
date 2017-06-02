using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFab
{
    public partial class frmSalesOrder : Form
    {
        public frmSalesOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            frmAdmClientes objadmcli = new frmAdmClientes();
            objadmcli.ShowDialog(); 
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmAdmProductos objadmprod = new frmAdmProductos();
            objadmprod.ShowDialog();
        }
    }
}
