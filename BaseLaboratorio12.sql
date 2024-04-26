USE LAB12AD;
--------------------------------------------------------------
--CREACIÓN
--------------------------------------------------------------

CREATE TABLE REGION
(
	Id_Region int primary key identity(1,1),
	name varchar(20) unique not null
);

CREATE TABLE PLAYERUSER
(
	Id_PlayerUser int primary key identity(1,1),
	Id_Region int foreign key(Id_Region) references REGION(Id_Region) not null,
	username varchar(20) unique not null,
	email varchar(30) not null,
	password varchar(25) not null
);

CREATE TABLE SKIN
(
	Id_Skin int primary key identity(1,1),
	name varchar(20) not null,
	price smallmoney not null
);

CREATE TABLE INVENTORY
(
	Id_Inventory int primary key identity(1,1),
	Id_PlayerUser int foreign key(Id_PlayerUser) references PLAYERUSER(Id_PlayerUser) not null
);

CREATE TABLE COSMETIC
(
	Id_Cosmetic int primary key identity(1,1),
	Id_Inventory int foreign key(Id_Inventory) references INVENTORY(Id_Inventory) not null,
	Id_Skin int foreign key(Id_Skin) references SKIN(Id_Skin) not null
);

--------------------------------------------------------------
--INSERCIÓN
--------------------------------------------------------------

--REGIONES
--------------------------------------------------------------
--América del Norte (Chicago, Dallas, Miami, San José, Washington);
--América del Sur (São Paulo);
--Europa (Amsterdam, Moscú);
--Asia (Hong Kong, Singapur);
--Oceanía (Sydney).

INSERT INTO REGION (name)
VALUES
('NA-Chicago'),('NA-Dallas'),('NA-Miami'),('NA-San Jose'),('NA-Washington'),
('SA-Sao Paulo'),
('EU-Amsterdam'),('EU-Moscu'),
('AS-Hong Kong'),('AS-Singapur'),
('O-Sydney')

--SKINS
--------------------------------------------------------------
INSERT INTO SKIN (name, price)
VALUES
('Cyber Gunner', 10.99), ('Steel Shadow', 7.99), ('Volcano Fury', 4.99), ('Electronic Specter', 7.99), ('Shadow Titan', 4.99),
('Stellar Rainbow', 10.99), ('Soul Hunter', 7.99), ('Nano Runner', 4.99), ('World Breaker', 10.99), ('War Machine', 4.99)


--JUGADORES
--------------------------------------------------------------
INSERT INTO PLAYERUSER (username, email, password, Id_Region)
VALUES
('SteelSniper87', 'steel.sniper87@example.com', 'CyberBlaster123', 3),
('ShadowHacker', 'shadow.hacker@example.com', 'ShadowStealth456', 4),
('VolcanoFury', 'volcano.fury@example.com', 'LavaRage789', 11),
('StellarGunner', 'stellar.gunner@example.com', 'Starlight2022', 8),
('NanoAssassin', 'nano.assassin@example.com', 'QuantumStrike555', 7),
('TitanTanker', 'titan.tanker@example.com', 'IronWall777', 2),
('LightMage', 'light.mage@example.com', 'CelestialPower321', 3),
('SoulHunterX', 'soul.hunter@example.com', 'SpiritArrow999', 6),
('WarMachine', 'war.machine@example.com', 'BattleFury444', 1),
('CyberNinja', 'cyber.ninja@example.com', 'CodeKatana777', 11)

--INVENTARIOS
--------------------------------------------------------------
INSERT INTO INVENTORY (Id_PlayerUser)
VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8),
(9),
(10)

--COSMETICOS
--------------------------------------------------------------
INSERT INTO COSMETIC (Id_Inventory, Id_Skin)
VALUES
(1,1),
(2,5),
(3,7),
(4,9),
(5,5),
(6,2),
(7,4),
(8,6),
(9,8),
(10,2),
(5,1),
(7,9),
(9,10),
(2,6),
(1,4),
(8,8),
(3,7),
(4,2),
(6,6),
(1,7)

--------------------------------------------------------------
--------------------------------------------------------------

SELECT * FROM REGION
SELECT * FROM PLAYERUSER
SELECT * FROM SKIN
SELECT * FROM INVENTORY
SELECT * FROM COSMETIC

--------------------------------------------------------------
--Eliminación (Por emergencia)
--------------------------------------------------------------

--DROP TABLE COSMETIC;
--DROP TABLE INVENTORY;
--DROP TABLE SKIN;
--DROP TABLE PLAYERUSER;
--DROP TABLE REGION;
--------------------------------------------------------------
--------------------------------------------------------------