namespace AppTuristMed.Formularios
{
    partial class FrmZonasWifi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZonasWifi));
            this.table = new System.Windows.Forms.DataGridView();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(611, 357);
            this.table.TabIndex = 0;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Wifi.*\r\nFROM            Wifi";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Wifi` (`Comuna`, `Barrio`, `Sitio`, `Direccion`, `Ubicacion`) VALUES" +
    " (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Comuna", System.Data.OleDb.OleDbType.VarWChar, 0, "Comuna"),
            new System.Data.OleDb.OleDbParameter("Barrio", System.Data.OleDb.OleDbType.VarWChar, 0, "Barrio"),
            new System.Data.OleDb.OleDbParameter("Sitio", System.Data.OleDb.OleDbType.VarWChar, 0, "Sitio"),
            new System.Data.OleDb.OleDbParameter("Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, "Direccion"),
            new System.Data.OleDb.OleDbParameter("Ubicacion", System.Data.OleDb.OleDbType.VarWChar, 0, "Ubicacion")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Comuna", System.Data.OleDb.OleDbType.VarWChar, 0, "Comuna"),
            new System.Data.OleDb.OleDbParameter("Barrio", System.Data.OleDb.OleDbType.VarWChar, 0, "Barrio"),
            new System.Data.OleDb.OleDbParameter("Sitio", System.Data.OleDb.OleDbType.VarWChar, 0, "Sitio"),
            new System.Data.OleDb.OleDbParameter("Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, "Direccion"),
            new System.Data.OleDb.OleDbParameter("Ubicacion", System.Data.OleDb.OleDbType.VarWChar, 0, "Ubicacion"),
            new System.Data.OleDb.OleDbParameter("Original_Id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Comuna", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Comuna", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Comuna", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Comuna", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Barrio", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Barrio", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Barrio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Barrio", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Sitio", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sitio", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Sitio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sitio", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Direccion", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Ubicacion", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Ubicacion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Comuna", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Comuna", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Comuna", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Comuna", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Barrio", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Barrio", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Barrio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Barrio", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Sitio", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sitio", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Sitio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sitio", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Direccion", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Ubicacion", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Ubicacion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter
            // 
            this.oleDbDataAdapter.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Wifi", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("Comuna", "Comuna"),
                        new System.Data.Common.DataColumnMapping("Barrio", "Barrio"),
                        new System.Data.Common.DataColumnMapping("Sitio", "Sitio"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion")})});
            this.oleDbDataAdapter.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbConnection
            // 
            this.oleDbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bin\\Debug\\Database." +
    "accdb";
            // 
            // FrmZonasWifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 381);
            this.Controls.Add(this.table);
            this.Name = "FrmZonasWifi";
            this.Text = "FrmZonasWifi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmZonasWifi_FormClosed);
            this.Load += new System.EventHandler(this.FrmZonasWifi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter;
    }
}