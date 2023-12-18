CREATE DATABASE Albumes
GO
USE Albumes
GO

CREATE TABLE GENEROS
(
ID_GENERO INT,
GENERO VARCHAR(50)

CONSTRAINT PK_GENEROS PRIMARY KEY (ID_GENERO)
)
GO

CREATE TABLE DISCOGRAFICAS
(
ID_DISCOGRAFICA INT,
NOMBRE VARCHAR(50)

CONSTRAINT PK_DISCOGRAFICAS PRIMARY KEY (ID_DISCOGRAFICA)
)
GO

CREATE TABLE ALBUMES
(
ID_ALBUM INT,
NOMBRE VARCHAR(100),
AUTOR VARCHAR(100),
PUBLICACION DATE,
ID_GENERO INT,
ID_DISCOGRAFICA INT,
PRODUCTOR VARCHAR(100),
DURACION VARCHAR(8), --99:59:59 MAXIMO
VINILO BIT,
CD BIT,
CASETE BIT,
DIGITAL BIT,
STREAMING BIT

CONSTRAINT PK_ALBUMES PRIMARY KEY (ID_ALBUM)

CONSTRAINT FK_ALBUMES_GENEROS FOREIGN KEY (ID_GENERO)
REFERENCES GENEROS (ID_GENERO),

CONSTRAINT FK_ALBUMES_DISCOGRAFICAS FOREIGN KEY (ID_DISCOGRAFICA)
REFERENCES DISCOGRAFICAS (ID_DISCOGRAFICA)
)
GO

SET DATEFORMAT DMY
GO

INSERT INTO GENEROS (ID_GENERO,GENERO) VALUES 
(1,'New Wave'),
(2,'Pop rock'),
(3,'Art pop'),
(4,'Rock progresivo'),
(5,'Folk Rock'),
(6,'Indie'),
(7,'Rock alternativo'),
(8,'Math rock'),
(9,'Post-rock'),
(10,'Rock'),
(11,'Glam rock'),
(12,'Rock experimental');
GO

INSERT INTO DISCOGRAFICAS (ID_DISCOGRAFICA,NOMBRE) VALUES
(1,'Ariola'),
(2,'Universal Music Group'),
(3,'RCA'),
(4,'Sony Music'),
(5,'Talent/Microfon'),
(6,'UNDSCLSD LABEL'),
(7,'XL Recordings'),
(8,'Capitol Records'),
(9,'Be Happy Records'),
(10,'Polyvinyl'),
(11,'Self-released'),
(12,'Warner Bros. Records'),
(13,'Bizarro Records'),
(14,'Bakuretsu Records');
GO

INSERT INTO ALBUMES (ID_ALBUM,NOMBRE,AUTOR,PUBLICACION,ID_GENERO,ID_DISCOGRAFICA,PRODUCTOR,DURACION,VINILO,CD,CASETE,DIGITAL,STREAMING) VALUES
(1,'Clics Modernos','Charly Garcia','5/11/1983',1,1,'Charly Garcia y Joe Blaney','33:04',1,1,1,1,1),
(2,'Piano Bar','Charly Garcia','22/9/1984',2,2,'Charly Garcia y Joe Blaney','35:02',1,1,0,1,1),
(3,'Yendo de la cama al living','Charly Garcia','28/8/1982',3,2,'Charly Garcia','34:35',1,1,1,1,1),
(4,'Almendra','Almendra','29/11/1969',4,3,'Estudios TNT','37:35',1,1,1,1,1),
(5,'Almendra II','Almendra','9/12/1970',4,4,'Estudios TNT','79:00',1,1,1,1,1),
(6,'Artaud','Pescado Rabioso','26/06/1973',5,5,'Jorge Alvarez y Luis Alberto Spinetta','36:56',1,1,0,1,1),
(7,'Espuma','Duplat','4/9/2020',6,6,'Duplat','32:49',0,0,0,1,1),
(8,'In Rainbows','Radiohead','10/10/2007',7,7,'Nigel Godrich','42:39',1,1,0,1,1),
(9,'Pablo Honey','Radiohead','22/2/1993',7,8,'Sean Slade, Paul Q. Kolderie','42:11',0,1,1,0,1),
(10,'Some Kind of Cadwallader','Algernon Cadwallader','24/5/2008',8,9,'Chupacabra','38:40',1,1,0,1,1),
(11,'American Football','American Football','14/9/1999',9,10,'Brendan Gamble','40:52',0,1,0,0,1),
(12,'Apricot Princess','Rex Orange County','26/4/2017',10,11,'Rex Orange County, Ben Baptie, Jeff Kleinman, Two Inch Punch, Michael Uzowuru','39:30',1,1,0,1,1),
(13,'The Getaway','Red Hot Chili Peppers','17/6/2016',7,12,'Danger Mouse','53:48',1,1,0,1,1),
(14,'Raro','El Cuarteto de Nos','20/3/2006',7,13,'Juan Campodonico','45:19',1,1,0,1,1),
(15,'Porfiado','El Cuarteto de Nos','25/4/2012',7,12,'Juan Campodonico','49:21',1,1,0,1,1),
(16,'T H E','Tricot','2/10/2013',8,14,'Masayuki Nakano','48:18',1,1,0,1,1),
(17,'The Rise and Fall of Ziggy Stardust and the Spiders from Mars','David Bowie','16/6/1972',11,3,'Ken Scott, David Bowie','38:29',1,1,1,1,1),
(18,'Blackstar','David Bowie','8/1/2016',12,3,'David Bowie, Tony Visconti','39:17',1,1,0,1,1),
(19,'este cd no tiene nombre','Superheroes','1/1/2008',7,11,'Superheroes','33:10',0,0,0,0,1);
GO

/*
SELECT A.ID_ALBUM 'ID', A.NOMBRE 'NOMBRE', A.AUTOR 'AUTOR', A.PUBLICACION 'PUBLICACION', 
G.GENERO 'GENERO', D.NOMBRE 'DISCOGRAFICA', A.PRODUCTOR 'PRODUCTOR/ES', A.DURACION 'DURACION',
A.VINILO 'VINILO', A.CD 'CD', A.CASETE 'CASETE', A.DIGITAL 'DESCARGA DIGITAL', A.STREAMING 'STREAMING'
FROM ALBUMES A
JOIN GENEROS G ON G.ID_GENERO = A.ID_GENERO
JOIN DISCOGRAFICAS D ON D.ID_DISCOGRAFICA = A.ID_DISCOGRAFICA
ORDER BY 1 DESC
*/
