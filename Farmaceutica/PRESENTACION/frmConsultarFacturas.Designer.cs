namespace Farmaceutica.PRESENTACION
{
    partial class frmConsultarFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarFacturas));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.ColIdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Teal;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(12, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 27);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdFactura,
            this.ColFecha,
            this.ColEmpleado,
            this.ColFormaPago,
            this.ColCliente,
            this.ColSucursal,
            this.ColAccion});
            this.dgvFacturas.Location = new System.Drawing.Point(12, 41);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersWidth = 51;
            this.dgvFacturas.Size = new System.Drawing.Size(868, 412);
            this.dgvFacturas.TabIndex = 1;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            // 
            // ColIdFactura
            // 
            this.ColIdFactura.HeaderText = "Factura N°";
            this.ColIdFactura.MinimumWidth = 6;
            this.ColIdFactura.Name = "ColIdFactura";
            this.ColIdFactura.Width = 125;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha Facturacion";
            this.ColFecha.MinimumWidth = 6;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.Width = 115;
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.HeaderText = "Empleado";
            this.ColEmpleado.MinimumWidth = 6;
            this.ColEmpleado.Name = "ColEmpleado";
            this.ColEmpleado.Width = 125;
            // 
            // ColFormaPago
            // 
            this.ColFormaPago.HeaderText = "Forma de Pago";
            this.ColFormaPago.MinimumWidth = 6;
            this.ColFormaPago.Name = "ColFormaPago";
            this.ColFormaPago.Width = 125;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.MinimumWidth = 6;
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.Width = 125;
            // 
            // ColSucursal
            // 
            this.ColSucursal.HeaderText = "Sucursal";
            this.ColSucursal.MinimumWidth = 6;
            this.ColSucursal.Name = "ColSucursal";
            this.ColSucursal.Width = 125;
            // 
            // ColAccion
            // 
            this.ColAccion.HeaderText = "Consultar";
            this.ColAccion.MinimumWidth = 6;
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAccion.Text = "Imprimir";
            this.ColAccion.UseColumnTextForButtonValue = true;
            this.ColAccion.Width = 125;
            // 
            // frmConsultarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 463);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(908, 510);
            this.MinimumSize = new System.Drawing.Size(908, 510);
            this.Name = "frmConsultarFacturas";
            this.Text = "frmConsultarFacturas";
            this.Load += new System.EventHandler(this.frmConsultarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        public System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSucursal;
        private System.Windows.Forms.DataGridViewButtonColumn ColAccion;
    }
}