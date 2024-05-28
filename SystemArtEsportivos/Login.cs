using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        Conexao con = new Conexao();
        //MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dados;


        public Login()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Usuario e senha inválidos");
            }
            else
            {
                try
                {
                    string sql = "select * from tbfuncionario where usuario=@user and  senha=@senha";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsuario.Text;
                    cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtSenha.Text;
                    dados = cmd.ExecuteReader();

                    if (dados.HasRows)
                    {
                        Splash splash = new Splash();
                        splash.Show();
                        MessageBox.Show("Seja bem Vindo ao sistema");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario e senha invalidos");
                        txtUsuario.Clear();
                        txtSenha.Clear();
                        txtUsuario.Focus();
                    }



                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    con.DesConnectarBD();
                }
            }
            }       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
