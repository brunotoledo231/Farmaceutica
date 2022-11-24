namespace Farmaceutica.REPORTES.ConsultasDiseño
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pamasvendidosxsucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSConsulta1 = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.pa_mas_vendidos_x_sucursalTableAdapter = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1TableAdapters.pa_mas_vendidos_x_sucursalTableAdapter();
            this.sPMOSTRARSUCURSALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_MOSTRAR_SUCURSALESTableAdapter = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1TableAdapters.SP_MOSTRAR_SUCURSALESTableAdapter();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pamasvendidosxsucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARSUCURSALESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pamasvendidosxsucursalBindingSource
            // 
            this.pamasvendidosxsucursalBindingSource.DataMember = "pa_mas_vendidos_x_sucursal";
            this.pamasvendidosxsucursalBindingSource.DataSource = this.dSConsulta1;
            // 
            // dSConsulta1
            // 
            this.dSConsulta1.DataSetName = "DSConsulta1";
            this.dSConsulta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.DocumentMapWidth = 1;
            this.reportViewer1.Font = new System.Drawing.Font("Rubik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "Consulta1";
            reportDataSource1.Value = this.pamasvendidosxsucursalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmaceutica.REPORTES.ConsultasDiseño.Reporte1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 257);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1738, 476);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 125;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.BackColor = System.Drawing.Color.Teal;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(1594, 172);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(179, 62);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(202, 113);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(275, 22);
            this.dtpFechaInicio.TabIndex = 3;
            this.dtpFechaInicio.Value = new System.DateTime(2020, 10, 27, 19, 48, 0, 0);
            this.dtpFechaInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaInicio_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1098, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sucursal:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFin.Location = new System.Drawing.Point(1266, 111);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(275, 22);
            this.dtpFechaFin.TabIndex = 7;
            this.dtpFechaFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaFin_KeyPress);
            // 
            // pa_mas_vendidos_x_sucursalTableAdapter
            // 
            this.pa_mas_vendidos_x_sucursalTableAdapter.ClearBeforeFill = true;
            // 
            // sPMOSTRARSUCURSALESBindingSource
            // 
            this.sPMOSTRARSUCURSALESBindingSource.DataMember = "SP_MOSTRAR_SUCURSALES";
            this.sPMOSTRARSUCURSALESBindingSource.DataSource = this.dSConsulta1;
            // 
            // sP_MOSTRAR_SUCURSALESTableAdapter
            // 
            this.sP_MOSTRAR_SUCURSALESTableAdapter.ClearBeforeFill = true;
            // 
            // cboSucursal
            // 
            this.cboSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(153, 210);
            this.cboSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(275, 24);
            this.cboSucursal.TabIndex = 8;
            this.cboSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSucursal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "PRODUCTO MAS VENDIDO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1804, 849);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboSucursal);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Producto Mas Vendido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pamasvendidosxsucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARSUCURSALESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pamasvendidosxsucursalBindingSource;
        private FuenteDatos.DSConsulta1 dSConsulta1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private FuenteDatos.DSConsulta1TableAdapters.pa_mas_vendidos_x_sucursalTableAdapter pa_mas_vendidos_x_sucursalTableAdapter;
        private System.Windows.Forms.BindingSource sPMOSTRARSUCURSALESBindingSource;
        private FuenteDatos.DSConsulta1TableAdapters.SP_MOSTRAR_SUCURSALESTableAdapter sP_MOSTRAR_SUCURSALESTableAdapter;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label label4;
    }
}