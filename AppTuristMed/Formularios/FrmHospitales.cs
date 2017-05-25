using System;
using System.Data;
using System.Windows.Forms;

namespace AppTuristMed.Formularios
{
    public partial class FrmHospitales : Form
    {
        private FrmMain main;
        
        public FrmHospitales(FrmMain main, string conexion)
        {
            InitializeComponent();
            this.main = main;
            oleDbConnection.ConnectionString = conexion;
        }

        private void FrmHospitales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            main.Show();
        }

        private void FrmHospitales_Load(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            oleDbDataAdapter.SelectCommand.CommandText = "select * from Hospitales";
            oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
            DataTable datos = new DataTable();
            oleDbDataAdapter.Fill(datos);
            table.DataSource = datos;
            table.AutoResizeColumns();
            oleDbConnection.Close();
        }
    }
}
