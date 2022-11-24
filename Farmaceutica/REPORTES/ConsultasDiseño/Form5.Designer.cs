namespace Farmaceutica.REPORTES.ConsultasDiseño
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.sPConsulta5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSConsulta1 = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSConsulta1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Consulta5TableAdapter = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1TableAdapters.SP_Consulta5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsulta5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPConsulta5BindingSource
            // 
            this.sPConsulta5BindingSource.DataMember = "SP_Consulta5";
            this.sPConsulta5BindingSource.DataSource = this.dSConsulta1;
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
            this.reportViewer1.Font = new System.Drawing.Font("Rubik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "Consulta5";
            reportDataSource1.Value = this.sPConsulta5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmaceutica.REPORTES.ConsultasDiseño.Reporte5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1822, 896);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 125;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dSConsulta1BindingSource
            // 
            this.dSConsulta1BindingSource.DataSource = this.dSConsulta1;
            this.dSConsulta1BindingSource.Position = 0;
            // 
            // sP_Consulta5TableAdapter
            // 
            this.sP_Consulta5TableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 849);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Destinatario de ofertas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPConsulta5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FuenteDatos.DSConsulta1 dSConsulta1;
        private System.Windows.Forms.BindingSource dSConsulta1BindingSource;
        private System.Windows.Forms.BindingSource sPConsulta5BindingSource;
        private FuenteDatos.DSConsulta1TableAdapters.SP_Consulta5TableAdapter sP_Consulta5TableAdapter;
    }
}