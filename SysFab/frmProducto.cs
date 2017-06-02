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
    public partial class frmProducto : Form
    {
        public enum statusForm
        {
            Inicio,
            Nuevo,
            Modificar,
            Guardar
        }

        public Master MasterToModify { get; set; }

        public statusForm EstadoFormulario { get; set; }

        public frmProducto()
        {
            InitializeComponent();
        }

        private void LoadCombos()
        {
            //Loading Type's products
            List<Catalog> catalogCollection = BOMaster.GetListCatalog(1);
            if (catalogCollection.Count > 0)
            {
                cboTipo.DataSource = catalogCollection;
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Description";
            }
            //Loading Line's products
            List<Catalog> lineCollection = BOMaster.GetListCatalog(2);
            if (lineCollection.Count > 0)
            {
                cboLineaProducto.DataSource = lineCollection;
                cboLineaProducto.ValueMember = "Id";
                cboLineaProducto.DisplayMember = "Description";
            }
            //Loading Categories products
            List<Catalog> categoryCollection = BOMaster.GetListCatalog(3);
            if (categoryCollection.Count > 0)
            {
                cboCategoriaProducto.DataSource = categoryCollection;
                cboCategoriaProducto.ValueMember = "Id";
                cboCategoriaProducto.DisplayMember = "Description";
            }
            //Loading Presentation products
            List<Catalog> presentationCollection = BOMaster.GetListCatalog(4);
            if (presentationCollection.Count > 0)
            {
                cboPresentacionProducto.DataSource = presentationCollection;
                cboPresentacionProducto.ValueMember = "Id";
                cboPresentacionProducto.DisplayMember = "Description";
            }
            //Loading Measured products
            List<Catalog> measureCollection = BOMaster.GetListCatalog(5);
            if (measureCollection.Count > 0)
            {
                cboUndMedidaProducto.DataSource = measureCollection;
                cboUndMedidaProducto.ValueMember = "Id";
                cboUndMedidaProducto.DisplayMember = "Description";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            LoadCombos();
            setStatusForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Ingrese el nombre del producto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                MessageBox.Show("Ingrese la descripción del producto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void setStatusForm()
        {
            if (EstadoFormulario == statusForm.Nuevo)
            {
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                txtCriterioBusqueda.Enabled = false;
                btnBuscarProducto.Enabled = false;
                txtCodBarra.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtDescripcionLarga.Clear();
                cboTipo.SelectedValue = -99;
                cboLineaProducto.SelectedValue = -99;
                cboCategoriaProducto.SelectedValue = -99;
                cboPresentacionProducto.SelectedValue = -99;
                cboUndMedidaProducto.SelectedValue = -99;
                txtMin.Clear();
                txtMax.Clear();
                txtCosto.Clear();
                dtpFechaExp.Value = DateTime.Now.AddMonths(-1);

                cboProveedor.SelectedIndex = 0;
                txtComposicion.Clear();
                txtAccFarma.Clear();
                txtDosis.Clear();
                txtTratamiento.Clear();
                cboVtaReceta.SelectedIndex = 1;

            }
            else if(EstadoFormulario == statusForm.Modificar)
            {
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                txtCriterioBusqueda.Enabled = false;
                btnBuscarProducto.Enabled = false;
                txtCodBarra.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtDescripcionLarga.Clear();
                cboTipo.SelectedValue = -99;
                cboLineaProducto.SelectedValue = -99;
                cboCategoriaProducto.SelectedValue = -99;
                cboPresentacionProducto.SelectedValue = -99;
                cboUndMedidaProducto.SelectedValue = -99;
                txtMin.Clear();
                txtMax.Clear();
                txtCosto.Clear();
                dtpFechaExp.Value = DateTime.Now.AddMonths(-1);

                cboProveedor.SelectedIndex = 0;
                txtComposicion.Clear();
                txtAccFarma.Clear();
                txtDosis.Clear();
                txtTratamiento.Clear();
                cboVtaReceta.SelectedIndex = 1;

                txtCodBarra.Text = MasterToModify.CodeBar;
                txtNombre.Text = MasterToModify.Name;
                txtDescripcion.Text = MasterToModify.ShortDescription;
                txtDescripcionLarga.Text = MasterToModify.Description;
                cboTipo.SelectedValue = MasterToModify.Type;
                cboLineaProducto.SelectedValue = MasterToModify.Line;
                cboCategoriaProducto.SelectedValue = MasterToModify.Category;
                cboPresentacionProducto.SelectedValue = MasterToModify.Presentation;
                cboUndMedidaProducto.SelectedValue = MasterToModify.UntMeasure;
                txtMin.Text = MasterToModify.Minimum.ToString();
                txtMax.Text = MasterToModify.Maximum.ToString();
                txtCosto.Text = MasterToModify.Cost.ToString();
                dtpFechaExp.Value = MasterToModify.ExpirationDate.HasValue?MasterToModify.ExpirationDate.Value: DateTime.Now.Date.AddMonths(-1);

                Pharmacology pharmaToModify = BOMaster.GetPharmaByMaster(MasterToModify.Id);
                cboProveedor.SelectedValue = pharmaToModify.Lab;
                txtComposicion.Text = pharmaToModify.Composition;
                txtAccFarma.Text = pharmaToModify.ActionPharmacology;
                txtDosis.Text = pharmaToModify.Dose;
                txtTratamiento.Text = pharmaToModify.Treatment;
                if (pharmaToModify.Prescription.HasValue)
                {
                    if (pharmaToModify.Prescription.Value)
                        cboVtaReceta.SelectedIndex = 0;
                    else
                        cboVtaReceta.SelectedIndex = 1;
                }
                else
                    cboVtaReceta.SelectedIndex = 1;

            }
        }

        private void Guardar()
        {
            if (Validar())
            {
                Master oneMaster = new Master();
                Pharmacology onePharma = new Pharmacology();
                if (EstadoFormulario == statusForm.Nuevo)
                    oneMaster.Id = 0;
                else if(EstadoFormulario == statusForm.Modificar)
                    oneMaster.Id = MasterToModify.Id;

                oneMaster.Name = txtNombre.Text.Trim();
                oneMaster.Description = txtDescripcionLarga.Text.Trim();
                oneMaster.ShortDescription = txtDescripcion.Text.Trim();
                oneMaster.CodeBar = txtCodBarra.Text.Trim();
                oneMaster.Type = (int)cboTipo.SelectedValue;
                oneMaster.Line = (int)cboLineaProducto.SelectedValue;
                oneMaster.Category = (int)cboCategoriaProducto.SelectedValue;
                oneMaster.Presentation = (int)cboPresentacionProducto.SelectedValue;
                oneMaster.UntMeasure = (int)cboUndMedidaProducto.SelectedValue;
                oneMaster.Minimum = string.IsNullOrEmpty(txtMin.Text) ? 0 : Convert.ToDecimal(txtMin.Text.Trim());
                oneMaster.Maximum = string.IsNullOrEmpty(txtMax.Text) ? 0 : Convert.ToDecimal(txtMax.Text.Trim());
                oneMaster.Cost = string.IsNullOrEmpty(txtCosto.Text) ? 0 : Convert.ToDecimal(txtCosto.Text.Trim());
                oneMaster.ExpirationDate = dtpFechaExp.Value.Date;

                onePharma.Master = oneMaster.Id;
                onePharma.Composition = txtComposicion.Text.Trim();
                onePharma.ActionPharmacology = txtAccFarma.Text.Trim();
                onePharma.Dose = txtDosis.Text.Trim();
                onePharma.Treatment = txtTratamiento.Text.Trim();
                onePharma.Lab = cboProveedor.SelectedIndex;
                onePharma.Prescription = cboVtaReceta.Text.Trim() == "SI" ? true : false;
                BOMaster.SaveMaster(oneMaster, onePharma);
            }
        }

        private void txtCodBarra_Validating(object sender, CancelEventArgs e)
        {
            Master tmp = BOMaster.GetMasterByBarCode(txtCodBarra.Text.Trim());
            if (EstadoFormulario == statusForm.Nuevo)
            {
                if (tmp!=null)
                {
                    MasterToModify.CodeBar = txtCodBarra.Text.Trim();
                    EstadoFormulario = statusForm.Modificar;
                    setStatusForm();
                }
                
            }
            if (EstadoFormulario == statusForm.Modificar && tmp!=null)
            {
                MasterToModify = tmp;
                MasterToModify.CodeBar = txtCodBarra.Text.Trim();
                EstadoFormulario = statusForm.Modificar;
                setStatusForm();
            }
        }

        private void txtCodBarra_Validated(object sender, EventArgs e)
        {
        }

        private void txtCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtCodBarra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
