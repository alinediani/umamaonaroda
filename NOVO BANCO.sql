create database ControVAlores;
use ControValores;
create table usuario(id int primary key auto_increment,
					 nm varchar (50) not null,
                     cpf char (11) not null,
                     rg char (9) not null,
                     sex char (1) not null,
                     dtns date not null,
                     tel int not null,
                     email varchar (50) not null,
                     rua varchar (50) not null,
                     numero int not null,
                     compl varchar (50) not null,
                     cid varchar (40) not null,
                     est char (2) not null,
                     CEP char(8) not null,
                     usu varchar (50) not null,
                     sen varchar (50) not null,
                     senr varchar (50) not null,
                     dica varchar (150) not null
);

create table cadProd( id int primary key auto_increment,
					  nmProd varchar (50) not null,
                      preco float not null
                      );

create table cadProdItem( id int primary key auto_increment,
						  idProd int not null,
					      nmProd varchar (50) not null,
                          quantidade float not null,
                          preco float not null,
                          CONSTRAINT fk_idProd_ProdItem foreign key (idProd) REFERENCES cadProd(id)
                      );
