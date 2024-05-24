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
            txtCodFunc.Enabled = true;
            txtCodProd.Enabled = true;
            txtQtd.Enabled = true;
            txtValorUni.Enabled = true;
            txtValorTotal.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            txtCPFCli.Focus();
        }


        // MÉTODO desabilitar campos
        private void desabiltaCampos()
        {
            txtCPFCli.Enabled = true;
            txtCodFunc.Enabled = true;
            txtCodProd.Enabled = true;
            btnNovo.Enabled = true;
            txtQtd.Enabled = true;
            txtValorUni.Enabled = true;
            txtValorTotal.Enabled = true;


            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            txtPesquisar.Clear(); //limpa campo
            txtPesquisar.Focus();
            limpaCampos(); //chamando método
        }

        //MÉTODO limpa campos
        private void limpaCampos()
        {
            txtCPFCli.Clear();
            txtCodFunc.Clear();
            txtCodProd.Clear();
            txtQtd.Clear();
            txtValorUni.Clear();
            txtValorTotal.Clear();

            txtPesquisar.Clear();
            dgvPedidos.DataSource = null; //limpa o quadro de pesquisa
        }


        private void Pedido_Load(object sender, EventArgs e)
        {

        }

        private void txtCPFCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblValorUni_Click(object sender, EventArgs e)
        {

        }

        private void lblCPFcli_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //chamando método 
            habilitaCampos();
        }

        //BOTÃO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //VERIFICA OS CAMPOS SE ESTÃO VAZIOS
            if (txtCPFCli.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo nome");
                txtCPFCli.Focus();
            }
            else if (txtCodFunc.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Email");
                txtCodFunc.Focus();
            }

            else if (txtCodProd.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Telefone");
                txtCodProd.Focus();
            }
            else if (txtQtd.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Telefone");
                txtQtd.Focus();
            }
            else if (txtValorUni.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Telefone");
                txtValorUni.Focus();
            }
            else if (txtValorTotal.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Telefone");
                txtValorTotal.Focus();
            }
            else
            {//tratamento de erro 
                try
                {
                    //VARIAVEI SQL QUE RECEBE O INSERT(VAI INSERIR OS DADOS NO BANCO com imagem)
                    string sql = "insert into tbcliente(nome,email, telefone) values(@nome,@email,@telefone)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD()); //Identifica comandos mySql no c#
                    cmd.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = txtCPFCli.Text; //CPF do cliente
                    cmd.Parameters.Add("@codFunc", MySqlDbType.VarChar).Value = txtCodFunc.Text; // Cod do funcionário
                    cmd.Parameters.Add("@codBarras", MySqlDbType.VarChar).Value = txtCodProd.Text;//Cod Prod
                    cmd.Parameters.Add("@qtd", MySqlDbType.VarChar).Value = txtQtd.Text;// qtd
                    cmd.Parameters.Add("@preco", MySqlDbType.VarChar).Value = txtValorUni.Text;// valorUni
                    cmd.Parameters.Add("@totalPedido", MySqlDbType.VarChar).Value = txtValorTotal.Text;// Valor Total


                    cmd.ExecuteNonQuery();//inserindo
                    MessageBox.Show("Dados Cadastrados com Sucesso"); //msg de sucesso
                    limpaCampos();

                    con.DesConnectarBD();//DESCONECTA DO BANCO DE DADOS
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarPedidos();
        }

        private void carregarPedidos()
        {/*
            try
            {
                
                //começa a con com bd
                con.ConnectarBD();
                txtCodCli.Text = dgvCliente.SelectedRows[0].Cells[0].Value.ToString();  //PEGA O VALOR DO PRIMEIRO CAMPO DA TABELA(CODIGO POR EXEMPLO CASO TENHA)
                txtNome.Text = dgvCliente.SelectedRows[0].Cells[1].Value.ToString();//PEGA O O NOME E PASSAR NO DATAGRID
                txtEmail.Text = dgvCliente.SelectedRows[0].Cells[2].Value.ToString();//PEGA O EMAIL E PASSAR NO DATAGRID
                txtTelefone.Text = dgvCliente.SelectedRows[0].Cells[3].Value.ToString();// PEGA O TELEFONE E PASSAR NO DATAGRID
                //DESCONECTA O BANCO DE DADOS
                con.DesConnectarBD();

            }
            //EM CASO DÊ ALGO ERRADO  
            catch (Exception erro)
            {
                //MOSTRA A MENSAGEM DE ERRO
                MessageBox.Show(erro.Message);

            }
                */

        }
    }
  }
