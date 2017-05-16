using System.Windows.Forms;

namespace AppTuristMed
{
    public partial class FrmMain : Form
    {
        string ruta = Application.StartupPath;

        public FrmMain(string conexion)
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
