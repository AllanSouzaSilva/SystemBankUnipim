DROP DATABASE SYSTEMBANKUNIPIM

USE SYSTEMBANKUNIPIM
--Dados pessoais do cliente
CREATE TABLE dbo.[TB_Cliente] 
(
                Id_Cliente INT IDENTITY (1,1) NOT NULL,
                Nome VARCHAR(45) NOT NULL,
                CPF VARCHAR(11) NULL,
                CNPJ VARCHAR(14) NULL,
				DtNasc DATE NOT NULL,
                Telefone VARCHAR(11) NOT NULL,
                Email VARCHAR(45) NOT NULL,
                Senha VARCHAR(MAX) NOT NULL
);

--Tabelas de usuário administrativo de acesso ao sistema
CREATE TABLE dbo.[TB_Usuario]
(
				Id_Usuario INT IDENTITY (1,1) NOT NULL,
				Usuario VARCHAR(20) NOT NULL,
				Senha VARCHAR(MAX) NOT NULL
);

--Informações das movimentações do cliente
CREATE TABLE dbo.[TB_Carteira]
(
                Id_Carteira INT IDENTITY(5,5) NOT NULL,
				Id_Cliente INT NOT NULL,
                Saldo_Carteira Decimal(30,2) NULL,
                Ultimo_Deposito Decimal(30,2) NULL,
                Ultimo_Saque Decimal(30,2) NULL,
				Data_Ultima_Transacao DATETIME NULL,
				Ativo BIT NOT NULL
);


--Quantidade de um tipo de bitcoin sendo investido
CREATE TABLE dbo.[TB_Investimento]
(
                Id_Investimento INT IDENTITY(1,1) NOT NULL,
                Id_Carteira INT NOT NULL,
                Id_Tipo_Investimento INT NOT NULL,
                Quantidade INT NOT NULL
);

--Valor do tipo de bitcoin
CREATE TABLE dbo.[TB_Tipo_Investimento]
(
				Id_Tipo_Investimento INT IDENTITY(1,1) NOT NULL,
				Descricao_Investimento VARCHAR(25) NOT NULL,
				Valor_Investimento DECIMAL (30,2) NOT NULL,
);

--Transações das carteiras dos clientes
CREATE TABLE dbo.[TB_Transacao]
(
		Id_Transacao INT IDENTITY(1,1) NOT NULL,
		Id_Carteira INT NOT NULL,
		Id_Tipo_Transacao INT NOT NULL,
		Valor_Transacao DECIMAL (30,2) NOT NULL,
		Carteira_Destino INT NULL,
		Agencia_Destino INT NULL,
		Conta_Destino INT NULL,

);
--Tipo de transações (Resgate,Transferencia)
CREATE TABLE dbo.[TB_Tipo_Transacao]
(
				Id_Tipo_Transacao INT IDENTITY(1,1) NOT NULL,
				Descricao_Investimento VARCHAR(25) NOT NULL,
);

--Definição de PK
ALTER TABLE TB_Cliente ADD CONSTRAINT PK_Id_Cliente Primary Key (Id_Cliente);
ALTER TABLE TB_Carteira ADD CONSTRAINT PK_Id_Carteira Primary Key (Id_Carteira);
ALTER TABLE TB_Investimento ADD CONSTRAINT PK_Id_Investimento Primary Key (Id_Investimento);
ALTER TABLE TB_Tipo_Investimento ADD CONSTRAINT PK_Id_Tipo_Investimento Primary Key (Id_Tipo_Investimento);
ALTER TABLE TB_Tipo_Transacao ADD CONSTRAINT PK_Id_Tipo_Transacao Primary Key (Id_Tipo_Transacao);
ALTER TABLE TB_Transacao ADD CONSTRAINT PK_Id_Transacao Primary Key (Id_Transacao);
ALTER TABLE TB_Usuario ADD CONSTRAINT PK_Id_Uusario Primary Key (Id_Usuario);

--Definição de FK
ALTER TABLE TB_Carteira  ADD CONSTRAINT FK_Id_Cliente Foreign Key (Id_Cliente) References TB_Cliente (Id_Cliente);
ALTER TABLE TB_Investimento  ADD CONSTRAINT FK_Id_Carteira Foreign Key (Id_Carteira) References TB_Carteira (Id_Carteira);
ALTER TABLE TB_Investimento  ADD CONSTRAINT FK_Id_Tipo_Investimento Foreign Key (Id_Tipo_Investimento) References TB_Tipo_Investimento (Id_Tipo_Investimento);
ALTER TABLE TB_Transacao  ADD CONSTRAINT FK_Id_Tipo_Transacao Foreign Key (Id_Tipo_Transacao) References TB_Tipo_Transacao (Id_Tipo_Transacao);
ALTER TABLE TB_Transacao  ADD CONSTRAINT FK_Transacao_Id_Carteira Foreign Key (Id_Carteira) References TB_Carteira (Id_Carteira);

--Inserindo dados na tabela Cliente
INSERT INTO TB_Cliente VALUES ('BIANCA DIAS RODRIGUES','47579156830','','14/08/1999','11966228058','loirinhah02@gmail.com', '260805');
INSERT INTO TB_Cliente VALUES ('ELIZANGELA FERNANDES LEAL','58468953258','','28/02/2001','11986526584','lizdesgraçadaminhavida@hotmail.com', '12345');
INSERT INTO TB_Cliente VALUES ('ALLAN SOUZA SILVA','89658256892','','10/10/2001','1158695689','allanfofinho@hotmail.com', '1111');
INSERT INTO TB_Cliente VALUES ('IBAZAR.COM ATIVIDADES DE INTERNET LTDA','','03499243000104','01/01/2000','11958686363','mercadolivre@hotmail.com', 'livre');
INSERT INTO TB_Cliente VALUES ('IGOR BARRETO MARÇAL MARQUES','57845689235','','25/02/1996','11958485845','bananinha@hotmail.com','bananinha');
INSERT INTO TB_Cliente VALUES ('SMOKE TABACARIA','','20711508000105','03/05/2010','1132235656','smoke@smoketabacaria.com','narga');
INSERT INTO TB_Cliente VALUES ('JOSESVALDO JESUS','65232547896','','25/12/1997','11965872356','josesvaldo.jesus@gmail.com','josesvaldo');
INSERT INTO TB_Cliente VALUES ('BRYAN CERQUEIRA RODRIGUES','10258695368','','26/08/2000','1125522525','bryancr@gmail.com','021400');
INSERT INTO TB_Cliente VALUES ('MIKHAEL PEDRO SCLENGMANN MOLINA','78576439827','','2000-09-09','11987675434','sclengman@gmail.com','nicolas');
INSERT INTO TB_Cliente VALUES ('SYSTEM BANK UNIPIM','','11111111111111','2001-01-01','11999999999','adm@adm.com','adm');

--Inserindo dados na tabela Carteira
INSERT INTO TB_Carteira VALUES ('2','0','0','0','01/01/2000 00:00:00.000','1');
INSERT INTO TB_Carteira VALUES ('1','2500','268.06','0','12/10/2020 11:37:21.587','1');
INSERT INTO TB_Carteira VALUES ('4','128286.28','64143.14','1418.48','12/10/2020 15:47:26.150','1');
INSERT INTO TB_Carteira VALUES ('9','420.77','274.87','145.9','12/01/2020 17:45:58.650','1');
INSERT INTO TB_Carteira VALUES ('7','5497.4','1099.48','0','31/05/2020 22:47:56.009','1');
INSERT INTO TB_Carteira VALUES ('5','0','0','0','01/01/2000 00:00:00.000','1');
INSERT INTO TB_Carteira VALUES ('6','67910.9','274.87','0','14/08/2020 16:56:25.050','1');
INSERT INTO TB_Carteira VALUES ('3','1411.28','1411.28','0','12/06/2020 18:46:53.650','1');
INSERT INTO TB_Carteira VALUES ('8','5412','1411.28','14.59','02/04/2020 16:01:02.053','1');


--Inserindo valores dos tipos de moedas
INSERT INTO TB_Tipo_Investimento VALUES ('Bitcoin Cash','1418.48');
INSERT INTO TB_Tipo_Investimento VALUES ('Bitcoin','64102.94');
INSERT INTO TB_Tipo_Investimento VALUES ('Litecoin','267.13');
INSERT INTO TB_Tipo_Investimento VALUES ('Ethereum','2097.88');
INSERT INTO TB_Tipo_Investimento VALUES ('Ripple','1.37');
INSERT INTO TB_Tipo_Investimento VALUES ('EOS','14.59');

--Inserindo investimentos dos clientes

INSERT INTO TB_Investimento VALUES ('5','1','1');
INSERT INTO TB_Investimento VALUES ('15','2','1');
INSERT INTO TB_Investimento VALUES ('5','6','6');
INSERT INTO TB_Investimento VALUES ('20','3','1');
INSERT INTO TB_Investimento VALUES ('25','5','7');
INSERT INTO TB_Investimento VALUES ('35','4','1');
INSERT INTO TB_Investimento VALUES ('40','1','1');
INSERT INTO TB_Investimento VALUES ('45','4','1');
INSERT INTO TB_Investimento VALUES ('45','3','5');

--Tipo de transções possíveis
INSERT INTO TB_Tipo_Transacao VALUES ('Resgate');
INSERT INTO TB_Tipo_Transacao VALUES ('Transferência');
INSERT INTO TB_Tipo_Transacao VALUES ('Compra');
INSERT INTO TB_Tipo_Transacao VALUES ('Venda');

--Transações realizadas pelos clientes
INSERT INTO TB_Transacao VALUES ('15','1','2000','','','');
INSERT INTO TB_Transacao VALUES ('20','2','473.24','4','','');
INSERT INTO TB_Transacao VALUES ('25','2','268.06','','8774','551089');
INSERT INTO TB_Transacao VALUES ('20','1','100','','','');
INSERT INTO TB_Transacao VALUES ('20','1','633','','','');
INSERT INTO TB_Transacao VALUES ('5','2','100','8','','');
INSERT INTO TB_Transacao VALUES ('35','2','543.77','10','','');
INSERT INTO TB_Transacao VALUES ('40','2','982.56','','0001','765476454');

--Usuários administrativos do sistema
INSERT INTO TB_Usuario VALUES ('adm','123456');
INSERT INTO TB_Usuario VALUES ('allan','allanweb');
INSERT INTO TB_Usuario VALUES ('mikhael','sclengmann');
INSERT INTO TB_Usuario VALUES ('bianca','260805');
INSERT INTO TB_Usuario VALUES ('elizangela','acelerada');
INSERT INTO TB_Usuario VALUES ('igor','bananinha');
INSERT INTO TB_Usuario VALUES ('gabriel','narguile');


--Visualização dos dados das tabelas
SELECT * FROM [TB_Cliente];
SELECT * FROM [TB_Carteira];
SELECT * FROM [TB_Investimento];
SELECT * FROM [TB_Tipo_Investimento];
SELECT * FROM [TB_Transacao];
SELECT * FROM [TB_Tipo_Transacao];
SELECT * FROM [TB_Usuario];