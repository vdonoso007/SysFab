namespace SysFab
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCriterioBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscarProducto = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarTipoProducto = new System.Windows.Forms.Button();
            this.btnBuscarUndMedia = new System.Windows.Forms.Button();
            this.btnBuscarPresentacion = new System.Windows.Forms.Button();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.btnBuscarLineaProducto = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboUndMedidaProducto = new System.Windows.Forms.ComboBox();
            this.cboPresentacionProducto = new System.Windows.Forms.ComboBox();
            this.cboCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboLineaProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcionLarga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboVtaReceta = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAccFarma = new System.Windows.Forms.TextBox();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.txtComposicion = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpFechaExp = new System.Windows.Forms.DateTimePicker();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.toolStripSeparator1,
            this.txtCriterioBusqueda,
            this.btnBuscarProducto});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1077, 25);
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
            this.btnNuevo.Text = "toolStripButton1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "toolStripButton2";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtCriterioBusqueda
            // 
            this.txtCriterioBusqueda.Name = "txtCriterioBusqueda";
            this.txtCriterioBusqueda.Size = new System.Drawing.Size(100, 25);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(23, 22);
            this.btnBuscarProducto.Text = "toolStripButton3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscarTipoProducto);
            this.panel1.Controls.Add(this.btnBuscarUndMedia);
            this.panel1.Controls.Add(this.btnBuscarPresentacion);
            this.panel1.Controls.Add(this.btnBuscarCategoria);
            this.panel1.Controls.Add(this.btnBuscarLineaProducto);
            this.panel1.Controls.Add(this.cboTipo);
            this.panel1.Controls.Add(this.cboUndMedidaProducto);
            this.panel1.Controls.Add(this.cboPresentacionProducto);
            this.panel1.Controls.Add(this.cboCategoriaProducto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cboLineaProducto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDescripcionLarga);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodBarra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 276);
            this.panel1.TabIndex = 11;
            // 
            // btnBuscarTipoProducto
            // 
            this.btnBuscarTipoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTipoProducto.Image")));
            this.btnBuscarTipoProducto.Location = new System.Drawing.Point(508, 151);
            this.btnBuscarTipoProducto.Name = "btnBuscarTipoProducto";
            this.btnBuscarTipoProducto.Size = new System.Drawing.Size(39, 23);
            this.btnBuscarTipoProducto.TabIndex = 33;
            this.btnBuscarTipoProducto.TabStop = false;
            this.btnBuscarTipoProducto.UseVisualStyleBackColor = true;
            // 
            // btnBuscarUndMedia
            // 
            this.btnBuscarUndMedia.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUndMedia.Image")));
            this.btnBuscarUndMedia.Location = new System.Drawing.Point(508, 247);
            this.btnBuscarUndMedia.Name = "btnBuscarUndMedia";
            this.btnBuscarUndMedia.Size = new System.Drawing.Size(39, 23);
            this.btnBuscarUndMedia.TabIndex = 32;
            this.btnBuscarUndMedia.TabStop = false;
            this.btnBuscarUndMedia.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPresentacion
            // 
            this.btnBuscarPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPresentacion.Image")));
            this.btnBuscarPresentacion.Location = new System.Drawing.Point(508, 223);
            this.btnBuscarPresentacion.Name = "btnBuscarPresentacion";
            this.btnBuscarPresentacion.Size = new System.Drawing.Size(39, 23);
            this.btnBuscarPresentacion.TabIndex = 31;
            this.btnBuscarPresentacion.TabStop = false;
            this.btnBuscarPresentacion.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCategoria.Image")));
            this.btnBuscarCategoria.Location = new System.Drawing.Point(508, 199);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(39, 23);
            this.btnBuscarCategoria.TabIndex = 30;
            this.btnBuscarCategoria.TabStop = false;
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLineaProducto
            // 
            this.btnBuscarLineaProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarLineaProducto.Image")));
            this.btnBuscarLineaProducto.Location = new System.Drawing.Point(508, 175);
            this.btnBuscarLineaProducto.Name = "btnBuscarLineaProducto";
            this.btnBuscarLineaProducto.Size = new System.Drawing.Size(39, 23);
            this.btnBuscarLineaProducto.TabIndex = 29;
            this.btnBuscarLineaProducto.TabStop = false;
            this.btnBuscarLineaProducto.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(107, 152);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(397, 21);
            this.cboTipo.TabIndex = 4;
            // 
            // cboUndMedidaProducto
            // 
            this.cboUndMedidaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUndMedidaProducto.FormattingEnabled = true;
            this.cboUndMedidaProducto.Location = new System.Drawing.Point(107, 248);
            this.cboUndMedidaProducto.Name = "cboUndMedidaProducto";
            this.cboUndMedidaProducto.Size = new System.Drawing.Size(397, 21);
            this.cboUndMedidaProducto.TabIndex = 8;
            // 
            // cboPresentacionProducto
            // 
            this.cboPresentacionProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPresentacionProducto.FormattingEnabled = true;
            this.cboPresentacionProducto.Location = new System.Drawing.Point(107, 224);
            this.cboPresentacionProducto.Name = "cboPresentacionProducto";
            this.cboPresentacionProducto.Size = new System.Drawing.Size(397, 21);
            this.cboPresentacionProducto.TabIndex = 7;
            // 
            // cboCategoriaProducto
            // 
            this.cboCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaProducto.FormattingEnabled = true;
            this.cboCategoriaProducto.Location = new System.Drawing.Point(107, 200);
            this.cboCategoriaProducto.Name = "cboCategoriaProducto";
            this.cboCategoriaProducto.Size = new System.Drawing.Size(397, 21);
            this.cboCategoriaProducto.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tipo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLineaProducto
            // 
            this.cboLineaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineaProducto.FormattingEnabled = true;
            this.cboLineaProducto.Location = new System.Drawing.Point(107, 176);
            this.cboLineaProducto.Name = "cboLineaProducto";
            this.cboLineaProducto.Size = new System.Drawing.Size(397, 21);
            this.cboLineaProducto.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Und. Medida";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcionLarga
            // 
            this.txtDescripcionLarga.Location = new System.Drawing.Point(107, 95);
            this.txtDescripcionLarga.MaxLength = 300;
            this.txtDescripcionLarga.Multiline = true;
            this.txtDescripcionLarga.Name = "txtDescripcionLarga";
            this.txtDescripcionLarga.Size = new System.Drawing.Size(440, 54);
            this.txtDescripcionLarga.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Presentación";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Categoria";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Linea";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Descripción Larga";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(107, 72);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(440, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripción";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 49);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(440, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(107, 26);
            this.txtCodBarra.MaxLength = 20;
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(201, 20);
            this.txtCodBarra.TabIndex = 0;
            this.txtCodBarra.TextChanged += new System.EventHandler(this.txtCodBarra_TextChanged);
            this.txtCodBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodBarra_KeyDown);
            this.txtCodBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarra_KeyPress);
            this.txtCodBarra.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodBarra_Validating);
            this.txtCodBarra.Validated += new System.EventHandler(this.txtCodBarra_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cód. Barra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(555, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(207, 22);
            this.toolStripLabel1.Text = "DATOS PRINCIPALES DEL PRODUCTO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboVtaReceta);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtAccFarma);
            this.panel2.Controls.Add(this.txtTratamiento);
            this.panel2.Controls.Add(this.txtDosis);
            this.panel2.Controls.Add(this.txtComposicion);
            this.panel2.Controls.Add(this.btnBuscarProveedor);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cboProveedor);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.toolStrip3);
            this.panel2.Location = new System.Drawing.Point(558, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 276);
            this.panel2.TabIndex = 12;
            // 
            // cboVtaReceta
            // 
            this.cboVtaReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVtaReceta.FormattingEnabled = true;
            this.cboVtaReceta.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboVtaReceta.Location = new System.Drawing.Point(95, 245);
            this.cboVtaReceta.Name = "cboVtaReceta";
            this.cboVtaReceta.Size = new System.Drawing.Size(412, 21);
            this.cboVtaReceta.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Vta. C./ Receta";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAccFarma
            // 
            this.txtAccFarma.Location = new System.Drawing.Point(95, 98);
            this.txtAccFarma.MaxLength = 200;
            this.txtAccFarma.Multiline = true;
            this.txtAccFarma.Name = "txtAccFarma";
            this.txtAccFarma.Size = new System.Drawing.Size(413, 46);
            this.txtAccFarma.TabIndex = 2;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(95, 196);
            this.txtTratamiento.MaxLength = 200;
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(413, 46);
            this.txtTratamiento.TabIndex = 4;
            // 
            // txtDosis
            // 
            this.txtDosis.Location = new System.Drawing.Point(95, 147);
            this.txtDosis.MaxLength = 100;
            this.txtDosis.Multiline = true;
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(413, 46);
            this.txtDosis.TabIndex = 3;
            // 
            // txtComposicion
            // 
            this.txtComposicion.Location = new System.Drawing.Point(95, 49);
            this.txtComposicion.MaxLength = 200;
            this.txtComposicion.Multiline = true;
            this.txtComposicion.Name = "txtComposicion";
            this.txtComposicion.Size = new System.Drawing.Size(413, 46);
            this.txtComposicion.TabIndex = 1;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProveedor.Image")));
            this.btnBuscarProveedor.Location = new System.Drawing.Point(468, 24);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(39, 23);
            this.btnBuscarProveedor.TabIndex = 34;
            this.btnBuscarProveedor.TabStop = false;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tratamiento";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 28);
            this.label12.TabIndex = 1;
            this.label12.Text = "Acción Famarcológica";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Dosis";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Items.AddRange(new object[] {
            "PROVEEDOR GENERAL"});
            this.cboProveedor.Location = new System.Drawing.Point(95, 25);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(370, 21);
            this.cboProveedor.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Composición";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Proveedor";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(514, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(154, 22);
            this.toolStripLabel2.Text = "DATOS FARMACOLÓGICOS";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpFechaExp);
            this.panel3.Controls.Add(this.txtCosto);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtMax);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtMin);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.toolStrip4);
            this.panel3.Location = new System.Drawing.Point(0, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 129);
            this.panel3.TabIndex = 13;
            // 
            // dtpFechaExp
            // 
            this.dtpFechaExp.Location = new System.Drawing.Point(107, 97);
            this.dtpFechaExp.Name = "dtpFechaExp";
            this.dtpFechaExp.Size = new System.Drawing.Size(443, 20);
            this.dtpFechaExp.TabIndex = 3;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(107, 74);
            this.txtCosto.MaxLength = 19;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(443, 20);
            this.txtCosto.TabIndex = 2;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(38, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Fecha Exp.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(65, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Costo";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(107, 51);
            this.txtMax.MaxLength = 3;
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(443, 20);
            this.txtMax.TabIndex = 1;
            this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Stock Máx.";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(107, 28);
            this.txtMin.MaxLength = 3;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(443, 20);
            this.txtMin.TabIndex = 0;
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Stock Mín.";
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(555, 25);
            this.toolStrip4.TabIndex = 0;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(266, 22);
            this.toolStripLabel3.Text = "INFORMACION PARA MANEJO DEL INVENTARIO";
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1077, 444);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtCriterioBusqueda;
        private System.Windows.Forms.ToolStripButton btnBuscarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnBuscarTipoProducto;
        private System.Windows.Forms.Button btnBuscarUndMedia;
        private System.Windows.Forms.Button btnBuscarPresentacion;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Button btnBuscarLineaProducto;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboUndMedidaProducto;
        private System.Windows.Forms.ComboBox cboPresentacionProducto;
        private System.Windows.Forms.ComboBox cboCategoriaProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboLineaProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcionLarga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAccFarma;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.TextBox txtComposicion;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ComboBox cboVtaReceta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DateTimePicker dtpFechaExp;
        private System.Windows.Forms.Label label19;
    }
}