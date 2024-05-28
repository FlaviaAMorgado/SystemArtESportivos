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
    public partial class Funcionario : Form

    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public Funcionario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtUsuario.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            txtNome.Focus(); //DEIXA A SETINHA NO CAMPO NOME
        }
        private void desabiltaCampos()
        {
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtUsuario.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            txtPesquisar.Clear(); //LIMPA O CAMPO PESQUISAR
            txtPesquisar.Focus();
            limpaCampos(); //CHAMANDO O METODO LIMPA CAMPOS
        }

        private void limpaCampos()
        {
            txtNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtPesquisar.Clear();
            dgvFuncionario.DataSource = null; //LIMPA O DATAGRIDVIEW
        }





        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            habilitaCampos();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o Campo");

            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o Campo");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o Campo");

            }
            try
            {
                //FAZ O UPDATE NO BANCO DE DADOS
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con.ConnectarBD();
                cmd.CommandText = "update tbFuncionario set nomeFunc = @nomeFunc, usuario = @usuario, senha = @senha where codFunc= " + txtCodFunc.Text;
                cmd.Parameters.Add("@nomeFunc", MySqlDbType.VarChar).Value = txtNome.Text; //PEGA O VALOR DO NOME
                cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = txtUsuario.Text;
                cmd.Parameters.Add("@senha", MySqlDbType.Int16).Value = int.Parse(txtSenha.Text);
                cmd.ExecuteNonQuery();//EXECUTA A AÇÃO DE INSERIR
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados com sucesso");
                limpaCampos();
                desabiltaCampos();
                txtPesquisar.Focus();
                cmd.Parameters.Clear();
                con.DesConnectarBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarFuncionarios();

        }

        private void carregarFuncionarios()
        {
            //VAI TENTAR CASO DE CERTO ELE MOSTRA
            try
            {
                //ABRE A CONEXÃO DO BANCO COM C#
                con.ConnectarBD();
                txtCodFunc.Text = dgvFuncionario.SelectedRows[0].Cells[0].Value.ToString();  //PEGA O VALOR DO PRIMEIRO CAMPO DA TABELA(CODIGO POR EXEMPLO CASO TENHA)
                txtNome.Text = dgvFuncionario.SelectedRows[0].Cells[2].Value.ToString();//PEGA O O NOME E PASSAR NO DATAGRID
                txtUsuario.Text = dgvFuncionario.SelectedRows[0].Cells[3].Value.ToString();
                txtSenha.Text = dgvFuncionario.SelectedRows[0].Cells[4].Value.ToString();

                //DESCONECTA O BANCO DE DADOS
                con.DesConnectarBD();

            }
            //EM CASO DÊ ALGO ERRADO  
            catch (Exception erro)
            {
                //MOSTRA A MENSAGEM DE ERRO
                MessageBox.Show(erro.Message);

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //VERIFICA OS CAMPOS SE ESTÃO VAZIOS
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Nome");
                txtNome.Focus();
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Usuario");
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Senha");
                txtSenha.Focus();
            }

            else
            {    //tratamento de erros evita bugar todo sistema apresenta mensagem erro TRY ELE TENTA 
                try
                {
                    //VARIAVEI SQL QUE RECEBE O INSERT(VAI INSERIR OS DADOS NO BANCO com imagem)
                    string sql = "insert into tbFuncionario(nomeFunc, usuario, senha) values (@nomeFunc, @usuario, @senha)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD()); //CMD IDENTIFICA OS COMANDOS DO MYSQL NO c#
                    cmd.Parameters.Add("@nomeFunc", MySqlDbType.VarChar).Value = txtNome.Text; //PEGA O VALOR DO NOME
                    cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = txtUsuario.Text;
                    cmd.Parameters.Add("@senha", MySqlDbType.Int16).Value = int.Parse(txtSenha.Text);
                    cmd.ExecuteNonQuery();//EXECUTA A AÇÃO DE INSERIR
                    MessageBox.Show("Dados Cadastrados com Sucesso"); //APRESENTE A MENSAGEM DE SUCESSO
                    limpaCampos();//CHAMA O METODO LIMPA CAMPOS
                    con.DesConnectarBD();//DESCONECTA DO BANCO DE DADOS
                }
                //CASO NÃO CONSIGA EM VEZ DE TRAVAR O PROJETO APARECE UMA MENSAGEM
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                //TENTA
                try
                {
                    con.ConnectarBD();
                    //COMO ESTAMOS USANDO MYSQL PRECISA SER CHAMANDO O MYSQLCOMMAND NA INSTANCIA
                    MySqlCommand cmd = new MySqlCommand();
                    //FAZENDO O SELECT NA TABELA DO BANCO
                    cmd.CommandText = "select * from tbFuncionario";

                    //ABRE A CONEXÃO DO c# COM MYSQL
                    cmd.Connection = con.ConnectarBD();
                    //MECANISMO QUE BUSCA OS DADOS DA TABELA NO BANCO
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    //LOCAL AONDE ARMAZENA OS DADOS TRAZIDOS 
                    DataTable dt = new DataTable();
                    //JUNTO  O DATA ADAPTER (da) com MySqlCommand(cmd)
                    da.SelectCommand = cmd;
                    //FILTTRA OS DADOS DENTRO DO DT
                    da.Fill(dt);
                    //APRESENTA OS DADOS NO DATAGRIDVIEW
                    dgvFuncionario.DataSource = dt;
                    //DESCONECTA O BANCO
                    con.DesConnectarBD();
                }
                //CASO DE ERRADO 
                catch (Exception erro)
                {
                    //MOSTRA UMA MENSAGEM
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                //SENÃO TRAS O DATAGRID VAZIO
                dgvFuncionario.DataSource = null;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FAZ A PERGUNTA SE DESEJA EXCLUIR OU NÃO 
            DialogResult excluir = MessageBox.Show("Deseja excluir esse registro ?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (excluir == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    // EXCLUI DO BANCO DE DADOS
                    MySqlCommand cmd = new MySqlCommand();
                    con.ConnectarBD();
                    cmd.CommandText = "delete from tbFuncionario where codFunc= " + txtCodFunc.Text;
                    cmd.Connection = con.ConnectarBD();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados apagados com sucesso");
                    limpaCampos();
                    desabiltaCampos();
                    txtPesquisar.Focus();
                    cmd.Parameters.Clear();
                    con.DesConnectarBD();


                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
    }
}

 