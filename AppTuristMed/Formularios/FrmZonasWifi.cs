using System;
using System.Data;
using System.Windows.Forms;

namespace AppTuristMed.Formularios
{
    public partial class FrmZonasWifi : Form
    {
        private FrmMain main;

        public FrmZonasWifi(FrmMain main, string conexion)
        {
            InitializeComponent();
            this.main = main;
            oleDbConnection.ConnectionString = conexion;
        }

        private void FrmZonasWifi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            main.Show();
        }

        private void FrmZonasWifi_Load(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            oleDbDataAdapter.SelectCommand.CommandText = "select * from Wifi";
            oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
            DataTable datos = new DataTable();
            oleDbDataAdapter.Fill(datos);
            table.DataSource = datos;
            oleDbConnection.Close();
        }
    }
}
