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
using SysFabEAL;
using System.Dynamic;

namespace SysFab
{
    /*static class GrottyHacks
    {
        internal static T Cast<T>(object target, T example)
        {
            return (T)target;
        }
    }*/

    public partial class frmTransferenciaBodegas : Form
    {
        public enum statusForm
        {
            Inicio,
            Nuevo,
            Modificar,
            Guardar,
            Transferir
        }

        public statusForm EstadoFormulario { get; set; }

        public frmTransferenciaBodegas()
        {
            InitializeComponent();
        }

        private void setStatusForm()
        {
            if (EstadoFormulario == statusForm.Nuevo)
            {
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                txtNroTransferencia.Enabled = false;
                btnTransferir.Enabled = true;
                cboBodOrigen.Enabled = true;
                cboBodDestino.Enabled = true;
                txtCodProducto.Enabled = true;
                txtCantidad.Enabled = true;

                cboBodOrigen.SelectedIndex = 0;
                cboBodDestino.SelectedIndex = 1;
                txtNroTransferencia.Clear();
                txtCodProducto.Clear();
                txtCantidad.Clear();

                //limpiar lvInfo
                lvDetalleTransferencia.Items.Clear();

            }
            else if (EstadoFormulario == statusForm.Inicio)
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                txtNroTransferencia.Enabled = false;
                btnTransferir.Enabled = true;
                cboBodOrigen.Enabled = true;
                cboBodDestino.Enabled = true;
                txtCodProducto.Enabled = true;
                txtCantidad.Enabled = true;

                cboBodOrigen.SelectedIndex = 0;
                cboBodDestino.SelectedIndex = 1;
                txtNroTransferencia.Clear();
                txtCodProducto.Clear();
                txtCantidad.Clear();

                //limpiar lvInfo
                lvDetalleTransferencia.Items.Clear();
            }
            else if (EstadoFormulario == statusForm.Modificar)
            {
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                txtNroTransferencia.Enabled = true;
                btnTransferir.Enabled = true;

                cboBodOrigen.Enabled = false;
                cboBodDestino.Enabled = false;
                txtCodProducto.Enabled = false;
                txtCantidad.Enabled = false;

                cboBodOrigen.SelectedIndex = 0;
                cboBodDestino.SelectedIndex = 1;
                txtNroTransferencia.Clear();
                txtCodProducto.Clear();
                txtCantidad.Clear();

            }
        }

        private void LoadCombos()
        {
            cboBodOrigen.DataSource = BOWarehouse.GetListWarehouse();
            cboBodOrigen.DisplayMember = "Description";
            cboBodOrigen.ValueMember = "Id";

            List<DescWarehouse> bd = BOWarehouse.GetListWarehouse();
            cboBodDestino.DataSource = bd;
            cboBodDestino.DisplayMember = "Description";
            cboBodDestino.ValueMember = "Id";

            cboUndMedida.DataSource = BOMaster.GetListCatalog(5);
            cboUndMedida.DisplayMember = "Description";
            cboUndMedida.ValueMember = "Id";
        }

        private void frmTransferenciaBodegas_Load(object sender, EventArgs e)
        {
            LoadCombos();
            EstadoFormulario = statusForm.Inicio;
            setStatusForm();
        }

        private void txtCodProducto_Enter(object sender, EventArgs e)
        {
            txtCodProducto.Text = "";
            txtCodProducto.ForeColor = Color.Black;
        }

        private void txtCodProducto_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodProducto.Text)) { 
                txtCodProducto.Text = "Para buscar presione F5...";
                txtCodProducto.ForeColor = Color.LightGray;
            }
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                BuscarProducto();
            }
        }

        private void BuscarProducto()
        {
            frmAdmProductos objAdmProd = new frmAdmProductos();
            objAdmProd.Modo = frmAdmProductos.modoApertura.Busqueda;
            objAdmProd.filtro = txtCodProducto.Text.Trim();
            objAdmProd.ShowDialog(); 
            if (objAdmProd.filteredItem!=null)
            {
                txtCodProducto.Text = objAdmProd.filteredItem.Name;
                txtCodProducto.Tag = objAdmProd.filteredItem;
                MostrarStock(((int)cboBodOrigen.SelectedValue), objAdmProd.filteredItem.Id);
                SendKeys.Send("{TAB}");
            }
        }

        private void MostrarStock(int bod, int pro)
        {
            dynamic item = BOTransfer.GetWarehouseStockByMaster(bod, pro);
            if (item==null)
            {
                MessageBox.Show("Producto no existe en bodega", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lvInfo.Items[0].SubItems[1].Text = item.Description;
            lvInfo.Items[1].SubItems[1].Text = item.Name;
            lvInfo.Items[2].SubItems[1].Text = item.Quantity.ToString();
            lvInfo.Items[3].SubItems[1].Text = item.QtyOnHand.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstadoFormulario = statusForm.Nuevo;
            setStatusForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private bool ValidarDatosTransferencia()
        {
            if (cboBodOrigen.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar la bodega origen", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboBodOrigen.Focus();
                return false;
            }
            if (cboBodDestino.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar la bodega destino", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboBodDestino.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCodProducto.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar un producto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodProducto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar la cantidad del producto a transferir", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtCantidad.Text.Trim()) < 1)
            {
                MessageBox.Show("La cantidad del producto a transferir debe ser mayor a cero", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return false;
            }
            return true;
        }

        private void Guardar()
        {
            if (!ValidarDatosTransferencia())
                return;

            if (EstadoFormulario == statusForm.Nuevo)
            {
                Transfer ot = new Transfer();
                TransferDetail td = new TransferDetail();
                if (string.IsNullOrEmpty(txtNroTransferencia.Text.Trim()))
                    ot.Id = 0;
                else { 
                    ot.Id = Convert.ToInt32(txtNroTransferencia.Text.Trim());
                    td.Transfer = ot.Id;
                }
                ot.Description = txtObservacion.Text.Trim();
                ot.TransferDate = DateTime.Now;
                ot.TransferType = "B";
                ot.Status = "I";

                td.Line = lvDetalleTransferencia.Items.Count+1;
                td.SrcWarehouse = (int)cboBodOrigen.SelectedValue;
                td.TrgWarehouse = (int)cboBodDestino.SelectedValue;
                td.Master = ((Master)txtCodProducto.Tag).Id;
                td.UntMeasure = (int)cboUndMedida.SelectedValue;
                td.Quantity = Convert.ToDecimal(txtCantidad.Text.Trim());

                BOTransfer.SaveTransfer(ref ot, ref td);
                txtNroTransferencia.Text = ot.Id.ToString("D5");
                setLineTransferListView(td);
                CleanControls();
            }
        }

        private void setLineTransferListView(TransferDetail line)
        {
            lvDetalleTransferencia.Items.Add(BOTransfer.GetNameWarehouse(line.SrcWarehouse));
            lvDetalleTransferencia.Items[lvDetalleTransferencia.Items.Count -1].SubItems.Add(BOTransfer.GetNameWarehouse(line.TrgWarehouse));
            lvDetalleTransferencia.Items[lvDetalleTransferencia.Items.Count - 1].SubItems.Add(BOMaster.GetNameMasterById(line.Master));
            lvDetalleTransferencia.Items[lvDetalleTransferencia.Items.Count - 1].SubItems.Add(BOMaster.GetNameMeasuredById( line.UntMeasure));
            lvDetalleTransferencia.Items[lvDetalleTransferencia.Items.Count - 1].SubItems.Add(line.Quantity.ToString());
            lvDetalleTransferencia.Items[lvDetalleTransferencia.Items.Count - 1].Tag = line;
        }

        private void CleanControls()
        {
            txtCodProducto.Clear();
            txtCantidad.Clear();
            cboBodOrigen.SelectedIndex = 0;
            if (cboBodDestino.Items.Count > 1)
                cboBodDestino.SelectedIndex = 1;
            else
                cboBodDestino.SelectedIndex = 0;
            txtCodProducto.Focus();
        }

        private void txtObservacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Guardar();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void cboBodDestino_Validating(object sender, CancelEventArgs e)
        {
            if (cboBodOrigen.SelectedValue == cboBodDestino.SelectedValue)
            {
                MessageBox.Show("La bodega destino debe ser diferente de la bodega origen", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }

        private void cboBodOrigen_Leave(object sender, EventArgs e)
        {

        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de realizar esta transferencia ?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                BOTransfer.TransferToWarehouse(((Transfer)txtNroTransferencia.Tag).Id);
                MessageBox.Show("Transferencia realizada y en transito", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoFormulario = statusForm.Nuevo;
                setStatusForm();
            }
        }

        private void SetItemOnHoldToTransfer(int transfer)
        {
            Transfer oneTrn = BOTransfer.GetHeaderById(transfer);
            List<TransferDetail> detailTrn = BOTransfer.GetDetailById(transfer);
            if (oneTrn!=null && detailTrn != null)
            {
                txtNroTransferencia.Tag = oneTrn;
                txtNroTransferencia.Text = oneTrn.Id.ToString("D5");
                txtObservacion.Text = oneTrn.Description;

                lvDetalleTransferencia.Items.Clear();
                foreach(var item in detailTrn)
                {
                    setLineTransferListView(item);
                }

            }
        }

        private void btnTransferenciasPendientes_Click(object sender, EventArgs e)
        {
            frmTransferenciasPendientes objTrnHoldFrm = new frmTransferenciasPendientes();
            objTrnHoldFrm.ShowDialog();
            dynamic itemOnHold = objTrnHoldFrm.ItemOnHold;
            if (itemOnHold!=null)
                SetItemOnHoldToTransfer(itemOnHold.TransferNr);
        }
    }
}
