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
    public partial class Pedido : Form
    {

        //instanciando o BD 
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public Pedido()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //MÉTODO habilita campos
        private void habilitaCampos()
        {
            txtCPFCli.Enabled = true;
            txtCodProd.Enabled = true;
            txtQtd.Enabled = true;

            btnNovo.Enabled = false;
            txtCPFCli.Focus();
        }

        //MÉTODO limpa campos
        private void limpaCampos()
        {
            txtCodProd.Clear();
            txtQtd.Clear();
        }

        private void AbrirCliente(Form abrirnovajanela, Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                control.Visible = false;
            }

            // Adiciona a nova janela ao painel
            abrirnovajanela.TopLevel = false;
            abrirnovajanela.Dock = DockStyle.Fill;
            panel.Controls.Add(abrirnovajanela);
            panel.Tag = abrirnovajanela;
            abrirnovajanela.Show();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {

        }

        private void txtCPFCli_TextChanged(object sender, EventArgs e)
        {

            if (txtCPFCli.Text.Length == 11)
            {
                string sql = "Call spSelect_CPF(@CPF);";
                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                cmd.Parameters.Add("@CPF", MySqlDbType.Decimal).Value = decimal.Parse(txtCPFCli.Text);

                object resultado = cmd.ExecuteScalar();


                if (resultado != null)
                {
                    string msg = resultado.ToString();
                    DialogResult result = MessageBox.Show("Cliente não cadastrado. Deseja cadastrar?", "Cadastro de Cliente", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        AbrirCliente(new Cliente(), this.pnCadastros);
                }
            }
            else if((txtCPFCli.Text.Length > 11))
            {
                MessageBox.Show("Digite um código com somente 14 digitos");
            }
        }

        private void lblCPFcli_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //chamando 
            dgvPedidos.DataSource = null; //limpa o 
            txtCPFCli.Clear();
            limpaCampos();
            habilitaCampos();
            lblTotal.Text = "Total: R$ 0";
        }

        //BOTÃO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            

        }
       

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //VERIFICA OS CAMPOS SE ESTÃO VAZIOS
            if (txtCPFCli.Text == "")
            {
                MessageBox.Show("Preencha o código do funcionário");
                txtCPFCli.Focus();
            }
            else if (txtCodFunc.Text == "")
            {
                MessageBox.Show("Preencha o CPF do cliente");
                txtCodFunc.Focus();
            }

            else if (txtCodProd.Text == "")
            {
                MessageBox.Show("Digite o código do produto");
                txtCodProd.Focus();
            }
            else if (txtQtd.Text == "")
            {
                MessageBox.Show("Digite a quantidade do produto");
                txtQtd.Focus();
            }
            else
            {//tratamento de erro 
                try
                {
                    int vCod = int.Parse(txtCodFunc.Text);
                    decimal vCPFCli = decimal.Parse(txtCPFCli.Text);

                    //VARIAVEI SQL QUE RECEBE O INSERT(VAI INSERIR OS DADOS NO BANCO com imagem)
                    string sql = "Call spInsert_tbItemPedido(@codFunc, @CPF, @codBarras, @qtd);";

                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD()); //Identifica comandos mySql no c#
                    cmd.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = vCod; // Cod do funcionário
                    cmd.Parameters.Add("@CPF", MySqlDbType.Decimal).Value = vCPFCli; //CPF do cliente 
                    cmd.Parameters.Add("@codBarras", MySqlDbType.Decimal).Value = decimal.Parse(txtCodProd.Text);//Cod Prod
                    cmd.Parameters.Add("@qtd", MySqlDbType.Int32).Value = int.Parse(txtQtd.Text);// qtd

                    cmd.ExecuteNonQuery();//inserindo
                    

                    sql = "Call Select_total_tbPedido(@CPF)";
                    cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@CPF", MySqlDbType.Decimal).Value = vCPFCli;

                    lblTotal.Text = "Total: R$ " + cmd.ExecuteScalar().ToString();

                    limpaCampos();

                    txtCodFunc.Enabled = false;
                    txtCPFCli.Enabled = false;

                    sql = "Call spSelect_tbItemPedido(@CPF);";
                    cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@CPF", MySqlDbType.Decimal).Value = vCPFCli;

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    dgvPedidos.DataSource = dt;

                    con.DesConnectarBD();//DESCONECTA DO BANCO DE DADOS
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void lblCodProd_Click(object sender, EventArgs e)
        {

        }

        private void lblQtd_Click(object sender, EventArgs e)
        {

        }

        private void txtCodProd_TextChanged(object sender, EventArgs e)
        {
            if (txtCodProd.Text.Length == 14)
            {
                string sql = "Call spSelect_CodBarras(@codBarras);";
                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                cmd.Parameters.Add("@codBarras", MySqlDbType.Decimal).Value = decimal.Parse(txtCodProd.Text);

                object resultado = cmd.ExecuteScalar();


                if (resultado != null)
                {
                    string msg = resultado.ToString();
                    MessageBox.Show(msg);

                }
            }
        }
    }
  }
