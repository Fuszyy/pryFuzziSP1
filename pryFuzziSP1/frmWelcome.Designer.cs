namespace pryFuzziSP1
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.pbxLogoW = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAcceptW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoW)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogoW
            // 
            this.pbxLogoW.Image = global::pryFuzziSP1.Properties.Resources.SinteplastLogo__1_;
            this.pbxLogoW.Location = new System.Drawing.Point(130, 104);
            this.pbxLogoW.Name = "pbxLogoW";
            this.pbxLogoW.Size = new System.Drawing.Size(148, 72);
            this.pbxLogoW.TabIndex = 9;
            this.pbxLogoW.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(73, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(269, 32);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Bienvenido al sistema.";
            // 
            // btnAcceptW
            // 
            this.btnAcceptW.Location = new System.Drawing.Point(168, 205);
            this.btnAcceptW.Name = "btnAcceptW";
            this.btnAcceptW.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptW.TabIndex = 11;
            this.btnAcceptW.Text = "Aceptar";
            this.btnAcceptW.UseVisualStyleBackColor = true;
            this.btnAcceptW.Click += new System.EventHandler(this.btnAcceptW_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 240);
            this.Controls.Add(this.btnAcceptW);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pbxLogoW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWelcome";
            this.Text = "Bienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogoW;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAcceptW;
    }
}