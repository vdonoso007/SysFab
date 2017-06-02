namespace SysFab
{
    partial class frmTomaInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTomaInventario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.clProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUndMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StkSis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStkFis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboBodega = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnSiguiente = new System.Windows.Forms.ToolStripButton();
            this.btnUltima = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboBodega,
            this.btnNuevo,
            this.btnGuardar,
            this.toolStripButton3,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(879, 25);
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
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "btnEditar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 42);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Responsable";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MMM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(602, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nro.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(726, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toolStrip2);
            this.panel3.Controls.Add(this.dgvInventario);
            this.panel3.Location = new System.Drawing.Point(12, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(862, 443);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProducto,
            this.clUndMedida,
            this.clUbicacion,
            this.clVenc,
            this.clLote,
            this.StkSis,
            this.clStkFis,
            this.clDiferencia});
            this.dgvInventario.Location = new System.Drawing.Point(8, 36);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.Size = new System.Drawing.Size(845, 394);
            this.dgvInventario.TabIndex = 0;
            // 
            // clProducto
            // 
            this.clProducto.HeaderText = "Producto";
            this.clProducto.Name = "clProducto";
            this.clProducto.ReadOnly = true;
            // 
            // clUndMedida
            // 
            this.clUndMedida.HeaderText = "Und. Medida";
            this.clUndMedida.Name = "clUndMedida";
            this.clUndMedida.ReadOnly = true;
            // 
            // clUbicacion
            // 
            this.clUbicacion.HeaderText = "Ubicacion";
            this.clUbicacion.Name = "clUbicacion";
            this.clUbicacion.ReadOnly = true;
            // 
            // clVenc
            // 
            this.clVenc.HeaderText = "Vencimiento";
            this.clVenc.Name = "clVenc";
            this.clVenc.ReadOnly = true;
            // 
            // clLote
            // 
            this.clLote.HeaderText = "Lote";
            this.clLote.Name = "clLote";
            this.clLote.ReadOnly = true;
            // 
            // StkSis
            // 
            this.StkSis.HeaderText = "Stk. Sist.";
            this.StkSis.Name = "StkSis";
            this.StkSis.ReadOnly = true;
            // 
            // clStkFis
            // 
            this.clStkFis.HeaderText = "Stk. Fís.";
            this.clStkFis.Name = "clStkFis";
            this.clStkFis.ReadOnly = true;
            // 
            // clDiferencia
            // 
            this.clDiferencia.HeaderText = "Diferencia";
            this.clDiferencia.Name = "clDiferencia";
            this.clDiferencia.ReadOnly = true;
            // 
            // cboBodega
            // 
            this.cboBodega.Name = "cboBodega";
            this.cboBodega.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel1.Text = "Bodega";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAnterior,
            this.btnSiguiente,
            this.btnUltima,
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(862, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAnterior
            // 
            this.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(23, 22);
            this.btnAnterior.Text = "Anterior";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(23, 22);
            this.btnSiguiente.Text = "Siguiente";
            // 
            // btnUltima
            // 
            this.btnUltima.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUltima.Image = ((System.Drawing.Image)(resources.GetObject("btnUltima.Image")));
            this.btnUltima.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltima.Name = "btnUltima";
            this.btnUltima.Size = new System.Drawing.Size(23, 22);
            this.btnUltima.Text = "Ultima";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // frmTomaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTomaInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toma de inventario";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmTomaInventario_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUndMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn StkSis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStkFis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiferencia;
        private System.Windows.Forms.ToolStripComboBox cboBodega;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnSiguiente;
        private System.Windows.Forms.ToolStripButton btnUltima;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}