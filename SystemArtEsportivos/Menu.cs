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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            

        }

        public void AbrirNovaJanela(object abrirnovajanela)
        {       
            if (this.pnConteudo.Controls.Count > 0)
                this.pnConteudo.Controls.RemoveAt(0);
            Form tela = abrirnovajanela as Form;
            tela.TopLevel = false;
            tela.Dock = DockStyle.Left;
            this.pnConteudo.Controls.Add(tela);
            this.pnConteudo.Tag = tela;
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Funcionario());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
           
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pnConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Cliente());
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Produto());
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Pedido());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo Sair", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
