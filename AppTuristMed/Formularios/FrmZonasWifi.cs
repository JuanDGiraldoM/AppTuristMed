using System;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;
using AppTuristMed.Clases;
using System.Collections;

namespace AppTuristMed.Formularios
{
    public partial class FrmZonasWifi : Form
    {
        private FrmMain main;
        SynchronizationContext sync;

        public FrmZonasWifi(FrmMain main, string conexion)
        {
            InitializeComponent();
            sync = SynchronizationContext.Current;
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
            table.AutoResizeColumns();
            oleDbConnection.Close();
        }

        private void OptimizarBúsquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("{0}, {1}", Program.location.Latitud, Program.location.Longitud);
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ArrayList zonas = CargarZonasWifi();

            if(Program.location != null)
            {
                sync.Post(d =>
                {
                    progressBar.Enabled = true;
                    progressBar.Visible = true;
                }, null);

                AlgoritmoGenetico algoritmo = new AlgoritmoGenetico(0.5, 0.5, 10, 100, 1000);

                Cluster[] clusters = algoritmo.Clustering(zonas, Program.location);
                Cluster cercano = null;
                double distancia = 0;
                double distancia_tmp = 0;

                foreach(Cluster cluster in clusters)
                {
                    if(!cluster.Centro.Latitud.ToString().Equals("NaN") && !cluster.Centro.Longitud.ToString().Equals("NaN"))
                    {
                        distancia_tmp = cluster.Centro.CalcularDistacia(Program.location);

                        if (distancia == 0) distancia = distancia_tmp;
                        else if (distancia_tmp < distancia)
                        {
                            distancia = distancia_tmp;
                            cercano = cluster;
                        }
                    }
                }

                foreach(ZonaWiFi zona in cercano.Registros)
                {
                    Console.WriteLine(zona.NombreSitio);
                    sync.Post(d =>
                    {
                        oleDbConnection.Open();
                        oleDbDataAdapter.SelectCommand.CommandText = "select * from Wifi where direccion = '" + zona.Direccion + "'";
                        oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
                        DataTable datos = new DataTable();
                        oleDbDataAdapter.Fill(datos);
                        table.DataSource = datos;                        
                        oleDbConnection.Close();

                    }, null);
                }

                sync.Post(d =>
                {
                    table.AutoResizeColumns();
                    progressBar.Visible = false;
                    progressBar.Enabled = false;
                }, null);
            }
            else
            {
                sync.Post(d =>
                {
                    Program.location = Ubicacion.ObtenerUbicacion();
                    if (Program.location == null)
                        MessageBox.Show("No se encuentra disponible la Ubicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        optimizarBúsquedaToolStripMenuItem.PerformClick();
                }, null);
            }
            
        }

        private ArrayList CargarZonasWifi()
        {
            ArrayList zonas = new ArrayList();
            oleDbConnection.Open();
            oleDbDataAdapter.SelectCommand.CommandText = "select * from Wifi";
            oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
            OleDbDataReader reader = oleDbDataAdapter.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                if (!reader[5].ToString().Equals(""))
                    zonas.Add(new ZonaWiFi(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()));
            }
            reader.Close();
            oleDbConnection.Close();
            return zonas;
        }
    }
}
