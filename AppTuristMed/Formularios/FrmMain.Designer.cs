namespace AppTuristMed
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnWifi = new System.Windows.Forms.Button();
            this.btnEstaciones = new System.Windows.Forms.Button();
            this.btnHospitales = new System.Windows.Forms.Button();
            this.btnHoteles = new System.Windows.Forms.Button();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWifi
            // 
            this.btnWifi.Location = new System.Drawing.Point(37, 55);
            this.btnWifi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWifi.Name = "btnWifi";
            this.btnWifi.Size = new System.Drawing.Size(177, 35);
            this.btnWifi.TabIndex = 0;
            this.btnWifi.Text = "Puntos WiFi Libre";
            this.btnWifi.UseVisualStyleBackColor = true;
            this.btnWifi.Click += new System.EventHandler(this.btnWifi_Click);
            // 
            // btnEstaciones
            // 
            this.btnEstaciones.Location = new System.Drawing.Point(37, 145);
            this.btnEstaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEstaciones.Name = "btnEstaciones";
            this.btnEstaciones.Size = new System.Drawing.Size(177, 35);
            this.btnEstaciones.TabIndex = 2;
            this.btnEstaciones.Text = "Estaciones de Servicio\r\n(Gas, Gasolina y Diesel)\r\n";
            this.btnEstaciones.UseVisualStyleBackColor = true;
            this.btnEstaciones.Click += new System.EventHandler(this.btnEstaciones_Click);
            // 
            // btnHospitales
            // 
            this.btnHospitales.Location = new System.Drawing.Point(37, 100);
            this.btnHospitales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHospitales.Name = "btnHospitales";
            this.btnHospitales.Size = new System.Drawing.Size(177, 35);
            this.btnHospitales.TabIndex = 3;
            this.btnHospitales.Text = "Centros de Salud";
            this.btnHospitales.UseVisualStyleBackColor = true;
            this.btnHospitales.Click += new System.EventHandler(this.btnHospitales_Click);
            // 
            // btnHoteles
            // 
            this.btnHoteles.Location = new System.Drawing.Point(37, 191);
            this.btnHoteles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHoteles.Name = "btnHoteles";
            this.btnHoteles.Size = new System.Drawing.Size(177, 35);
            this.btnHoteles.TabIndex = 4;
            this.btnHoteles.Text = "Hoteles";
            this.btnHoteles.UseVisualStyleBackColor = true;
            this.btnHoteles.Click += new System.EventHandler(this.btnHoteles_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarBaseDeDatosToolStripMenuItem});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(63, 21);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // actualizarBaseDeDatosToolStripMenuItem
            // 
            this.actualizarBaseDeDatosToolStripMenuItem.Name = "actualizarBaseDeDatosToolStripMenuItem";
            this.actualizarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.actualizarBaseDeDatosToolStripMenuItem.Text = "Actualizar DataBase";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 259);
            this.Controls.Add(this.btnHoteles);
            this.Controls.Add(this.btnHospitales);
            this.Controls.Add(this.btnEstaciones);
            this.Controls.Add(this.btnWifi);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Turist Med";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWifi;
        private System.Windows.Forms.Button btnEstaciones;
        private System.Windows.Forms.Button btnHospitales;
        private System.Windows.Forms.Button btnHoteles;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarBaseDeDatosToolStripMenuItem;
    }
}

