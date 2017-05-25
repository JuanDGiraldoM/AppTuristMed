using AppTuristMed.Formularios;
using System.Windows.Forms;

namespace AppTuristMed
{
    public partial class FrmMain : Form
    {
        private string conexion;

        public FrmMain(string conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHospitales_Click(object sender, System.EventArgs e)
        {
            FrmHospitales frmhospitales = new FrmHospitales(this, conexion);
            frmhospitales.Show();
            Hide();
        }
    }
}
