namespace SystemArtEsportivos
{
    partial class Pedido
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
            this.pnCadastros = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.txtCPFCli = new System.Windows.Forms.TextBox();
            this.lblCPFcli = new System.Windows.Forms.Label();
            this.lbltitolofuncionario = new System.Windows.Forms.Label();
            this.pnCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCadastros
            // 
            this.pnCadastros.Controls.Add(this.btnAdicionar);
            this.pnCadastros.Controls.Add(this.dgvPedidos);
            this.pnCadastros.Controls.Add(this.btnNovo);
            this.pnCadastros.Controls.Add(this.lblTotal);
            this.pnCadastros.Controls.Add(this.txtQtd);
            this.pnCadastros.Controls.Add(this.lblQtd);
            this.pnCadastros.Controls.Add(this.txtCodProd);
            this.pnCadastros.Controls.Add(this.lblCodProd);
            this.pnCadastros.Controls.Add(this.txtCodFunc);
            this.pnCadastros.Controls.Add(this.lblCodFunc);
            this.pnCadastros.Controls.Add(this.txtCPFCli);
            this.pnCadastros.Controls.Add(this.lblCPFcli);
            this.pnCadastros.Controls.Add(this.lbltitolofuncionario);
            this.pnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCadastros.Location = new System.Drawing.Point(2, 1);
            this.pnCadastros.Name = "pnCadastros";
            this.pnCadastros.Size = new System.Drawing.Size(659, 344);
            this.pnCadastros.TabIndex = 53;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(34, 193);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(78, 23);
            this.btnAdicionar.TabIndex = 76;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvPedidos.Location = new System.Drawing.Point(248, 62);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(269, 177);
            this.dgvPedidos.TabIndex = 75;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(58, 291);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(94, 31);
            this.btnNovo.TabIndex = 69;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(379, 257);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(138, 22);
            this.lblTotal.TabIndex = 64;
            this.lblTotal.Text = "Total: R$ 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(103, 149);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(25, 29);
            this.txtQtd.TabIndex = 61;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(30, 152);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(104, 22);
            this.lblQtd.TabIndex = 60;
            this.lblQtd.Text = "Quantidade:";
            this.lblQtd.Click += new System.EventHandler(this.lblQtd_Click);
            // 
            // txtCodProd
            // 
            this.txtCodProd.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProd.Location = new System.Drawing.Point(137, 118);
            this.txtCodProd.MaxLength = 14;
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(105, 29);
            this.txtCodProd.TabIndex = 59;
            this.txtCodProd.TextChanged += new System.EventHandler(this.txtCodProd_TextChanged);
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.Location = new System.Drawing.Point(30, 121);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(161, 22);
            this.lblCodProd.TabIndex = 58;
            this.lblCodProd.Text = "Código do Produto:";
            this.lblCodProd.Click += new System.EventHandler(this.lblCodProd_Click);
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFunc.Location = new System.Drawing.Point(144, 62);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(40, 29);
            this.txtCodFunc.TabIndex = 57;
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFunc.Location = new System.Drawing.Point(30, 64);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(163, 22);
            this.lblCodFunc.TabIndex = 56;
            this.lblCodFunc.Text = "Código Funcionário:";
            // 
            // txtCPFCli
            // 
            this.txtCPFCli.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFCli.Location = new System.Drawing.Point(117, 89);
            this.txtCPFCli.MaxLength = 11;
            this.txtCPFCli.Name = "txtCPFCli";
            this.txtCPFCli.Size = new System.Drawing.Size(125, 29);
            this.txtCPFCli.TabIndex = 55;
            this.txtCPFCli.TextChanged += new System.EventHandler(this.txtCPFCli_TextChanged);
            // 
            // lblCPFcli
            // 
            this.lblCPFcli.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFcli.Location = new System.Drawing.Point(30, 94);
            this.lblCPFcli.Name = "lblCPFcli";
            this.lblCPFcli.Size = new System.Drawing.Size(131, 22);
            this.lblCPFcli.TabIndex = 54;
            this.lblCPFcli.Text = "CPF do Cliente:";
            this.lblCPFcli.Click += new System.EventHandler(this.lblCPFcli_Click);
            // 
            // lbltitolofuncionario
            // 
            this.lbltitolofuncionario.AutoSize = true;
            this.lbltitolofuncionario.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitolofuncionario.Location = new System.Drawing.Point(150, 8);
            this.lbltitolofuncionario.Name = "lbltitolofuncionario";
            this.lbltitolofuncionario.Size = new System.Drawing.Size(342, 36);
            this.lbltitolofuncionario.TabIndex = 53;
            this.lbltitolofuncionario.Text = "CADASTRO DE PEDIDOS";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 349);
            this.Controls.Add(this.pnCadastros);
            this.Name = "Pedido";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.pnCadastros.ResumeLayout(false);
            this.pnCadastros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCadastros;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.Label lblCodFunc;
        private System.Windows.Forms.TextBox txtCPFCli;
        private System.Windows.Forms.Label lblCPFcli;
        private System.Windows.Forms.Label lbltitolofuncionario;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnAdicionar;
    }
}