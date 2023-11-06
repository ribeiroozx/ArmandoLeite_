drop table adminstrador
drop table Audio
drop table Conteudo
drop table Fotos
drop table Pdf
drop table Videos


CREATE TABLE Conteudo
( 
idConteudo INT PRIMARY KEY IDENTITY,  
tituloConteudo VARCHAR(100) NOT NULL,  
textoConteudo VARCHAR(100) NOT NULL,  
nomeEscritorConteudo VARCHAR(100) NOT NULL,  
dataConteudo VARCHAR(100) NOT NULL,  
);


CREATE TABLE Audio 
( 
idAudio INT PRIMARY KEY IDENTITY,
idConteudo INT NOT NULL,
selectAudio VARBINARY(MAX) NOT NULL,
);
 
CREATE TABLE Videos 
( 
idVideo INT PRIMARY KEY IDENTITY,
idConteudo INT NOT NULL,
selectVideo VARBINARY(MAX) NOT NULL, 
);
 
CREATE TABLE Pdf 
( 
idPdf INT PRIMARY KEY IDENTITY,
idConteudo INT NOT NULL,
selectPdf VARBINARY(MAX) NOT NULL,  
);
 
CREATE TABLE Fotos 
( 
idFoto INT PRIMARY KEY IDENTITY,
idConteudo INT NOT NULL,
selectFoto VARBINARY(MAX) NOT NULL,
);

ALTER TABLE Audio ADD FOREIGN KEY (idConteudo) REFERENCES Audio (idAudio)
ALTER TABLE Fotos ADD FOREIGN KEY (idConteudo) REFERENCES Fotos (idFoto)
ALTER TABLE Pdf ADD FOREIGN KEY (idConteudo) REFERENCES Pdf (idPdf)
ALTER TABLE Videos ADD FOREIGN KEY (idConteudo) REFERENCES Videos (idVideo)