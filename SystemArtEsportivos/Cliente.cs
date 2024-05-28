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
    public partial class Cliente : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();


        public Cliente()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void habilitaCampos()
        {
            txtCPF.Enabled = true;
            txtNome.Enabled = true;
            txtNumeroEnd.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtCEP.Enabled = true;
            txtLogadouro.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnALterar.Enabled = false;
            txtNome.Focus(); //DEIXA A SETINHA NO CAMPO NOME
        }

        // METODO DESABILITAR CAMPOS

        private void desabiltaCampos()
        {
            txtCPF.Enabled = true;
            txtNome.Enabled = true;
            txtNumeroEnd.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtCEP.Enabled = true;
            txtLogadouro.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnALterar.Enabled = false;
            txtPesquisar.Clear(); //LIMPA O CAMPO PESQUISAR
            txtPesquisar.Focus();
            limpaCampos(); //CHAMANDO O METODO LIMPA CAMPOS
        }

        // LIMPA CAMPOS

        private void limpaCampos()
        {
            txtCPF.Clear();
            txtNome.Clear();
            txtNumeroEnd.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtCEP.Clear();
            txtLogadouro.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtPesquisar.Clear();
            dgvCliente.DataSource = null; //LIMPA O DATAGRIDVIEW
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void pnConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtLogadouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogadouro_Click(object sender, EventArgs e)
        {

        }

        private void lbltitolocliente_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarClientes();

        }
        private void carregarClientes()
        {
            //VAI TENTAR CASO DE CERTO ELE MOSTRA
            try
            {
                //ABRE A CONEXÃO DO BANCO COM C#
                con.ConnectarBD();
                txtCodCli.Text = dgvCliente.SelectedRows[0].Cells[0].Value.ToString();  //PEGA O VALOR DO PRIMEIRO CAMPO DA TABELA(CODIGO POR EXEMPLO CASO TENHA)
                txtCPF.Text = dgvCliente.SelectedRows[0].Cells[1].Value.ToString();
                txtNome.Text = dgvCliente.SelectedRows[0].Cells[2].Value.ToString();//PEGA O O NOME E PASSAR NO DATAGRID
                txtNumeroEnd.Text = dgvCliente.SelectedRows[0].Cells[3].Value.ToString();
                txtTelefone.Text = dgvCliente.SelectedRows[0].Cells[4].Value.ToString();
                txtEmail.Text = dgvCliente.SelectedRows[0].Cells[5].Value.ToString();//PEGA O EMAIL E PASSAR NO DATAGRID
                txtCEP.Text = dgvCliente.SelectedRows[0].Cells[6].Value.ToString();
                txtBairro.Text = dgvCliente.SelectedRows[0].Cells[7].Value.ToString();
                txtCidade.Text = dgvCliente.SelectedRows[0].Cells[8].Value.ToString();
                txtUF.Text = dgvCliente.SelectedRows[0].Cells[9].Value.ToString();
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

        private void lbltitolocliente_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //VERIFICA OS CAMPOS SE ESTÃO VAZIOS
            if (txtCPF.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo CPF");
                txtCPF.Focus();
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Nome");
                txtNome.Focus();
            }
            else if (txtNumeroEnd.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Nº da Residência");
                txtNumeroEnd.Focus();
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Telefone");
                txtTelefone.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Email");
                txtEmail.Focus();
            }


            else if (txtCEP.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo CEP");
                txtCEP.Focus();
            }
            else if (txtLogadouro.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Logradouro");
                txtLogadouro.Focus();
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Bairro");
                txtBairro.Focus();
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Cidade");
                txtCidade.Focus();
            }
            else if (txtUF.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo UF");
                txtUF.Focus();
            }


            else
            {    //tratamento de erros evita bugar todo sistema apresenta mensagem erro TRY ELE TENTA 
                try
                {
                    //VARIAVEI SQL QUE RECEBE O INSERT(VAI INSERIR OS DADOS NO BANCO com imagem)
                    string sql = "call spInsert_tbCliente (@CPF, @nomeCli, @telefone, @email, @cepCli, @logradouro, @numEnd, @bairro, @cidade, @UF)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD()); //CMD IDENTIFICA OS COMANDOS DO MYSQL NO c#
                    cmd.Parameters.Add("@CPF", MySqlDbType.Decimal).Value = decimal.Parse(txtCPF.Text);
                    cmd.Parameters.Add("@nomeCli", MySqlDbType.VarChar).Value = txtNome.Text; //PEGA O VALOR DO NOME
                    cmd.Parameters.Add("@telefone", MySqlDbType.Decimal).Value = decimal.Parse(txtTelefone.Text);
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text; // PEGA O VALOR DO TELEFONE
                    cmd.Parameters.Add("@cepCli", MySqlDbType.VarChar).Value = txtCEP.Text;
                    cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = txtLogadouro.Text;
                    cmd.Parameters.Add("@numEnd", MySqlDbType.Decimal).Value = decimal.Parse(txtNumeroEnd.Text);
                    cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = txtBairro.Text;
                    cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = txtCidade.Text;
                    cmd.Parameters.Add("@UF", MySqlDbType.VarChar).Value = txtUF.Text;
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
                    cmd.CommandText = "select * from tbcliente Inner join tbEndereco";

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
                    dgvCliente.DataSource = dt;
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
                dgvCliente.DataSource = null;

            }


        }

        private void btnALterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o Campo");

            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o Campo");
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o Campo");

            }
            try
            {
                //FAZ O UPDATE NO BANCO DE DADOS
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con.ConnectarBD();
                cmd.CommandText = "update spInsert_tbCliente set CPF = @CPF, Nome = @nomeCli, Telefone = @telefone, Email = @email, CEP=@cepCli, Logradouro =@logradouro, numEnd=@numEnd,Bairro=@bairro, Cidade=@cidade, Estado=@UF where codCli= " + txtCodCli.Text;
                cmd.Parameters.Add("@CPF", MySqlDbType.Decimal).Value = decimal.Parse(txtCPF.Text);
                cmd.Parameters.Add("@nomeCli", MySqlDbType.VarChar).Value = txtNome.Text; //PEGA O VALOR DO NOME
                cmd.Parameters.Add("@telefone", MySqlDbType.Decimal).Value = decimal.Parse(txtTelefone.Text);
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text; // PEGA O VALOR DO TELEFONE
                cmd.Parameters.Add("@cepCli", MySqlDbType.VarChar).Value = txtCEP.Text;
                cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = txtLogadouro.Text;
                cmd.Parameters.Add("@numEnd", MySqlDbType.Decimal).Value = decimal.Parse(txtNumeroEnd.Text);
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = txtBairro.Text;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = txtCidade.Text;
                cmd.Parameters.Add("@UF", MySqlDbType.VarChar).Value = txtUF.Text;
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

        private void btnEcluir_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from tbcliente where codCli= " + txtCodCli.Text;
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
