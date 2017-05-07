using System.Windows.Forms;

namespace AppTuristMed
{
    public partial class FrmMain : Form
    {
        string ruta = Application.StartupPath;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void archivoToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
