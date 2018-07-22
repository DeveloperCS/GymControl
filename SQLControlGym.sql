create database controlGym
use controlGym

create table usuarios(

	id int identity(1,1) primary key,
	nombreUs varchar(50),
	usuario varchar (50),
	pass varbinary(max),
	tipoUs varchar(30)
)
INSERT into usuarios (nombreUs,usuario,pass,tipoUs)values('Carlos Hernandez','root', HASHBYTES('SHA2_512', 'root'),'Administrador');
UPDATE usuarios SET nombreUs='Ramones',usuario='j1',pass=HASHBYTES('SHA2_512', '123'),tipoUs='Usuario' WHERE id=1
DELETE usuarios where id =4
select * from usuarios
select id as Numero,nombreUs as Nombre,usuario as Usuario,tipoUs as Tipo from usuarios

Select usuario as us from usuarios
Select nombreUs as nom , usuario as us from usuarios
Select nombreUs as nom, tipoUs as tipo from usuarios where usuario = 'root'
select cast(case when pass = HASHBYTES('SHA2_512', 'root') then 1 else 0 end as bit) FlagPwdCorrecto
  from usuarios
 where usuario = 'root';

create table prom(
	idProm int identity(1,1) primary key,
	nomPromocion varchar(150) not null,
	descuento decimal(5,2)
)
insert into prom values('Estudiantil',0.16)
select * from prom
drop table prom
Select idProm as Id,nomPromocion as Promocion,descuento as Descuento from prom
/*truncate table prom*/

create table produc(
	idProduc int identity (1,1) primary key,
	nomProduc varchar(150) not null,
	cantidad int not null,
	precio smallmoney not null
)

insert into produc values('Agua 1Lt',10,10.50)
select idProduc as Id,nomProduc as Producto,cantidad as Cantidad,precio as Precio from produc
Update produc set nomProduc ='Coca',cantidad=12,precio=11.50 where idProduc = 2

create table memb(
  idMem int identity(1,1) primary key,
  nomMem varchar (150) not null,
  precioMem smallmoney not null
)
select idMem as Id, nomMem as Membresia,precioMem as Precio from memb
Insert into memb values('Mensual',200)
update memb set nomMem='Mensual',precioMem=1 where idMem=1 

create table visitante(
	cantidad int,
	fecha date
)
SELECT getdate();  
SELECT CONVERT (date, SYSDATETIME())  
    ,CONVERT (date, SYSDATETIMEOFFSET())  
    ,CONVERT (date, SYSUTCDATETIME())  
    ,CONVERT (date, CURRENT_TIMESTAMP)  
    ,CONVERT (date, GETDATE())  
    ,CONVERT (date, GETUTCDATE());  
/*
	FALTA CREAR TABLA!!!!
*/
create table regMem(
	idNueMem varchar(30) primary key not null,
	nombre varchar(225) not null,
	fNacimiento varchar(15) not null,
	sexo varchar(3)not null,
	dir varchar(225)not null,
	tel varchar(11)not null,
	fb varchar (125)not null,
	tMem varchar(150)not null,
	prom varchar(150)not null,
	total smallmoney not null,
	fechaIngreso date not null,
	fechatermino date not null,

)