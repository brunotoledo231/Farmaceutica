namespace Farmaceutica.REPORTES.ConsultasDiseño
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.sPConsulta2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSConsulta1 = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_Consulta2TableAdapter = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1TableAdapters.SP_Consulta2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsulta2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // sPConsulta2BindingSource
            // 
            this.sPConsulta2BindingSource.DataMember = "SP_Consulta2";
            this.sPConsulta2BindingSource.DataSource = this.dSConsulta1;
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
            reportDataSource1.Name = "Consulta2";
            reportDataSource1.Value = this.sPConsulta2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmaceutica.REPORTES.ConsultasDiseño.Reporte2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1804, 849);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 125;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sP_Consulta2TableAdapter
            // 
            this.sP_Consulta2TableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1804, 849);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Empleado del semestre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPConsulta2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FuenteDatos.DSConsulta1 dSConsulta1;
        private System.Windows.Forms.BindingSource sPConsulta2BindingSource;
        private FuenteDatos.DSConsulta1TableAdapters.SP_Consulta2TableAdapter sP_Consulta2TableAdapter;
    }
}