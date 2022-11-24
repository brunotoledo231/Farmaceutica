namespace Farmaceutica
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblCodEmpleado = new System.Windows.Forms.Label();
            this.lblCodGerente = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnInicioEmpleado = new System.Windows.Forms.Button();
            this.btnInicioGerente = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblIndexEmpleado = new System.Windows.Forms.Label();
            this.lblIndexSucursal = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboSucursalLogin = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodEmpleado
            // 
            this.lblCodEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodEmpleado.AutoSize = true;
            this.lblCodEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblCodEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodEmpleado.Location = new System.Drawing.Point(521, 346);
            this.lblCodEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodEmpleado.Name = "lblCodEmpleado";
            this.lblCodEmpleado.Size = new System.Drawing.Size(91, 20);
            this.lblCodEmpleado.TabIndex = 0;
            this.lblCodEmpleado.Text = "USUARIO";
            this.lblCodEmpleado.Click += new System.EventHandler(this.lblCodEmpleado_Click);
            // 
            // lblCodGerente
            // 
            this.lblCodGerente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodGerente.AutoSize = true;
            this.lblCodGerente.BackColor = System.Drawing.Color.Transparent;
            this.lblCodGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodGerente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodGerente.Location = new System.Drawing.Point(521, 426);
            this.lblCodGerente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodGerente.Name = "lblCodGerente";
            this.lblCodGerente.Size = new System.Drawing.Size(139, 20);
            this.lblCodGerente.TabIndex = 1;
            this.lblCodGerente.Text = "CONTRASENIA";
            this.lblCodGerente.Click += new System.EventHandler(this.lblCodGerente_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(684, 344);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(339, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContra
            // 
            this.txtContra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContra.Location = new System.Drawing.Point(684, 421);
            this.txtContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(339, 20);
            this.txtContra.TabIndex = 3;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
            // 
            // btnInicioEmpleado
            // 
            this.btnInicioEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicioEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btnInicioEmpleado.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicioEmpleado.Location = new System.Drawing.Point(844, 480);
            this.btnInicioEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicioEmpleado.Name = "btnInicioEmpleado";
            this.btnInicioEmpleado.Size = new System.Drawing.Size(179, 62);
            this.btnInicioEmpleado.TabIndex = 4;
            this.btnInicioEmpleado.Text = "Iniciar Sesion";
            this.btnInicioEmpleado.UseVisualStyleBackColor = false;
            this.btnInicioEmpleado.Click += new System.EventHandler(this.btnInicioEmpleado_Click);
            // 
            // btnInicioGerente
            // 
            this.btnInicioGerente.BackColor = System.Drawing.Color.Teal;
            this.btnInicioGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioGerente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicioGerente.Location = new System.Drawing.Point(530, 358);
            this.btnInicioGerente.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicioGerente.MaximumSize = new System.Drawing.Size(100, 100);
            this.btnInicioGerente.Name = "btnInicioGerente";
            this.btnInicioGerente.Size = new System.Drawing.Size(100, 0);
            this.btnInicioGerente.TabIndex = 5;
            this.btnInicioGerente.Text = "Iniciar Sesion";
            this.btnInicioGerente.UseVisualStyleBackColor = false;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.lblIndexEmpleado);
            this.panelLogin.Controls.Add(this.lblIndexSucursal);
            this.panelLogin.Controls.Add(this.lblU);
            this.panelLogin.Controls.Add(this.lblS);
            this.panelLogin.Controls.Add(this.cboUsuario);
            this.panelLogin.Controls.Add(this.cboSucursalLogin);
            this.panelLogin.Controls.Add(this.lblSucursal);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.btnInicioGerente);
            this.panelLogin.Controls.Add(this.btnInicioEmpleado);
            this.panelLogin.Controls.Add(this.txtContra);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.lblCodGerente);
            this.panelLogin.Controls.Add(this.lblCodEmpleado);
            this.panelLogin.Location = new System.Drawing.Point(-1, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1413, 900);
            this.panelLogin.TabIndex = 6;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // lblIndexEmpleado
            // 
            this.lblIndexEmpleado.AutoSize = true;
            this.lblIndexEmpleado.Location = new System.Drawing.Point(238, 83);
            this.lblIndexEmpleado.Name = "lblIndexEmpleado";
            this.lblIndexEmpleado.Size = new System.Drawing.Size(41, 15);
            this.lblIndexEmpleado.TabIndex = 18;
            this.lblIndexEmpleado.Text = "label1";
            this.lblIndexEmpleado.Visible = false;
            // 
            // lblIndexSucursal
            // 
            this.lblIndexSucursal.AutoSize = true;
            this.lblIndexSucursal.Location = new System.Drawing.Point(238, 43);
            this.lblIndexSucursal.Name = "lblIndexSucursal";
            this.lblIndexSucursal.Size = new System.Drawing.Size(41, 15);
            this.lblIndexSucursal.TabIndex = 17;
            this.lblIndexSucursal.Text = "label1";
            this.lblIndexSucursal.Visible = false;
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Location = new System.Drawing.Point(97, 83);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(41, 15);
            this.lblU.TabIndex = 16;
            this.lblU.Text = "label1";
            this.lblU.Visible = false;
            this.lblU.Click += new System.EventHandler(this.lblU_Click);
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(97, 43);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(41, 15);
            this.lblS.TabIndex = 15;
            this.lblS.Text = "label1";
            this.lblS.Visible = false;
            this.lblS.Click += new System.EventHandler(this.lblS_Click_1);
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(684, 343);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(338, 21);
            this.cboUsuario.TabIndex = 14;
            this.cboUsuario.SelectedIndexChanged += new System.EventHandler(this.cboUsuario_SelectedIndexChanged_1);
            // 
            // cboSucursalLogin
            // 
            this.cboSucursalLogin.FormattingEnabled = true;
            this.cboSucursalLogin.Location = new System.Drawing.Point(683, 254);
            this.cboSucursalLogin.Margin = new System.Windows.Forms.Padding(4);
            this.cboSucursalLogin.Name = "cboSucursalLogin";
            this.cboSucursalLogin.Size = new System.Drawing.Size(338, 21);
            this.cboSucursalLogin.TabIndex = 13;
            this.cboSucursalLogin.SelectedIndexChanged += new System.EventHandler(this.cboSucursalLogin_SelectedIndexChanged_1);
            // 
            // lblSucursal
            // 
            this.lblSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.BackColor = System.Drawing.Color.Transparent;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSucursal.Location = new System.Drawing.Point(525, 257);
            this.lblSucursal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(108, 20);
            this.lblSucursal.TabIndex = 12;
            this.lblSucursal.Text = "SUCURSAL";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(520, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "USUARIO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1412, 913);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Farmaceutica/Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodEmpleado;
        private System.Windows.Forms.Label lblCodGerente;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnInicioEmpleado;
        private System.Windows.Forms.Button btnInicioGerente;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblU;
        public System.Windows.Forms.Label lblS;
        private System.Windows.Forms.ComboBox cboUsuario;
        public System.Windows.Forms.ComboBox cboSucursalLogin;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIndexEmpleado;
        public System.Windows.Forms.Label lblIndexSucursal;
    }
}

