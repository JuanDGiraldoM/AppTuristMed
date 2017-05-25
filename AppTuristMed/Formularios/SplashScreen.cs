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
            oleDbConnection.Open();
            backgroundWorker.ReportProgress(10);
            oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
            oleDbDataAdapter.SelectCommand.CommandText = "select count(*) from Hospitales";
            if (oleDbDataAdapter.SelectCommand.ExecuteScalar().ToString().Equals("0"))
            {
                sync.Post(a =>
                {
                    lbl_act.Visible = true;
                }, null);
                Program.proxy.ActualizarHospitales();
            }
            backgroundWorker.ReportProgress(25);
            Thread.Sleep(100);
            oleDbDataAdapter.SelectCommand.CommandText = "select count(*) from Estaciones";
            if (oleDbDataAdapter.SelectCommand.ExecuteScalar().ToString().Equals("0"))
            {
                sync.Post(a =>
                {
                    lbl_act.Visible = true;
                }, null);
                Program.proxy.ActualizarEstaciones();
            }
            backgroundWorker.ReportProgress(50);
            Thread.Sleep(100);
            oleDbDataAdapter.SelectCommand.CommandText = "select count(*) from Wifi";
            if (oleDbDataAdapter.SelectCommand.ExecuteScalar().ToString().Equals("0"))
            {
                sync.Post(a =>
                {
                    lbl_act.Visible = true;
                }, null);
                Program.proxy.ActualizarZonasWiFi();
            }
            backgroundWorker.ReportProgress(75);
            Thread.Sleep(100);
            oleDbDataAdapter.SelectCommand.CommandText = "select count(*) from Hoteles";
            if (oleDbDataAdapter.SelectCommand.ExecuteScalar().ToString().Equals("0"))
            {
                sync.Post(a =>
                {
                    lbl_act.Visible = true;
                }, null);
                Program.proxy.ActualizarHoteles();
            }
            backgroundWorker.ReportProgress(100);
            Thread.Sleep(100);
            oleDbConnection.Close();                     
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
    }
}
