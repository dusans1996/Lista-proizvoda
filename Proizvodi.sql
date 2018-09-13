CREATE TABLE Proizvod(
Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Naziv nvarchar(50) NOT NULL,
Opis nvarchar(100) NOT NULL,
Kategorija nvarchar(50) NOT NULL,
Proizvodjac nvarchar(50) NOT NULL,
Cena decimal(12,3) NOT NULL
);

INSERT INTO Proizvod VALUES('Laptop Dell Inspiron N4050','Inspiron N4050 Celeron B815 1,60 Ghz, 2GB DDR3/320GB 14 HD WLED, DVD-RW Wlan + BT, Inte HD graphics','Laptop','Dell','30999.25');
INSERT INTO Proizvod VALUES('Laptop Asus X55U-SX009D','X55U-SX009 AMD C-60 1.0GHz 4096MB 500GB DVDRW 15.6'' LED WXGA FreeDOS','Laptop','Asus','32990.12');
INSERT INTO Proizvod VALUES('Acer Aspire laptop E5-521G-47DX','Laptop Acer Aspire E5-521-49QU 15.6",AMD QC A4-6210/4GB/500GB/AMD Radeon R3','Laptop','Acer','41989.99');

INSERT INTO Proizvod VALUES('Acer tablet B1-730HD','Acer tablet B1-730HD 8GB','Tablet','Acer','11999.3');
INSERT INTO Proizvod VALUES('Asus tablet MeMO Pad 7','Asus tablet MeMO Pad 7 ME70C-1A003A','Tablet','Asus','12999.9');
INSERT INTO Proizvod VALUES('Goclever tablet','Goclever tablet ORION 70 L KB','Tablet','Goclever','5699.45');
