--Usar Base de datos
USE FundacionesDB;
GO
-- Insertar datos en Continente
INSERT INTO Continente (Nom)
VALUES ('América'), ('Europa'), ('Asia'), ('África'), ('Oceanía');

-- Insertar datos en Pais
INSERT INTO Pais (Nombre, IDContinente)
VALUES 
('Estados Unidos', 1),
('España', 2),
('India', 3),
('Sudáfrica', 4),
('Australia', 5);

-- Insertar datos en Ciutat
INSERT INTO Ciutat (Nombre, IDPais)
VALUES
('Nueva York', 1),
('Madrid', 2),
('Mumbai', 3),
('Ciudad del Cabo', 4),
('Sídney', 5);

-- Insertar datos en Fundacion (fundaciones reales y ficticias)
INSERT INTO Fundacion (Nombre, Direccion, Telefono_Contacto, Email_Contacto, Link_Web, HorarioVisita, FotoWeb, FotoRecinto, IDContinent, IDPais, IDCiutat)
VALUES
('Cruz Roja Americana', '430 17th Street, Washington, DC', '1-800-733-2767', 'info@redcross.org', 'https://www.redcross.org', 'Lunes a Viernes: 9:00 - 17:00', NULL, NULL, 1, 1, 1),
('Fundación Vicente Ferrer', 'Anantapur, India', '+91 123-456-7890', 'info@fundacionvicenteferrer.org', 'https://fundacionvicenteferrer.org', 'Lunes a Sábado: 9:00 - 18:00', NULL, NULL, 3, 3, 3),
('WWF España', 'Gran Vía 15, Madrid', '+34 91 354 05 78', 'info@wwf.es', 'https://www.wwf.es', 'Lunes a Viernes: 10:00 - 19:00', NULL, NULL, 2, 2, 2),
('Save the Children Australia', '33 Lincoln Square South, Carlton VIC', '+61 3 7002 1600', 'info@savethechildren.org.au', 'https://www.savethechildren.org.au', 'Lunes a Viernes: 9:00 - 17:00', NULL, NULL, 5, 5, 5),
('Nelson Mandela Foundation', '107 Central Street, Houghton, Johannesburgo', '+27 11 547 5600', 'info@nelsonmandela.org', 'https://www.nelsonmandela.org', 'Lunes a Viernes: 8:00 - 16:30', NULL, NULL, 4, 4, 4),
-- Fundaciones ficticias
('Green Future Foundation', '123 Green St, Los Angeles', '555-123-4567', 'info@greenfuture.org', 'https://greenfuture.org', 'Lunes a Viernes: 10:00 - 18:00', NULL, NULL, 1, 1, 1),
('Tech for Good', 'Innovation Hub, Silicon Valley', '555-987-6543', 'contact@techforgood.org', 'https://techforgood.org', 'Lunes a Sábado: 9:00 - 18:00', NULL, NULL, 1, 1, 1),
('Fundación Paz Global', 'Avenida de la Paz 45, Madrid', '+34 91 123 45 67', 'contacto@pazglobal.org', 'https://pazglobal.org', 'Lunes a Viernes: 9:00 - 17:00', NULL, NULL, 2, 2, 2),
('Wildlife Rescue', '345 Safari Rd, Johannesburgo', '+27 21 345 6789', 'contact@wildliferescue.org', 'https://wildliferescue.org', 'Lunes a Domingo: 8:00 - 20:00', NULL, NULL, 4, 4, 4),
('Ocean Care Initiative', 'Beach St, Sídney', '+61 2 3456 7890', 'info@oceancare.org', 'https://oceancare.org', 'Todos los días: 8:00 - 18:00', NULL, NULL, 5, 5, 5);

-- Insertar datos en Categoria
INSERT INTO Categoria (Nombre)
VALUES
('Educación'),
('Salud'),
('Medio Ambiente'),
('Desarrollo Comunitario'),
('Ayuda Humanitaria');

-- Insertar datos en FundacionCategoria (relación muchas a muchas)
INSERT INTO FundacionCategoria (FundacionID, CategoriaID)
VALUES
(1, 2), (1, 5),
(2, 4), (2, 5),
(3, 3),
(4, 5),
(5, 2), (5, 4),
(6, 3), (6, 5),
(7, 1), (7, 4),
(8, 2), (8, 5),
(9, 3), (9, 5),
(10, 3), (10, 5);

-- Insertar datos en GaleriaImagenes
INSERT INTO GaleriaImagenes (FundacionID, Imagen, Descripcion)
VALUES
(1, NULL, 'Voluntarios en acción'),
(1, NULL, 'Entrega de suministros'),
(2, NULL, 'Actividades en India rural'),
(3, NULL, 'Conservación del medio ambiente'),
(4, NULL, 'Ayuda para niños'),
(5, NULL, 'Oficinas en Johannesburgo'),
(6, NULL, 'Campañas de reforestación'),
(7, NULL, 'Hackatón solidario'),
(8, NULL, 'Proyectos educativos en Madrid'),
(9, NULL, 'Rescate de animales salvajes'),
(10, NULL, 'Limpieza de playas en Australia');

-- Insertar datos en Ressenya
INSERT INTO Ressenya (ID_Fundacion, Valoracio, Descripcio)
VALUES
(1, 5, 'Increíble labor humanitaria en desastres'),
(2, 4, 'Gran impacto en las comunidades rurales'),
(3, 4, 'Conciencia ambiental muy necesaria'),
(4, 5, 'Un enfoque impresionante en la infancia'),
(5, 5, 'Un legado que sigue inspirando'),
(6, 3, 'Buen esfuerzo, pero podría ser más amplio'),
(7, 4, 'Innovador y solidario'),
(8, 5, 'Proyectos bien organizados y útiles'),
(9, 4, 'Importante en la conservación animal'),
(10, 5, 'Cuidado del océano muy comprometido');
