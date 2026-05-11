namespace pryFuzziSP1
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.cbxMod = new System.Windows.Forms.ComboBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(75, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(156, 210);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 90);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPW
            // 
            this.txtPW.Enabled = false;
            this.txtPW.Location = new System.Drawing.Point(86, 126);
            this.txtPW.MaxLength = 10;
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '#';
            this.txtPW.Size = new System.Drawing.Size(122, 20);
            this.txtPW.TabIndex = 3;
            this.txtPW.TextChanged += new System.EventHandler(this.txtPW_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Usuario";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(14, 129);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(61, 13);
            this.lblPW.TabIndex = 2;
            this.lblPW.Text = "Contraseña";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(33, 165);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(42, 13);
            this.lblMod.TabIndex = 4;
            this.lblMod.Text = "Módulo";
            this.lblMod.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbxMod
            // 
            this.cbxMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMod.Enabled = false;
            this.cbxMod.FormattingEnabled = true;
            this.cbxMod.Items.AddRange(new object[] {
            "ADM",
            "SIST",
            "COM",
            "VTA"});
            this.cbxMod.Location = new System.Drawing.Point(86, 162);
            this.cbxMod.Name = "cbxMod";
            this.cbxMod.Size = new System.Drawing.Size(122, 21);
            this.cbxMod.TabIndex = 5;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::pryFuzziSP1.Properties.Resources.SinteplastLogo__1_;
            this.pbxLogo.Location = new System.Drawing.Point(49, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(148, 72);
            this.pbxLogo.TabIndex = 8;
            this.pbxLogo.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 244);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.cbxMod);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.ComboBox cbxMod;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}

