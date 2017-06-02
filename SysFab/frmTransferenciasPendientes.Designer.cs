namespace SysFab
{
    partial class frmTransferenciasPendientes
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboBodOrigen = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cboBodDestino = new System.Windows.Forms.ToolStripComboBox();
            this.lvTrnPend = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboBodOrigen,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.cboBodDestino});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel1.Text = "Bód. Origen";
            // 
            // cboBodOrigen
            // 
            this.cboBodOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBodOrigen.Name = "cboBodOrigen";
            this.cboBodOrigen.Size = new System.Drawing.Size(121, 25);
            this.cboBodOrigen.SelectedIndexChanged += new System.EventHandler(this.cboBodOrigen_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel2.Text = "Bód. Destino";
            // 
            // cboBodDestino
            // 
            this.cboBodDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBodDestino.Name = "cboBodDestino";
            this.cboBodDestino.Size = new System.Drawing.Size(121, 25);
            this.cboBodDestino.SelectedIndexChanged += new System.EventHandler(this.cboBodDestino_SelectedIndexChanged);
            // 
            // lvTrnPend
            // 
            this.lvTrnPend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvTrnPend.FullRowSelect = true;
            this.lvTrnPend.GridLines = true;
            this.lvTrnPend.Location = new System.Drawing.Point(12, 28);
            this.lvTrnPend.MultiSelect = false;
            this.lvTrnPend.Name = "lvTrnPend";
            this.lvTrnPend.Size = new System.Drawing.Size(814, 365);
            this.lvTrnPend.TabIndex = 1;
            this.lvTrnPend.UseCompatibleStateImageBehavior = false;
            this.lvTrnPend.View = System.Windows.Forms.View.Details;
            this.lvTrnPend.DoubleClick += new System.EventHandler(this.lvTrnPend_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Origen";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Destino";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Producto";
            this.columnHeader3.Width = 182;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Und. Medida";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cantidad";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha Ing. Trn.";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nro. Transferencia";
            this.columnHeader7.Width = 104;
            // 
            // frmTransferenciasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 405);
            this.Controls.Add(this.lvTrnPend);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTransferenciasPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencias Pendientes";
            this.Load += new System.EventHandler(this.frmTransferenciasPendientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView lvTrnPend;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboBodOrigen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cboBodDestino;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}