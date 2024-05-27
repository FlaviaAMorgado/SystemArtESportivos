Drop database if exists dbEsportes;
Create database dbEsportes;
Use dbEsportes;

-- Criando as tabelas --
Create table tbCliente(
	codCli int auto_increment PRIMARY KEY,
    CPF decimal(11,0) not null unique,
    nomeCli varchar(200) not null,
    telefone decimal(11,0) not null,
    email varchar(200) not null,
    cepCli char(8) not null,
    numEnd decimal(6,0) not null,
    compEnd varchar(50)
);

Create table tbFuncionario(
	codFunc int auto_increment PRIMARY KEY,
    nomeFunc varchar(200) not null,
    usuario varchar(20) not null,
    senha int not null
);

Create table tbEndereco(
	CEP char(8) PRIMARY KEY,
    logradouro varchar(200) not null,
    bairro int not null,
    cidade int not null,
    UF int not null
);

Create table tbBairro(
	bairroId int auto_increment PRIMARY KEY,
    nomeBairro varchar(200) not null
);

Create table tbCidade(
	cidadeId int auto_increment PRIMARY KEY,
    nomeCidade varchar(200) not null
);

Create table tbEstado(
	UFId int auto_increment PRIMARY KEY,
    nomeEstado char(2) not null
);

Create table tbProduto(
	codBarras decimal(14,0) PRIMARY KEY,
    nomeProd varchar(200) not null,
    qtd int not null,
    preco decimal(8,2) not null
);

Create table tbPedido(
	codPedido int auto_increment PRIMARY KEY,
    cliente int not null,
    funcionario int not null,
    data date not null,
    totalPedido decimal(8,2) not null
);

Create table tbItemPedido(
	codPedido int,
    codBarras decimal(14,0),
    qtd int not null,
    valorItem decimal(8,2) not null,
    PRIMARY KEY(codPedido, codBarras)
);


-- Adicionando os relacionamentos --
Alter table tbEndereco ADD FOREIGN KEY (bairro) REFERENCES tbBairro(bairroId);
Alter table tbEndereco ADD FOREIGN KEY(cidade) references tbCidade(cidadeId);
Alter table tbEndereco ADD FOREIGN KEY(UF) references tbEstado(UFId);

Alter table tbCliente ADD FOREIGN KEY(cepCli) references tbEndereco(CEP);

Alter table tbPedido ADD FOREIGN KEY(cliente) references tbCliente(codCli);

Alter table tbPedido ADD FOREIGN KEY(funcionario) references tbFuncionario(codFunc);

Alter table tbItemPedido ADD FOREIGN KEY(codPedido) references tbPedido(codPedido);
Alter table tbItemPedido ADD FOREIGN KEY(codBarras) references tbProduto(codBarras);


-- Criando a procedure de cadastro de clientes --
Delimiter $$
Create procedure spInsert_tbCliente(vCPF decimal(11,0), vNome varchar(200), vTelefone decimal(11,0), vEmail varchar(200), vCEP char(8), vLogradouro varchar(200), vnumEnd decimal(6,0), vcompEnd varchar(50), vBairro varchar(200), vCidade varchar(200), vEstado char(2))
Begin
	If not exists(Select CPF from tbCliente where CPF = vCPF) then
		
			if not exists (Select CEP from tbEndereco where CEP = vCEP) then
				
                if not exists(Select nomeBairro from tbBairro where nomeBairro = vBairro) then
					insert into tbBairro(nomeBairro)
									values(vBairro);
				End if;
                  
				if not exists(Select nomeCidade from tbCidade where nomeCidade = vCidade) then
					insert into tbCidade(nomeCidade)
									values(vCidade);
				End if;
                
                if not exists(Select nomeEstado from tbEstado where nomeEstado = vEstado) then
					insert into tbEstado(nomeEstado)
									values(vEstado);
				End if;
                
				insert into tbEndereco(CEP, logradouro, bairro, cidade, UF)
								values(vCEP, vlogradouro,
									  (Select bairroId from tbBairro where nomeBairro = vBairro),
                                      (Select cidadeId from tbCidade where nomeCidade = vCidade),
                                      (Select UFId from tbEstado where nomeEstado = vEstado));
		end if;

			Insert into tbCliente(CPF, nomeCli, telefone, email, cepCli, numEnd, compEnd)
							values(vCPF, vNome, vTelefone, vEmail, vCEP, vnumEnd, vcompEnd);
    else
		Select * from tbCliente where CPF = vCPF;
	end if;
End $$

-- Criando o a procedure de cadastro de funcionário --
Delimiter $$
Create procedure spInsert_tbFuncionario(vNome varchar(200), vUsuario varchar(20), vSenha int)
Begin
	Insert into tbFuncionario(nomeFunc, usuario, senha)
						values(vNome, vUsuario, vSenha);
End $$

-- Criando a procedure de cadastro de produtos --
Delimiter $$
Create procedure spInsert_tbProduto(vCod decimal(14,0), vNome varchar(200), vQtd int, vPreco decimal(8,2))
Begin
	if not exists(Select codBarras from tbProduto where codBarras = vCod) then
		Insert into tbProduto(codBarras, nomeProd, qtd, preco)
					   values(vCod, vNome, vQtd, vPreco);
    else
		Select('Produto já está cadastrado!');
    End if;
End $$

-- Criando a procedure para cadastro dos pedidos --
Delimiter $$
Create procedure spInsert_tbItemPedido(vCodFunc int, vCPF decimal(11,0), vCodBarras decimal(14,0), vQtd int)
Begin
	Declare vPreco decimal(8,2);
    Declare vCodPedido int;
    Declare vCodCli int;
    
	if exists(Select codBarras from tbProduto where codBarras = vCodBarras) then
		if exists(Select CPF from tbCliente where CPF = vCPF) then
			Set vPreco = (Select preco from tbProduto where codBarras = vCodBarras);
			Set vCodCli = (Select codCli from tbCliente where vCPF = CPF);
            Set vCodPedido = (Select CodPedido from tbPedido where Cliente = vCodCli and data = CURRENT_DATE());
            
            if exists(Select CodPedido, CodBarras from tbItemPedido where CodPedido = vCodPedido and CodBarras = vCodBarras) then
					Update tbItemPedido set qtd = qtd + vQtd where CodPedido = vCodPedido and CodBarras = vCodBarras;
					Update tbPedido set totalPedido = totalPedido + (vQtd * vPreco) where codPedido = vCodPedido;
            else
                if exists((Select CodPedido from tbPedido where Cliente = vCodCli and data = CURRENT_DATE())) then
					Insert into tbItemPedido(codPedido, codBarras, qtd, valorItem)
									values(vCodPedido, vCodBarras, vQtd, vPreco);
					
                    Update tbPedido set totalPedido = totalPedido + (vQtd * vPreco) where codPedido = vCodPedido;
				else
					Insert into tbPedido(cliente, funcionario, data, totalPedido)
								values(vCodCli, (Select codFunc from tbFuncionario where vCodFunc = codFunc), 
									  (Select CURRENT_DATE()), (vQtd * vPreco));
					
                    Set vCodPedido = (Select CodPedido from tbPedido where Cliente = vCodCli and data = CURRENT_DATE());
                    
					Insert into tbItemPedido(codPedido, codBarras, qtd, valorItem)
									values(vCodPedido, vCodBarras, vQtd, vPreco);
				End if;
			End if;
        End if;
	End if;
End $$

-- Criando a procedure para aumentar o estoque dos produtos --
Delimiter $$
Create procedure spUpdate_tbProduto(vcodBarras decimal(14,0), vQtd int)
Begin
	Update tbProduto Set Qtd = Qtd + vQtd where codBarras = vCodBarras;
End $$

-- Criando o trigger para retirar do estoque --
Delimiter $$
Create Trigger TRG_Insert_ItemPedido After Insert On tbItemPedido For Each Row
Begin
	Update tbProduto Set Qtd = Qtd - New.Qtd Where CodBarras = New.CodBarras;
End $$

-- Criando Procedure para verificar CPF --
Delimiter $$
Create procedure spSelect_CPF(vCPF decimal(11,0))
Begin
	if not exists(Select CPF from tbCliente where CPF = vCPF) then
		Select "CPF não cadastrado!";
	End if;
End $$

-- Criando Procedure para verificar Código de Barras --
Delimiter $$
Create Procedure spSelect_CodBarras(vCodbarras decimal(14,0))
Begin
	if not exists(Select codBarras from tbProduto where codBarras = vCodBarras) then
		Select "Código do produto inválido";
	End if;
End $$

-- Criando Procedure para selecionar o total do pedido --
Delimiter $$
Create Procedure Select_total_tbPedido(vCPF decimal(11,0))
Begin
	Declare vCodCli int;
    Set vCodCli = (Select codCli from tbCliente where vCPF = CPF);
	Select totalPedido from tbPedido where Cliente = vCodCli and data = CURRENT_DATE();
End $$

-- Criando Procedure para selecionar os itens do pedido --
Delimiter $$
Create procedure spSelect_tbItemPedido(vCPF decimal(11,0))
Begin
	Declare vCodCli int;
	Declare vCodPedido int;
    Set vCodCli = (Select codCli from tbCliente where vCPF = CPF);
	Set vCodPedido = (Select CodPedido from tbPedido where Cliente = vCodCli and data = CURRENT_DATE());
    
    Select codBarras as 'Código de Barras',
			qtd as 'Quantidade', 
            valorItem as 'Valor Unitário'
	from tbItemPedido where codPedido = vCodPedido;
End $$