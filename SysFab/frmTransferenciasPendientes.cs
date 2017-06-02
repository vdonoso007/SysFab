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
    public partial class frmTransferenciasPendientes : Form
    {
        public object ItemOnHold { get; set; }

        public frmTransferenciasPendientes()
        {
            InitializeComponent();
        }

        private void cboBodOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBodOrigen.ComboBox.SelectedIndex >-1 && cboBodDestino.ComboBox.SelectedIndex > -1)
                LoadTrnOnHold((int)cboBodOrigen.ComboBox.SelectedValue, (int)cboBodDestino.ComboBox.SelectedValue);
        }

        private void cboBodDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBodOrigen.ComboBox.SelectedIndex > -1 && cboBodDestino.ComboBox.SelectedIndex > -1)
            {
                if (cboBodDestino.ComboBox.SelectedValue !=null && !cboBodDestino.ComboBox.SelectedValue.ToString().Equals("SysFabEAL.DescWarehouse"))
                    LoadTrnOnHold((int)cboBodOrigen.ComboBox.SelectedValue, (int)cboBodDestino.ComboBox.SelectedValue);
            }
        }

        private void frmTransferenciasPendientes_Load(object sender, EventArgs e)
        {
            List<DescWarehouse> lst1 = BOWarehouse.GetListWarehouse();
            cboBodOrigen.ComboBox.DataSource = lst1;
            cboBodOrigen.ComboBox.ValueMember = "Id";
            cboBodOrigen.ComboBox.DisplayMember = "Description";
            

            List<DescWarehouse> lst2 = BOWarehouse.GetListWarehouse();
            cboBodDestino.ComboBox.DataSource = lst2;
            cboBodDestino.ComboBox.ValueMember = "Id";
            cboBodDestino.ComboBox.DisplayMember = "Description";
            

        }

        private void LoadTrnOnHold(int WhrSrc, int WhrTrg)
        {
            List<dynamic> listOnHold = BOTransfer.GetTransfersOnHold(WhrSrc, WhrTrg);

            lvTrnPend.Items.Clear();
            foreach(dynamic item in listOnHold)
            {
                lvTrnPend.Items.Add(item.Source.ToString());
                lvTrnPend.Items[lvTrnPend.Items.Count - 1].Tag = item;
                lvTrnPend.Items[lvTrnPend.Items.Count -1].SubItems.Add(item.Target.ToString());
                lvTrnPend.Items[lvTrnPend.Items.Count - 1].SubItems.Add(item.Master.ToString());
                lvTrnPend.Items[lvTrnPend.Items.Count - 1].SubItems.Add(item.UndMed);
                lvTrnPend.Items[lvTrnPend.Items.Count - 1].SubItems.Add(item.Qty.ToString());
                lvTrnPend.Items[lvTrnPend.Items.Count - 1].SubItems.Add("");//Date of transfer register
                lvTrnPend.Items[lvTrnPend.Items.Count - 1].SubItems.Add(item.TransferNr.ToString("D5"));

            }

        }

        private void lvTrnPend_DoubleClick(object sender, EventArgs e)
        {
            if (lvTrnPend.SelectedItems!=null && lvTrnPend.SelectedItems.Count > 0)
            {
                ItemOnHold = lvTrnPend.SelectedItems[0].Tag;
                Close();
            }
        }
    }
}
