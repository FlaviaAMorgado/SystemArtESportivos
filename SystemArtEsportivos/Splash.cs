using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemArtEsportivos
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgrSplash.Value < 100)
            {
                pgrSplash.Value = pgrSplash.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;

                Menu menu = new Menu();
                menu.ShowDialog();
                MessageBox.Show("Seja Bem vindo ao Sistema");

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
