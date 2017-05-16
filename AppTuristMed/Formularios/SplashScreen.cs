using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Threading;

namespace AppTuristMed.Formularios
{
    public partial class SplashScreen : Form
    {
        private int time { get; set; }

        public SplashScreen()
        {
            InitializeComponent();
            ClientSize = BackgroundImage.Size;
            BackColor = Color.Black;
            TransparencyKey = Color.Black;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            time = 5;
            timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
                time--;
            else
            {
                if (!Program.InternetAccess())
                    MessageBox.Show(this, "No hay acceso a Internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Thread thread = new Thread(VerificacionDataBase);
                    lbl_act.Visible = true;
                    thread.Start();
                    thread.Join();                    
                }
                timer1.Stop();
                new FrmMain(oleDbConnection.ConnectionString).Show();
                Hide();
            }
        }

        private void VerificacionDataBase()
        {
            oleDbConnection.Open();
            oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
            oleDbDataAdapter.SelectCommand.CommandText = "select * from Hoteles";
            if (oleDbDataAdapter.SelectCommand.ExecuteNonQuery() == 0)
                Program.proxy.ActualizarHoteles();
            oleDbDataAdapter.SelectCommand.CommandText = "select * from Wifi";
            if (oleDbDataAdapter.SelectCommand.ExecuteNonQuery() == 0)
                Program.proxy.ActualizarZonasWiFi();
            oleDbDataAdapter.SelectCommand.CommandText = "select * from Hospitales";
            if (oleDbDataAdapter.SelectCommand.ExecuteNonQuery() == 0)
                Program.proxy.ActualizarHospitales();
            oleDbDataAdapter.SelectCommand.CommandText = "select * from Estaciones";
            if(oleDbDataAdapter.SelectCommand.ExecuteNonQuery() == 0)
                Program.proxy.ActualizarEstaciones();
            oleDbConnection.Close();
        }
    }
}
