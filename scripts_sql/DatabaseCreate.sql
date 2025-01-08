--create database M6Fundacions
--use M6Fundacions

-- Creaci�n de la tabla Fundaci�n
CREATE TABLE Fundacion (
    Id VARCHAR(255) PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    Direccion VARCHAR(255),
    Pais VARCHAR(100),
    Ciudad VARCHAR(100),
    TelefonoContacto VARCHAR(50),
    EmailContacto VARCHAR(100),
    Ressenya TEXT,
    Valoracion INT CHECK (Valoracion BETWEEN 1 AND 5),
    Foto VARCHAR(255),
    LinkWeb VARCHAR(255),
    HorarioVisita VARCHAR(255)
);

-- Creaci�n de la tabla Categor�a
CREATE TABLE Categoria (
    Id VARCHAR(255) PRIMARY KEY,
    NombreCategoria VARCHAR(255) NOT NULL
);

-- Creaci�n de la tabla Galer�a de Im�genes
CREATE TABLE GaleriaImagenes (
    Id VARCHAR(255) PRIMARY KEY,
    FundacionId VARCHAR(255),
    Imagen VARCHAR(255),
    Descripcion TEXT,
    FOREIGN KEY (FundacionId) REFERENCES Fundacion(Id) ON DELETE CASCADE
);

-- Relaci�n entre Fundaci�n y Categor�a (muchos a muchos)
CREATE TABLE FundacionCategoria (
    FundacionId VARCHAR(255),
    CategoriaId VARCHAR(255),
    PRIMARY KEY (FundacionId, CategoriaId),
    FOREIGN KEY (FundacionId) REFERENCES Fundacion(Id) ON DELETE CASCADE,
    FOREIGN KEY (CategoriaId) REFERENCES Categoria(Id) ON DELETE CASCADE
);
