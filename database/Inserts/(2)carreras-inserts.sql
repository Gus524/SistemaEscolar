USE db_escolar;

INSERT INTO Carrera (desc_carr, abr_carr, no_sem, id_inst, cred_total, max_semestres) VALUES
('Ingeniería Industrial', 'I', 8, 13, 273, 12),
('Ingeniería en Informática', 'N', 8, 13, 362, 12),
('Ingeniería en Transporte', 'T', 8, 13, 339, 12),
('Administración Industrial', 'A', 8, 13, 338, 12),
('Ciencias de la Informática', 'C', 8, 13, 300, 12);

INSERT INTO Plan_Estudios (desc_plan, no_plan, abr_carr) VALUES
('Plan 2020', 20, 'A'),
('Plan 2010', 10, 'A'),
('Plan 2021', 21, 'N'), 
('Plan 2010', 10, 'N'), 
('Plan 2021', 20, 'T'), 
('Plan 2010', 10, 'I'),
('Plan 2021', 21, 'I'); 