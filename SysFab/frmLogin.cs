using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysFabBO;

namespace SysFab
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (BOUser.Login(txtUsuario.Text.Trim(), txtClave.Text.Trim()))
            { 
                Principal acceso = new Principal();
                acceso.Show();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecta", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
