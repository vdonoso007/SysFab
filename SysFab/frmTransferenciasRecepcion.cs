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

namespace SysFab
{
    public partial class frmTransferenciasRecepcion : Form
    {
        public frmTransferenciasRecepcion()
        {
            InitializeComponent();
        }

        private void frmTransferenciasRecepcion_Load(object sender, EventArgs e)
        {
            GetTransfersInTransit();
        }

        private void GetTransfersInTransit()
        {
            var listTrn = BOTransfer.GetTransfersInTransit();
            lvTransferenciasPendientes.Items.Clear();
            foreach(var item in listTrn)
            {
                lvTransferenciasPendientes.Items.Add(item.Id.ToString("D5"));
                lvTransferenciasPendientes.Items[lvTransferenciasPendientes.Items.Count - 1].SubItems.Add(item.Description);
                lvTransferenciasPendientes.Items[lvTransferenciasPendientes.Items.Count - 1].SubItems.Add(item.TransferDate.ToShortDateString());
                lvTransferenciasPendientes.Items[lvTransferenciasPendientes.Items.Count - 1].SubItems.Add(item.Status);
            }
            if (lvTransferenciasPendientes.Items.Count > 0) { 
                lvTransferenciasPendientes.Items[0].Selected = true;
                txtNroTransferencia.Text = lvTransferenciasPendientes.Items[0].Text.Trim();
            }
        }

        private void GetItemsTransferInTransit(int Number)
        {
            grdDetailTransfer.Rows.Clear();
            dynamic result = BOTransfer.GetTransfersDetailIntransit(Number);
            foreach (var reg in result)
            {
                grdDetailTransfer.Rows.Add(1);
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count -1].Cells[0].Value = reg.Line;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[0].ReadOnly = true;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[1].Value = reg.Src;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[1].ReadOnly = true;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[2].Value = reg.Target;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[2].ReadOnly = true;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[3].Value = reg.Master;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[3].ReadOnly = true;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[4].Value = reg.UntMeasure;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[4].ReadOnly = true;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[5].Value = reg.Qty;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[5].ReadOnly = true;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[6].Value = reg.Seleccionar;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[6].ReadOnly = false;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[7].Value = reg.Observación;
                grdDetailTransfer.Rows[grdDetailTransfer.Rows.Count - 1].Cells[7].ReadOnly = false;
            }
        }

        private void lvTransferenciasPendientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                txtNroTransferencia.Text = lvTransferenciasPendientes.Items[e.ItemIndex].Text.Trim();
                GetItemsTransferInTransit(Convert.ToInt32(txtNroTransferencia.Text));
            }
        }

        private void grdDetailTransfer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetailTransfer.CurrentCell.ColumnIndex == 6)
            {
                grdDetailTransfer.BeginEdit(true);
            }
        }

        private void grdDetailTransfer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetailTransfer.CurrentCell.ColumnIndex == 6)
            {
                //dynamic obj = grdDetailTransfer.CurrentRow.DataBoundItem;
                //obj.Seleccionar = grdDetailTransfer.CurrentCell.Value;

                //grdDetailTransfer.Rows[grdDetailTransfer.CurrentRow.Index].Cells["Seleccionar"].Value = true;

            }
        }
    }
}
