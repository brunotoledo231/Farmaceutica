namespace Farmaceutica
{
    partial class FrmLoginGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginGerente));
            this.txtUsuarioGerente = new System.Windows.Forms.TextBox();
            this.lblUsuarioGerente = new System.Windows.Forms.Label();
            this.txtContraGerente = new System.Windows.Forms.TextBox();
            this.lblContraseniaGerente = new System.Windows.Forms.Label();
            this.btnInicioGerente = new System.Windows.Forms.Button();
            this.panelGerente = new System.Windows.Forms.Panel();
            this.panelGerente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuarioGerente
            // 
            this.txtUsuarioGerente.Location = new System.Drawing.Point(787, 343);
            this.txtUsuarioGerente.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioGerente.Name = "txtUsuarioGerente";
            this.txtUsuarioGerente.Size = new System.Drawing.Size(339, 22);
            this.txtUsuarioGerente.TabIndex = 4;
            // 
            // lblUsuarioGerente
            // 
            this.lblUsuarioGerente.AutoSize = true;
            this.lblUsuarioGerente.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioGerente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuarioGerente.Location = new System.Drawing.Point(624, 345);
            this.lblUsuarioGerente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioGerente.Name = "lblUsuarioGerente";
            this.lblUsuarioGerente.Size = new System.Drawing.Size(96, 20);
            this.lblUsuarioGerente.TabIndex = 3;
            this.lblUsuarioGerente.Text = "GERENTE";
            // 
            // txtContraGerente
            // 
            this.txtContraGerente.Location = new System.Drawing.Point(787, 412);
            this.txtContraGerente.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraGerente.Name = "txtContraGerente";
            this.txtContraGerente.Size = new System.Drawing.Size(339, 22);
            this.txtContraGerente.TabIndex = 6;
            this.txtContraGerente.TextChanged += new System.EventHandler(this.txtContraGerente_TextChanged);
            this.txtContraGerente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraGerente_KeyPress);
            // 
            // lblContraseniaGerente
            // 
            this.lblContraseniaGerente.AutoSize = true;
            this.lblContraseniaGerente.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseniaGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseniaGerente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContraseniaGerente.Location = new System.Drawing.Point(624, 417);
            this.lblContraseniaGerente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseniaGerente.Name = "lblContraseniaGerente";
            this.lblContraseniaGerente.Size = new System.Drawing.Size(139, 20);
            this.lblContraseniaGerente.TabIndex = 5;
            this.lblContraseniaGerente.Text = "CONTRASENIA";
            // 
            // btnInicioGerente
            // 
            this.btnInicioGerente.BackColor = System.Drawing.Color.Teal;
            this.btnInicioGerente.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioGerente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicioGerente.Location = new System.Drawing.Point(947, 466);
            this.btnInicioGerente.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicioGerente.Name = "btnInicioGerente";
            this.btnInicioGerente.Size = new System.Drawing.Size(179, 62);
            this.btnInicioGerente.TabIndex = 7;
            this.btnInicioGerente.Text = "Iniciar Sesion";
            this.btnInicioGerente.UseVisualStyleBackColor = false;
            this.btnInicioGerente.Click += new System.EventHandler(this.btnInicioGerente_Click);
            this.btnInicioGerente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnInicioGerente_KeyPress);
            // 
            // panelGerente
            // 
            this.panelGerente.BackColor = System.Drawing.Color.Transparent;
            this.panelGerente.Controls.Add(this.btnInicioGerente);
            this.panelGerente.Controls.Add(this.txtContraGerente);
            this.panelGerente.Controls.Add(this.lblContraseniaGerente);
            this.panelGerente.Controls.Add(this.txtUsuarioGerente);
            this.panelGerente.Controls.Add(this.lblUsuarioGerente);
            this.panelGerente.Location = new System.Drawing.Point(1, 0);
            this.panelGerente.Name = "panelGerente";
            this.panelGerente.Size = new System.Drawing.Size(1413, 900);
            this.panelGerente.TabIndex = 8;
            this.panelGerente.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGerente_Paint);
            // 
            // FrmLoginGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1413, 900);
            this.Controls.Add(this.panelGerente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoginGerente";
            this.Text = "Farmaceutica/LoginGerente";
            this.Load += new System.EventHandler(this.FrmLoginGerente_Load);
            this.panelGerente.ResumeLayout(false);
            this.panelGerente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioGerente;
        private System.Windows.Forms.Label lblUsuarioGerente;
        private System.Windows.Forms.TextBox txtContraGerente;
        private System.Windows.Forms.Label lblContraseniaGerente;
        private System.Windows.Forms.Button btnInicioGerente;
        private System.Windows.Forms.Panel panelGerente;
    }
}