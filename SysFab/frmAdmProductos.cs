using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysFabEAL;
using SysFabBO;

namespace SysFab
{
    public partial class frmAdmProductos : Form
    {
        public enum modoApertura
        {
            Busqueda
        }

        private Master _filteredItem;
        public modoApertura Modo { get; set; }
        public string filtro { get; set; }
        public Master filteredItem { get { return _filteredItem; } }

        public frmAdmProductos()
        {
            InitializeComponent();
        }

        private void frmAdmProductos_Load(object sender, EventArgs e)
        {
            if (Modo == modoApertura.Busqueda)
                GetListMaster(filtro);
            else
                GetListMaster();
        }

        private void GetListMaster()
        {
            lvProductos.Items.Clear();
            List<Master> masterCollection = BOMaster.GetListMaster();
            if (masterCollection.Count > 0)
            {
                foreach (Master item in masterCollection)
                {
                    lvProductos.Items.Add(item.CodeBar);
                    lvProductos.Items[lvProductos.Items.Count-1].SubItems.Add(item.Name);
                    lvProductos.Items[lvProductos.Items.Count-1].SubItems.Add(item.UntMeasure.ToString());
                    lvProductos.Items[lvProductos.Items.Count - 1].SubItems.Add("0");
                    lvProductos.Items[lvProductos.Items.Count-1].SubItems.Add(item.Cost.ToString());
                    lvProductos.Items[lvProductos.Items.Count - 1].Tag = item;
                }
            }
        }

        private void GetListMaster(string filtro)
        {
            lvProductos.Items.Clear();
            Master aMaster = BOMaster.GetMasterByBarCode(filtro);
            if (aMaster != null)
            {
                lvProductos.Items.Add(aMaster.CodeBar);
                lvProductos.Items[lvProductos.Items.Count - 1].SubItems.Add(aMaster.Name);
                lvProductos.Items[lvProductos.Items.Count - 1].SubItems.Add(aMaster.UntMeasure.ToString());
                lvProductos.Items[lvProductos.Items.Count - 1].SubItems.Add("0");
                lvProductos.Items[lvProductos.Items.Count - 1].SubItems.Add(aMaster.Cost.ToString());
                lvProductos.Items[lvProductos.Items.Count - 1].Tag = aMaster;
            }
            else
            {
                List<Master> masterCollection = BOMaster.GetListMasterByFilter(filtro);
                foreach (Master item in masterCollection)
                {
                    lvProductos.Items.Add(item.CodeBar);
                    lvProductos.Items[lvProductos.Items.Count - 1].SubItems.Add(item.Name);
                    lvProductos.Items[lvProductos.Items.Count - 1].SubItems.Add(item.UntMeasure.ToString());
                    lvProductos.Items[lvProductos.Items.Count - 1].SubItems.Add("0");
                    lvProductos.Items[lvProductos.Items.Count - 1].SubItems.Add(item.Cost.ToString());
                    lvProductos.Items[lvProductos.Items.Count - 1].Tag = item;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProducto objFrmProducto = new frmProducto();
            objFrmProducto.EstadoFormulario = frmProducto.statusForm.Nuevo;
            //objFrmProducto.MdiParent = this.MdiParent;
            objFrmProducto.ShowDialog();
            GetListMaster();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            setMaster();
        }

        private void setMaster()
        {
            if (lvProductos.SelectedItems.Count > 0)
            {
                frmProducto objFrmProducto = new frmProducto();
                objFrmProducto.EstadoFormulario = frmProducto.statusForm.Modificar;
                objFrmProducto.MasterToModify = (Master)lvProductos.SelectedItems[0].Tag;
                objFrmProducto.ShowDialog();
                GetListMaster();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificarlo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lvProductos_DoubleClick(object sender, EventArgs e)
        {
            if (Modo == modoApertura.Busqueda)
            {
                if (lvProductos.SelectedItems.Count > 0)
                {
                    _filteredItem = (Master)lvProductos.SelectedItems[0].Tag;
                    Close();
                }
            }
            else
            { setMaster(); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Esta seguro de eliminar este producto?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.No)
                return;

            if (lvProductos.SelectedItems.Count > 0)
            {
                if (BOMaster.DeleteMaster(((Master)lvProductos.SelectedItems[0].Tag).Id))
                    GetListMaster();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminarlo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
