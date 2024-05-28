namespace SystemArtEsportivos
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblLogadouro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNumeroEnd = new System.Windows.Forms.Label();
            this.lbltitolocliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtNumeroEnd = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogadouro = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnALterar = new System.Windows.Forms.Button();
            this.btnEcluir = new System.Windows.Forms.Button();
            this.pnCadastros = new System.Windows.Forms.Panel();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.pnCadastros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(12, 74);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(64, 22);
            this.lblNomeCliente.TabIndex = 36;
            this.lblNomeCliente.Text = "NOME:";
            this.lblNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(15, 284);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(34, 22);
            this.lblUF.TabIndex = 37;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(15, 258);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(74, 22);
            this.lblCidade.TabIndex = 38;
            this.lblCidade.Text = "CIDADE:";
            // 
            // lblLogadouro
            // 
            this.lblLogadouro.AutoSize = true;
            this.lblLogadouro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogadouro.Location = new System.Drawing.Point(15, 200);
            this.lblLogadouro.Name = "lblLogadouro";
            this.lblLogadouro.Size = new System.Drawing.Size(120, 21);
            this.lblLogadouro.TabIndex = 39;
            this.lblLogadouro.Text = "LOGRADOURO:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(14, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 22);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "EMAIL:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(15, 174);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(44, 22);
            this.lblCEP.TabIndex = 41;
            this.lblCEP.Text = "CEP:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(12, 96);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(43, 22);
            this.lblCPF.TabIndex = 42;
            this.lblCPF.Text = "CPF:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(15, 230);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(73, 22);
            this.lblBairro.TabIndex = 43;
            this.lblBairro.Text = "BAIRRO:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(12, 120);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(92, 22);
            this.lblTelefone.TabIndex = 44;
            this.lblTelefone.Text = "TELEFONE:";
            // 
            // lblNumeroEnd
            // 
            this.lblNumeroEnd.AutoSize = true;
            this.lblNumeroEnd.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEnd.Location = new System.Drawing.Point(15, 314);
            this.lblNumeroEnd.Name = "lblNumeroEnd";
            this.lblNumeroEnd.Size = new System.Drawing.Size(34, 22);
            this.lblNumeroEnd.TabIndex = 45;
            this.lblNumeroEnd.Text = "N° ";
            // 
            // lbltitolocliente
            // 
            this.lbltitolocliente.AutoSize = true;
            this.lbltitolocliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitolocliente.Location = new System.Drawing.Point(167, 31);
            this.lbltitolocliente.Name = "lbltitolocliente";
            this.lbltitolocliente.Size = new System.Drawing.Size(332, 36);
            this.lbltitolocliente.TabIndex = 46;
            this.lbltitolocliente.Text = "CADASTRO DE CLIENTE";
            this.lbltitolocliente.Click += new System.EventHandler(this.lbltitolocliente_Click_1);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(82, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 21);
            this.txtNome.TabIndex = 47;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(82, 98);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(177, 21);
            this.txtCPF.TabIndex = 48;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(104, 122);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(155, 21);
            this.txtTelefone.TabIndex = 49;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(90, 230);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(169, 21);
            this.txtBairro.TabIndex = 50;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(90, 257);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(169, 21);
            this.txtCidade.TabIndex = 51;
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(65, 284);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(194, 21);
            this.txtUF.TabIndex = 52;
            // 
            // txtNumeroEnd
            // 
            this.txtNumeroEnd.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEnd.Location = new System.Drawing.Point(50, 314);
            this.txtNumeroEnd.Name = "txtNumeroEnd";
            this.txtNumeroEnd.Size = new System.Drawing.Size(209, 21);
            this.txtNumeroEnd.TabIndex = 53;
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(104, 176);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(155, 21);
            this.txtCEP.TabIndex = 54;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(104, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 21);
            this.txtEmail.TabIndex = 55;
            // 
            // txtLogadouro
            // 
            this.txtLogadouro.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogadouro.Location = new System.Drawing.Point(104, 203);
            this.txtLogadouro.Name = "txtLogadouro";
            this.txtLogadouro.Size = new System.Drawing.Size(155, 21);
            this.txtLogadouro.TabIndex = 56;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(276, 76);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(74, 19);
            this.lblPesquisar.TabIndex = 57;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(356, 75);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(171, 21);
            this.txtPesquisar.TabIndex = 58;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(280, 102);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(247, 110);
            this.dgvCliente.TabIndex = 59;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(280, 226);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(87, 30);
            this.btnNovo.TabIndex = 60;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(403, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 30);
            this.btnSalvar.TabIndex = 61;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnALterar
            // 
            this.btnALterar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALterar.Location = new System.Drawing.Point(280, 276);
            this.btnALterar.Name = "btnALterar";
            this.btnALterar.Size = new System.Drawing.Size(87, 30);
            this.btnALterar.TabIndex = 62;
            this.btnALterar.Text = "ALTERAR";
            this.btnALterar.UseVisualStyleBackColor = true;
            this.btnALterar.Click += new System.EventHandler(this.btnALterar_Click);
            // 
            // btnEcluir
            // 
            this.btnEcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEcluir.Location = new System.Drawing.Point(403, 275);
            this.btnEcluir.Name = "btnEcluir";
            this.btnEcluir.Size = new System.Drawing.Size(87, 31);
            this.btnEcluir.TabIndex = 63;
            this.btnEcluir.Text = "EXCLUIR";
            this.btnEcluir.UseVisualStyleBackColor = true;
            this.btnEcluir.Click += new System.EventHandler(this.btnEcluir_Click);
            // 
            // pnCadastros
            // 
            this.pnCadastros.Controls.Add(this.txtCodCli);
            this.pnCadastros.Controls.Add(this.btnEcluir);
            this.pnCadastros.Controls.Add(this.btnALterar);
            this.pnCadastros.Controls.Add(this.btnSalvar);
            this.pnCadastros.Controls.Add(this.btnNovo);
            this.pnCadastros.Controls.Add(this.dgvCliente);
            this.pnCadastros.Controls.Add(this.txtPesquisar);
            this.pnCadastros.Controls.Add(this.lblPesquisar);
            this.pnCadastros.Controls.Add(this.txtLogadouro);
            this.pnCadastros.Controls.Add(this.txtEmail);
            this.pnCadastros.Controls.Add(this.txtCEP);
            this.pnCadastros.Controls.Add(this.txtNumeroEnd);
            this.pnCadastros.Controls.Add(this.txtUF);
            this.pnCadastros.Controls.Add(this.txtCidade);
            this.pnCadastros.Controls.Add(this.txtBairro);
            this.pnCadastros.Controls.Add(this.txtTelefone);
            this.pnCadastros.Controls.Add(this.txtCPF);
            this.pnCadastros.Controls.Add(this.txtNome);
            this.pnCadastros.Controls.Add(this.lbltitolocliente);
            this.pnCadastros.Controls.Add(this.lblNumeroEnd);
            this.pnCadastros.Controls.Add(this.lblTelefone);
            this.pnCadastros.Controls.Add(this.lblBairro);
            this.pnCadastros.Controls.Add(this.lblCPF);
            this.pnCadastros.Controls.Add(this.lblCEP);
            this.pnCadastros.Controls.Add(this.lblEmail);
            this.pnCadastros.Controls.Add(this.lblLogadouro);
            this.pnCadastros.Controls.Add(this.lblCidade);
            this.pnCadastros.Controls.Add(this.lblUF);
            this.pnCadastros.Controls.Add(this.lblNomeCliente);
            this.pnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCadastros.Location = new System.Drawing.Point(0, -22);
            this.pnCadastros.Name = "pnCadastros";
            this.pnCadastros.Size = new System.Drawing.Size(659, 344);
            this.pnCadastros.TabIndex = 36;
            // 
            // txtCodCli
            // 
            this.txtCodCli.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodCli.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCli.Location = new System.Drawing.Point(19, 50);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(10, 14);
            this.txtCodCli.TabIndex = 64;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 336);
            this.Controls.Add(this.pnCadastros);
            this.Location = new System.Drawing.Point(133, 46);
            this.MaximumSize = new System.Drawing.Size(745, 448);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.pnCadastros.ResumeLayout(false);
            this.pnCadastros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblLogadouro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNumeroEnd;
        private System.Windows.Forms.Label lbltitolocliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtNumeroEnd;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLogadouro;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnALterar;
        private System.Windows.Forms.Button btnEcluir;
        private System.Windows.Forms.Panel pnCadastros;
        private System.Windows.Forms.TextBox txtCodCli;
    }
}