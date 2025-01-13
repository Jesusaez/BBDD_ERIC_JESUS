-- Crear la base de datos
CREATE DATABASE FundacionesDB;
GO

-- Usar la base de datos
USE FundacionesDB;
GO

-- Tabla Continente
CREATE TABLE Continente (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(100) NOT NULL
);

-- Tabla Pais
CREATE TABLE Pais (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    IDContinente INT NOT NULL,
    FOREIGN KEY (IDContinente) REFERENCES Continente(ID)
);

-- Tabla Ciutat
CREATE TABLE Ciutat (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    IDPais INT NOT NULL,
    FOREIGN KEY (IDPais) REFERENCES Pais(ID)
);

-- Tabla Fundacion
CREATE TABLE Fundacion (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(200) NOT NULL,
    Direccion NVARCHAR(MAX) NOT NULL,
    Telefono_Contacto NVARCHAR(20) NOT NULL,
    Email_Contacto NVARCHAR(200) NOT NULL,
    Link_Web NVARCHAR(MAX),
    HorarioVisita NVARCHAR(MAX),
    FotoWeb NVARCHAR(MAX),
    FotoRecinto NVARCHAR(MAX),
    IDContinent INT,
    IDPais INT,
    IDCiutat INT,
    FOREIGN KEY (IDContinent) REFERENCES Continente(ID),
    FOREIGN KEY (IDPais) REFERENCES Pais(ID),
    FOREIGN KEY (IDCiutat) REFERENCES Ciutat(ID)
);

-- Tabla Ressenya
CREATE TABLE Ressenya (
    ID_Ressenya INT PRIMARY KEY IDENTITY(1,1),
    ID_Fundacion INT NOT NULL,
    Valoracio INT NOT NULL CHECK (Valoracio BETWEEN 1 AND 5),
    Descripcio NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (ID_Fundacion) REFERENCES Fundacion(ID)
);

-- Tabla Categoria
CREATE TABLE Categoria (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

-- Tabla intermedia FundacionCategoria para la relación muchos a muchos
CREATE TABLE FundacionCategoria (
    ID INT PRIMARY KEY IDENTITY(1,1),
    FundacionID INT NOT NULL,
    CategoriaID INT NOT NULL,
    FOREIGN KEY (FundacionID) REFERENCES Fundacion(ID),
    FOREIGN KEY (CategoriaID) REFERENCES Categoria(ID)
);

-- Tabla GaleriaImagenes
CREATE TABLE GaleriaImagenes (
    ID INT PRIMARY KEY IDENTITY(1,1),
    FundacionID INT NOT NULL,
    Imagen NVARCHAR(MAX),
    Descripcion NVARCHAR(MAX),
    FOREIGN KEY (FundacionID) REFERENCES Fundacion(ID)
);
