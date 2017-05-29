using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Threading;

namespace AppTuristMed.Formularios
{
    public partial class SplashScreen : Form
    {
        SynchronizationContext sync;

        public SplashScreen()
        {
            InitializeComponent();
            sync = SynchronizationContext.Current;
            ClientSize = BackgroundImage.Size;
            BackColor = Color.Black;
            TransparencyKey = Color.Black;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
            oleDbConnection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Program.ruta + @"\DataBase.accdb";
            if (!File.Exists(oleDbConnection.DataSource))
            {
                MessageBox.Show(this, "No se ha encontrado la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                OpenFileDialog ventana = new OpenFileDialog();
                ventana.Filter = "Data Base Files (*accdb) | *.accdb";
                ventana.Title = "Seleccionar Base de Datos";
                ventana.InitialDirectory = Program.ruta;

                if (ventana.ShowDialog() == DialogResult.OK && ventana.ToString() != "")
                    File.Copy(ventana.FileName, Program.ruta + @"\DataBase.accdb");
                else
                {
                    MessageBox.Show(this, "No se puede continuar sin Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            Program.proxy.Connection.ConnectionString = oleDbConnection.ConnectionString;
            
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            backgroundWorker.ReportProgress(10);

            if (ConsultarNumRegistros("select count(*) from Hospitales") == 0)
            {
                sync.Post(a =>
                {
                    lbl_act.Visible = true;
                }, null);
                Program.proxy.ActualizarHospitales();
            }
            backgroundWorker.ReportProgress(25);
            Thread.Sleep(100);
            if (ConsultarNumRegistros("select count(*) from Estaciones") == 0)
            {
                sync.Post(a =>
                {
                    lbl_act.Visible = true;
                }, null);
                Program.proxy.ActualizarEstaciones();
            }
            backgroundWorker.ReportProgress(50);
            Thread.Sleep(100);
            if (ConsultarNumRegistros("select count(*) from Wifi") == 0)
            {
                sync.Post(a =>
                {
                    lbl_act.Visible = true;
                }, null);
                Program.proxy.ActualizarZonasWiFi();
            }
            backgroundWorker.ReportProgress(75);
            Thread.Sleep(100);
            if (ConsultarNumRegistros("select count(*) from Hoteles") == 0)
            {
                sync.Post(a =>
                {
                    lbl_act.Visible = true;
                }, null);
                Program.proxy.ActualizarHoteles();
            }
            backgroundWorker.ReportProgress(100);
            Thread.Sleep(100);                 
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if(e.ProgressPercentage == 100)
            {
                sync.Post(a =>
                {
                    lbl_act.Visible = false;
                    new FrmMain(oleDbConnection.ConnectionString).Show();
                    Hide();

                }, null);
            }
        }

        private double ConsultarNumRegistros(string query)
        {
            double numRegistros = 0;
            oleDbConnection.Open();
            oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
            oleDbDataAdapter.SelectCommand.CommandText = query;
            numRegistros = double.Parse(oleDbDataAdapter.SelectCommand.ExecuteScalar().ToString());
            oleDbConnection.Close();
            return numRegistros;
        }
    }
}
