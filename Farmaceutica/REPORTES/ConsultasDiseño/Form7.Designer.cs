namespace Farmaceutica.REPORTES.ConsultasDiseño
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.consulta7BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dSConsulta1 = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1();
            this.consulta7BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.consulta7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consulta7TableAdapter = new Farmaceutica.REPORTES.FuenteDatos.DSConsulta1TableAdapters.Consulta7TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.cboTrimestre = new System.Windows.Forms.ComboBox();
            this.Trimestre = new System.Windows.Forms.Label();
            this.Consulta6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consulta7BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta7BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // consulta7BindingSource2
            // 
            this.consulta7BindingSource2.DataMember = "Consulta7";
            this.consulta7BindingSource2.DataSource = this.dSConsulta1;
            // 
            // dSConsulta1
            // 
            this.dSConsulta1.DataSetName = "DSConsulta1";
            this.dSConsulta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulta7BindingSource1
            // 
            this.consulta7BindingSource1.DataMember = "Consulta7";
            this.consulta7BindingSource1.DataSource = this.dSConsulta1;
            // 
            // consulta7BindingSource
            // 
            this.consulta7BindingSource.DataMember = "Consulta7";
            this.consulta7BindingSource.DataSource = this.dSConsulta1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Font = new System.Drawing.Font("Rubik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "Consulta7";
            reportDataSource1.Value = this.consulta7BindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmaceutica.REPORTES.ConsultasDiseño.Reporte7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(33, 119);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1736, 577);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 125;
            // 
            // consulta7TableAdapter
            // 
            this.consulta7TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1581, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboTrimestre
            // 
            this.cboTrimestre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTrimestre.FormattingEnabled = true;
            this.cboTrimestre.Location = new System.Drawing.Point(161, 63);
            this.cboTrimestre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTrimestre.Name = "cboTrimestre";
            this.cboTrimestre.Size = new System.Drawing.Size(249, 24);
            this.cboTrimestre.TabIndex = 2;
            this.cboTrimestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTrimestre_KeyPress);
            // 
            // Trimestre
            // 
            this.Trimestre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trimestre.AutoSize = true;
            this.Trimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trimestre.Location = new System.Drawing.Point(29, 63);
            this.Trimestre.Name = "Trimestre";
            this.Trimestre.Size = new System.Drawing.Size(90, 20);
            this.Trimestre.TabIndex = 3;
            this.Trimestre.Text = "Trimestre";
            // 
            // Consulta6BindingSource
            // 
            this.Consulta6BindingSource.DataMember = "Consulta6";
            this.Consulta6BindingSource.DataSource = this.dSConsulta1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Obra Social mas Recurrente";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1804, 849);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trimestre);
            this.Controls.Add(this.cboTrimestre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.Text = "Obra Social mas Recurrente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consulta7BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsulta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta7BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource consulta7BindingSource;
        private FuenteDatos.DSConsulta1 dSConsulta1;
        private FuenteDatos.DSConsulta1TableAdapters.Consulta7TableAdapter consulta7TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboTrimestre;
        private System.Windows.Forms.Label Trimestre;
        private System.Windows.Forms.BindingSource Consulta6BindingSource;
        private System.Windows.Forms.BindingSource consulta7BindingSource1;
        private System.Windows.Forms.BindingSource consulta7BindingSource2;
        private System.Windows.Forms.Label label1;
    }
}