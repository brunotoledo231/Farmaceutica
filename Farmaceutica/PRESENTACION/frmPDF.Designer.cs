namespace Farmaceutica.PRESENTACION
{
    partial class frmPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDF));
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvPDF = new System.Windows.Forms.DataGridView();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalConDescuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtFormaPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(21, 18);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(100, 20);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura N°";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(142, 18);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(53, 20);
            this.txtFactura.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(142, 44);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(213, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(142, 70);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(157, 20);
            this.txtEmpleado.TabIndex = 5;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(142, 96);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(157, 20);
            this.txtCliente.TabIndex = 7;
            // 
            // dgvPDF
            // 
            this.dgvPDF.AllowUserToAddRows = false;
            this.dgvPDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPDF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProducto,
            this.ColPrecio,
            this.ColCantidad,
            this.ColDescuento});
            this.dgvPDF.Location = new System.Drawing.Point(31, 174);
            this.dgvPDF.Name = "dgvPDF";
            this.dgvPDF.RowHeadersWidth = 51;
            this.dgvPDF.Size = new System.Drawing.Size(544, 150);
            this.dgvPDF.TabIndex = 10;
            this.dgvPDF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPDF_CellContentClick);
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.MinimumWidth = 6;
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.Width = 200;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio $";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.Width = 125;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad (un)";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 125;
            // 
            // ColDescuento
            // 
            this.ColDescuento.HeaderText = "Descuento  %";
            this.ColDescuento.MinimumWidth = 6;
            this.ColDescuento.Name = "ColDescuento";
            this.ColDescuento.Width = 125;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(418, 330);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(157, 20);
            this.txtDescuento.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Descuentos $";
            // 
            // txtTotalConDescuento
            // 
            this.txtTotalConDescuento.Location = new System.Drawing.Point(418, 356);
            this.txtTotalConDescuento.Name = "txtTotalConDescuento";
            this.txtTotalConDescuento.Size = new System.Drawing.Size(157, 20);
            this.txtTotalConDescuento.TabIndex = 14;
            this.txtTotalConDescuento.TextChanged += new System.EventHandler(this.txtTotalConDescuento_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Abonado $";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Teal;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(425, 135);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(150, 30);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sucursal:";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(142, 122);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(157, 20);
            this.txtSucursal.TabIndex = 9;
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.Location = new System.Drawing.Point(142, 148);
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.Size = new System.Drawing.Size(157, 20);
            this.txtFormaPago.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Forma de Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cliente:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Teal;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(425, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 30);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 434);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFormaPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtTotalConDescuento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPDF);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.lblFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPDF";
            this.Text = "Consulta Factura";
            this.Load += new System.EventHandler(this.frmPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFactura;
        public System.Windows.Forms.TextBox txtFactura;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.TextBox txtEmpleado;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.DataGridView dgvPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescuento;
        public System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTotalConDescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSucursal;
        public System.Windows.Forms.TextBox txtFormaPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
    }
}