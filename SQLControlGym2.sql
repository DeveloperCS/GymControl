create database controlGym
use controlGym
/*connectionString="Data Source=desktop-u31m1tb\ch_sql2;Initial Catalog=controlGym;Integrated Security=True"
 connectionString="Data Source=DESKTOP-G0LO2NQ\CH_SQL22;Initial Catalog=controlGym;Integrated Security=True"
*/
create table usuarios(

	id int identity(1,1) primary key,
	nombreUs varchar(50),
	usuario varchar (50),
	pass varbinary(max),
	tipoUs varchar(30)
)
INSERT into usuarios (nombreUs,usuario,pass,tipoUs)values('webAdmin','root', HASHBYTES('SHA2_512', 'admin'),'Administrador');
UPDATE usuarios SET nombreUs='Ramones',usuario='j1',pass=HASHBYTES('SHA2_512', '123'),tipoUs='Usuario' WHERE id=1
UPDATE usuarios SET usuario='josiel' WHERE id=1
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
update prom set nomPromocion = 'Mujer',descuento = 0.20 where idProm =2 
delete prom where idProm = 3
insert into prom values('Estudiantil',200)
select * from prom order by descuento
/*drop table prom*/
Select idProm as Id,nomPromocion as Promocion,descuento as Descuento from prom
/*truncate table prom*/

create table product(
	idProduc int identity (1,1) primary key,
	cod varchar(150)not null,
	nomProduc varchar(150) not null,
	stock int not null,
	precio decimal(5,2) not null
)
select idProduc as ID, nomProduc as Nombre, precio as Precio from product
create table ventas(
	cod varchar(150) not null,
	fechaVenta date not null,
	nomProduc varchar(150) not null,
	cantidad int not null,
	total decimal(5,2) not null
)

create trigger TR_Ventas
on ventas for insert
AS 
set nocount on
update product set product.stock = product.stock - inserted.cantidad from inserted
inner join product on product.cod = inserted.cod
select  idProduc as id, cod as Codiogo, nomProduc as Nombre, precio as Precio from product where stock !=0 and stock >0
select stock as s from product where idProduc = '3'

select *from ventas
select * from product
/*insertar en ventas referenciando el cod y checando que si haya en el stock*/
select cod as [Codigo del Producto], nomProduc as [Nombre del Producto], cantidad as [Cantidad], total as [Total], fechaVenta as [Fecha de la Venta] from ventas
insert into ventas values('PA-2',GETDATE(),'Porwer Ade',1,25)
delete from ventas
select stock as s from product where idProduc = 1

SELECT COUNT(nomProduc) FROM produc;
select * from produc
drop table ventas
insert into produc values('Agua 1Lt',10,10.50)
select idProduc as Id,nomProduc as Producto,cantidad as Cantidad,precio as Precio from produc
Update produc set nomProduc ='Coca',cantidad=12,precio=11.50 where idProduc = 2

create table memb(
  idMem int identity(1,1) primary key,
  nomMem varchar (150) not null,
  tipoPersona varchar(3)not null,
  precioMem decimal(5,2) default 0.00
)
insert memb values('Mensual','M',default)
insert memb values('Semanal','M',default)
insert memb values('Mensual','F',default)
insert memb values('Semanal','F',default)
select nomMem+'-'+tipoPersona from memb
drop table memb
select idMem as Id, nomMem as Membresia,precioMem as Precio from memb
Insert into memb values('Mensual',200,31)
update memb set nomMem='Mensual',precioMem=1 where idMem=1 
select * from memb order by precioMem
truncate table memb
Alter table memb add dias int not null


create table visitante(
	id int identity,
	cantidad int,
	fecha date
)
SELECT Sum(cantidad) as T FROM visitante
insert into visitante values(1,'08/07/2018')
insert into visitante values(1,SYSDATETIME()) 
SELECT Sum(cantidad) FROM visitante;
SELECT COUNT(id) FROM visitante where fecha =  CONVERT (date, SYSDATETIME())  

select count(id) from visitante where  MONTH(fecha) != Month(CONVERT (date, SYSDATETIME()))
truncate table visitante
SELECT MONTH('12/12/1996');




select * from visitante
select v.cantidad as Cantidad, v.fecha as [Fecha de ingreso] from visitante v
drop table visitante
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
create table socio(
	idSocio varchar(30) primary key not null,
	nombre varchar(225) not null,
	fNacimiento date not null,
	sexo varchar(3)not null,
	dir varchar(225)not null,
	tel varchar(11)not null,
	fb varchar (125)not null,
)
drop table socio
delete from socio
insert into socio values('S-JD91295465','Juan Dominguez','13/12/1996','M','Finisterre','8721395279','Juan Dominguez')
Select * from socio
Select idSocio as Clave, nombre as Nombre, fNacimiento as Fecha_Nacimiento, sexo as Sexo,dir as Direccion, tel as Telefono_de_Contacto, fb as Facebook  from socio
create table memSocio(
		idMemS varchar(30)  not null,
		tMem varchar(150)not null,
		fechaIngreso date not null,
		fechatermino date not null,
		prom varchar(150)not null,
		total decimal(5,2) not null,
		estado varchar(25) not null,
)
 alter table memSocio add idControl int
 drop table memSocio

 truncate table memSocio
 select *from memSocio
select cast( case when convert(varchar,fechatermino,103) >= convert(varchar,CONVERT (date, SYSDATETIME()) ,103) then '0' else '1' end as bit) C1 from memSocio where idMemS = 'S-CR1997'
select count(idMemS) from memSocio 
select  convert(varchar,fechatermino,103)from memSocio where idMemS = 'S-CR1997'
select convert(varchar,CONVERT (date, SYSDATETIME()),103)

drop table memSocio
insert into memSocio values('S-JD6232','Semanal','02/01/2018','02/02/2018','S/N',170.46,'Vigente',2);
select *from memsocio where idMems = 'S-PA3232'
select idControl as ID,idMemS as Clave, tMem as Tipo, fechaIngreso as Fecha_Inicial, fechatermino as Fecha_Final, total as Monto_Pagado, estado as Estatus from memSocio order  by Estatus desc
select M.idMemS as [Clave Socio/Memebresia],(select S.nombre as Nombre from socio S where S.idSocio=idMems) Socio, M.idControl as [ID Membresia],M.tMem as Tipo, M.fechaIngreso as Inicio,M.fechatermino as Termino, M.prom as Promocion, M.estado as Estatus from memSocio M  order by Socio
/*Para mostrar el historial*/
select * from memSocio where estado != 'Expirado'
select GETDATE()

select count(idMemS) as V, idMemS as id from memSocio where estado='Vigente'group by idMemS
select count(*) as Ex,idMemS as idEx from memSocio where estado = 'Expirado'group by idMemS
 select *from memSocio

 select Max(idControl) as C1 from memSocio
 update memSocio set fechatermino='2018/02/02' where idControl = '2' and idMemS ='S-CJ1996'
select M.idMemS as [Clave Socio/Memebresia],(select S.nombre as Nombre from socio S where S.idSocio=idMems) Socio, M.idControl as [ID Membresia],M.tMem as Tipo, M.fechaIngreso as Inicio,M.fechatermino as Termino, M.prom as Promocion, M.estado as Estatus from memSocio M  where M.estado = 'Expirado'

Select * from socio where idSocio = 'S-JD1996'
select count(*) as M, idMemS as d from memSocio group by idMemS
delete from  socio where idSocio = 'S-JD1996'
alter table memSocio ADD CONSTRAINT fk_socioMemsocio
foreign key(idMemS)references socio (idSocio)
	ON UPDATE CASCADE
	ON DELETE NO ACTION

/*alter table memSocio drop Column idM*/

create table historialS(
		idHS varchar(30) not null,
		nomSocio varchar(225) not null,
		tMem varchar(150)not null,
		fechaIngreso date not null,
		fechatermino date not null,
		prom varchar(150)not null,
		total decimal(5,2) not null,
		estado varchar(25) not null,
)
select *from historialS
select idHS as Clave from historialS
truncate table historialS 
select M.idHS as [Clave Socio/Memebresia],(select S.nombre as Nombre from socio S where S.idSocio=idHS) Socio,M.tMem as Tipo, M.fechaIngreso as Inicio,M.fechatermino as Termino, M.prom as Promocion from historialS M order by Socio
insert into historialS values()
drop table historialS


alter table historialS ADD CONSTRAINT fk_his
foreign key(idHS)references socio (idSocio)
	ON UPDATE CASCADE
	ON DELETE NO ACTION