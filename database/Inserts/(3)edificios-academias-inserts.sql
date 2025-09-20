USE db_escolar;

INSERT INTO Edificio(desc_edificio, abr_edificio, id_inst) VALUES 
('Ingeniería', 'CI', 13),
('Ligeros', 'LL', 13),
('Pesados', 'LE', 13),
('Básicas', 'CB', 13),
('Sociales', 'CS', 13);

INSERT INTO Academia (nom_academia, id_edificio) VALUES
('Matemáticas', 4),
('Informática', 1),
('Fisica', 4),
('Computación', 1),
('Administración', 5),
('Humanidades y Ciencias Sociales', 4),
('Laboratorio de Electricidad y Control', 3),
('Producción', 1),
('Quimica', 4),
('Derecho', 5),
('Finanzas', 5),
('Mercadotecnia y Recursos Humanos', 5),
('Economia', 5),
('Tecnologia informatica', 5),
('Ciencias Basicas de la Ingenieria', 1),
('Ingeneria Industrial', 1),
('Investigacion de Operaciones', 1),
('Sistemas de Transporte', 1),
('Tecnologias Ferroviarias', 3),
('Laboratorios de Procesos de Manufactura', 3),
('Laboratorios de Control de Calidad', 3),
('Laboratorios de Ingenieria de Metodos', 3),
('Laboratorios de Sistemas Automotrices', 3),
('Laboratorios de Automatizacion y Robotica', 3);