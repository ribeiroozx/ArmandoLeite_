CREATE TABLE adminstrador 
( 
idAdm INT PRIMARY KEY identity (1,1) not null,  
nome VARCHAR(20) NOT NULL,  
sobrenome VARCHAR(100) NOT NULL,  
email varchar (200) NOT NULL,  
senha VARCHAR(20) NOT NULL,  
dataAdministrador datetime not null,
);

 drop table Pdf
 drop table adminstrador
 drop table Audio
 drop table Fotos
 drop table Conteudo
 drop table Videos

--CREATE TABLE conteudo 
--( 
--idConteudo INT PRIMARY KEY identity (1,1) not null,  
--Adicionar VARCHAR(n) NOT NULL,  
--excluir VARCHAR(n) NOT NULL,  
--editar VARCHAR(n) NOT NULL,  
--);

 

CREATE TABLE Audio 
( 
idAudio INT PRIMARY KEY identity (1,1) not null,  
NomeAudio VARCHAR(100) NOT NULL, 
DadoAudio varbinary (max) not null,
dataCadastroAudio DATEtime NOT NULL,  
FkConteudo int not null,
foreign key (FKConteudo) references Conteudo (idConteudo)
);

 

CREATE TABLE Videos 
( 
idVideo INT PRIMARY KEY identity (1,1) not null,  
NomeVideo VARCHAR(100) NOT NULL, 
DadoVideo varbinary(max) not null,   
dataCadastroVideo DATEtime NOT NULL,  
FkConteudo int not null,
foreign key (FKConteudo) references Conteudo (idConteudo)
);

 


CREATE TABLE Pdf 
( 
idAudio INT PRIMARY KEY identity (1,1) not null,  
NomePdf VARCHAR(100) NOT NULL,  
DadoPdf varbinary (max) not null,
dataCadastroPdf DATEtime NOT NULL,  
FkConteudo int not null,
foreign key (FKConteudo) references Conteudo (idConteudo)
);

 

CREATE TABLE Fotos 
( 
idFotos INT PRIMARY KEY identity (1,1) not null,  
nomeFoto VARCHAR(100) NOT NULL,  
DadoFoto varbinary (max) not null,
DataCdastroFoto DATEtime NOT NULL,  
FkConteudo int not null,
foreign key (FKConteudo) references Conteudo (idConteudo)
); 

CREATE TABLE Conteudo
(
    idConteudo INT PRIMARY KEY identity (1,1) NOT NULL,
    Titulo       VARCHAR (100) NOT NULL,
    Texto        VARCHAR (MAX) NOT NULL,
    NomeEscritor VARCHAR (100) NOT NULL,
    data         varchar(max)  NOT NULL,
);

CREATE TABLE Imagens (
    IdImagem INT PRIMARY KEY IDENTITY,
    NomeArquivo NVARCHAR(50) NOT NULL,
    DadosImagem VARBINARY(MAX) NOT NULL
);