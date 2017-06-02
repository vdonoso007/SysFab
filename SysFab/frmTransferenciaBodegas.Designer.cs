namespace SysFab
{
    partial class frmTransferenciaBodegas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferenciaBodegas));
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bódega",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Producto",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Stock",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Stock Físico",
            ""}, -1);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.txtNroTransferencia = new System.Windows.Forms.ToolStripTextBox();
            this.btnTransferir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTransferenciasPendientes = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.cboBodDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBodOrigen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboUndMedida = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDetalleTransferencia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEditar,
            this.txtNroTransferencia,
            this.btnTransferir,
            this.toolStripSeparator1,
            this.btnTransferenciasPendientes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(702, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            // 
            // txtNroTransferencia
            // 
            this.txtNroTransferencia.Name = "txtNroTransferencia";
            this.txtNroTransferencia.Size = new System.Drawing.Size(100, 25);
            // 
            // btnTransferir
            // 
            this.btnTransferir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTransferir.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferir.Image")));
            this.btnTransferir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(23, 22);
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTransferenciasPendientes
            // 
            this.btnTransferenciasPendientes.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferenciasPendientes.Image")));
            this.btnTransferenciasPendientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransferenciasPendientes.Name = "btnTransferenciasPendientes";
            this.btnTransferenciasPendientes.Size = new System.Drawing.Size(189, 22);
            this.btnTransferenciasPendientes.Text = "PENDIENTES POR TRANSFERIR";
            this.btnTransferenciasPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransferenciasPendientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTransferenciasPendientes.Click += new System.EventHandler(this.btnTransferenciasPendientes_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvDetalleTransferencia);
            this.splitContainer1.Size = new System.Drawing.Size(702, 501);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvInfo);
            this.splitContainer2.Size = new System.Drawing.Size(702, 234);
            this.splitContainer2.SplitterDistance = 351;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.txtCodProducto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboBodDestino, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboBodOrigen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCantidad, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboUndMedida, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtObservacion, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 234);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodProducto.ForeColor = System.Drawing.Color.LightGray;
            this.txtCodProducto.Location = new System.Drawing.Point(92, 48);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(255, 13);
            this.txtCodProducto.TabIndex = 2;
            this.txtCodProducto.Text = "Para buscar presione F5...";
            this.txtCodProducto.Enter += new System.EventHandler(this.txtCodProducto_Enter);
            this.txtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProducto_KeyDown);
            this.txtCodProducto.Leave += new System.EventHandler(this.txtCodProducto_Leave);
            // 
            // cboBodDestino
            // 
            this.cboBodDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboBodDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBodDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBodDestino.FormattingEnabled = true;
            this.cboBodDestino.Location = new System.Drawing.Point(89, 23);
            this.cboBodDestino.Margin = new System.Windows.Forms.Padding(0);
            this.cboBodDestino.Name = "cboBodDestino";
            this.cboBodDestino.Size = new System.Drawing.Size(261, 21);
            this.cboBodDestino.TabIndex = 1;
            this.cboBodDestino.Validating += new System.ComponentModel.CancelEventHandler(this.cboBodDestino_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bód. Origen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bód. Destino";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Und. Medida";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboBodOrigen
            // 
            this.cboBodOrigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboBodOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBodOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBodOrigen.FormattingEnabled = true;
            this.cboBodOrigen.Location = new System.Drawing.Point(89, 1);
            this.cboBodOrigen.Margin = new System.Windows.Forms.Padding(0);
            this.cboBodOrigen.Name = "cboBodOrigen";
            this.cboBodOrigen.Size = new System.Drawing.Size(261, 21);
            this.cboBodOrigen.TabIndex = 0;
            this.cboBodOrigen.Leave += new System.EventHandler(this.cboBodOrigen_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Location = new System.Drawing.Point(92, 90);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(255, 13);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cboUndMedida
            // 
            this.cboUndMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboUndMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUndMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUndMedida.FormattingEnabled = true;
            this.cboUndMedida.Location = new System.Drawing.Point(89, 65);
            this.cboUndMedida.Margin = new System.Windows.Forms.Padding(0);
            this.cboUndMedida.Name = "cboUndMedida";
            this.cboUndMedida.Size = new System.Drawing.Size(261, 21);
            this.cboUndMedida.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 105);
            this.label6.TabIndex = 5;
            this.label6.Text = "Observación";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObservacion
            // 
            this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Location = new System.Drawing.Point(92, 110);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(255, 105);
            this.txtObservacion.TabIndex = 6;
            this.txtObservacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObservacion_KeyDown);
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.lvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.GridLines = true;
            this.lvInfo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.lvInfo.Location = new System.Drawing.Point(0, 0);
            this.lvInfo.MultiSelect = false;
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(347, 234);
            this.lvInfo.TabIndex = 0;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "";
            this.columnHeader7.Width = 157;
            // 
            // lvDetalleTransferencia
            // 
            this.lvDetalleTransferencia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDetalleTransferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDetalleTransferencia.FullRowSelect = true;
            this.lvDetalleTransferencia.GridLines = true;
            this.lvDetalleTransferencia.Location = new System.Drawing.Point(0, 0);
            this.lvDetalleTransferencia.MultiSelect = false;
            this.lvDetalleTransferencia.Name = "lvDetalleTransferencia";
            this.lvDetalleTransferencia.Size = new System.Drawing.Size(702, 263);
            this.lvDetalleTransferencia.TabIndex = 0;
            this.lvDetalleTransferencia.UseCompatibleStateImageBehavior = false;
            this.lvDetalleTransferencia.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bód. Origen";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bód. Destino";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Producto";
            this.columnHeader2.Width = 256;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Und. Medida";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantidad";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmTransferenciaBodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 526);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTransferenciaBodegas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencia entre Bodegas";
            this.Load += new System.EventHandler(this.frmTransferenciaBodegas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripTextBox txtNroTransferencia;
        private System.Windows.Forms.ToolStripButton btnTransferir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBodOrigen;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ListView lvDetalleTransferencia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.ComboBox cboBodDestino;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboUndMedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnTransferenciasPendientes;
    }
}