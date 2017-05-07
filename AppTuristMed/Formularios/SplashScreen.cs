using System;
using System.Windows.Forms;
using System.Drawing;

namespace AppTuristMed.Formularios
{
    public partial class SplashScreen : Form
    {
        public int time { get; set; }

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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
                time--;

            else
            {
                timer1.Stop();
                new FrmMain().Show();
                Hide();
            }
        }
    }
}
