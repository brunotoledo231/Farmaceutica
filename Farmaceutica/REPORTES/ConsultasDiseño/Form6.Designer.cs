namespace Farmaceutica.REPORTES.ConsultasDiseño
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.consulta6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSConsulta1 = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consulta6TableAdapter = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1TableAdapters.Consulta6TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consulta6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // consulta6BindingSource
            // 
            this.consulta6BindingSource.DataMember = "Consulta6";
            this.consulta6BindingSource.DataSource = this.dSConsulta1;
            // 
            // dSConsulta1
            // 
            this.dSConsulta1.DataSetName = "DSConsulta1";
            this.dSConsulta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Rubik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "Consulta6";
            reportDataSource1.Value = this.consulta6BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmaceutica.REPORTES.ConsultasDiseño.Reporte6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1804, 849);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 125;
            // 
            // consulta6TableAdapter
            // 
            this.consulta6TableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 849);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.Text = "Premio Aniversario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consulta6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FuenteDatos.DSConsulta1 dSConsulta1;
        private System.Windows.Forms.BindingSource consulta6BindingSource;
        private FuenteDatos.DSConsulta1TableAdapters.Consulta6TableAdapter consulta6TableAdapter;
    }
}