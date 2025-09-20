USE db_escolar;

-- INSERTS SEMESTRE 1 grupo 1 informatica matutino
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 1, 'M', 1, '01', 40, '11:00:00', '13:00:00', NULL, NULL, '7:00:00', '9:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 1, 'M', 1, '02', 40, '09:00:00', '11:00:00', NULL, NULL, '9:00:00', '11:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 1, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 3),
('N', 242, 1, 'M', 1, '05', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 3),
('N', 242, 1, 'M', 1, '03', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 1, 'M', 1, '06', 40, NULL, NULL, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', 3),-- Miercoles y Viernes
('N', 242, 1, 'M', 1, '07', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 3); -- LUNES Y VIERNES
-- Grupo 2
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 1, 'M', 2, '01', 40, '10:00:00', '12:00:00', NULL, NULL, '8:00:00', '10:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 1, 'M', 2, '02', 40, '12:00:00', '14:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 3), -- LUNES Y MIERCOLES
('N', 242, 1, 'M', 2, '04', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 3),
('N', 242, 1, 'M', 2, '05', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 3),
('N', 242, 1, 'M', 2, '03', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 1, 'M', 2, '06', 40, NULL, NULL, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', 3),-- MIERCOLES Y VIERNES
('N', 242, 1, 'M', 2, '07', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 3); -- LUNES Y VIERNES

-- SEMESTRE 1 GRUPO 1 Informatica Vespertino
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 1, 'V', 1, '01', 40, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 1, 'V', 1, '02', 40, '19:00:00', '21:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 1, 'V', 1, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 3),
('N', 242, 1, 'V', 1, '05', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 3),
('N', 242, 1, 'V', 1, '03', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 1, 'V', 1, '06', 40, NULL, NULL, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', 3),-- Miercoles y Viernes
('N', 242, 1, 'V', 1, '07', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 3); -- LUNES Y VIERNES
-- Grupo 2
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 1, 'V', 2, '01', 40, '16:00:00', '18:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 1, 'V', 2, '02', 40, '18:00:00', '20:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, 3), -- LUNES Y MIERCOLES
('N', 242, 1, 'V', 2, '04', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 3),
('N', 242, 1, 'V', 2, '05', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 3),
('N', 242, 1, 'V', 2, '03', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 1, 'V', 2, '06', 40, NULL, NULL, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', 3),-- MIERCOLES Y VIERNES
('N', 242, 1, 'V', 2, '07', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 3); -- LUNES Y VIERNES    

-- SEMESTRE 2 Grupo 1 Informatica Matutino
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 2, 'M', 1, '01', 40, '12:00:00', '14:00:00', NULL, NULL, '7:00:00', '9:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 2, 'M', 1, '02', 40, '10:00:00', '12:00:00', NULL, NULL, '9:00:00', '11:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 2, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 3),
('N', 242, 2, 'M', 1, '05', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 3),
('N', 242, 2, 'M', 1, '03', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 2, 'M', 1, '06', 40, NULL, NULL, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', 3),-- Miercoles y Viernes
('N', 242, 2, 'M', 1, '07', 40, '07:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3), -- LUNES
('N', 242, 2, 'M', 1, '08', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '12:00:00', 3); -- VIERNES

-- Grupo 2
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 2, 'M', 2, '01', 40, '11:00:00', '13:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 2, 'M', 2, '02', 40, '09:00:00', '11:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 3), -- LUNES Y MIERCOLES
('N', 242, 2, 'M', 2, '04', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 3),
('N', 242, 2, 'M', 2, '05', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 3),
('N', 242, 2, 'M', 2, '03', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 2, 'M', 2, '06', 40, NULL, NULL, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', 3),-- MIERCOLES Y VIERNES
('N', 242, 2, 'M', 2, '07', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3), -- LUNES
('N', 242, 2, 'M', 2, '08', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 3); -- VIERNES


-- SEMESTRE 2 GRUPO 1 INFORMATICA VESPERTINO
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 2, 'V', 1, '01', 40, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 2, 'V', 1, '02', 40, '19:00:00', '21:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 2, 'V', 1, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 3),
('N', 242, 2, 'V', 1, '05', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 3),
('N', 242, 2, 'V', 1, '03', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 2, 'V', 1, '06', 40, NULL, NULL, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', 3),-- Miercoles y Viernes
('N', 242, 2, 'V', 1, '07', 40, '14:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3), -- LUNES
('N', 242, 2, 'V', 1, '08', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '20:00:00', 3); -- VIERNES

-- Grupo 2
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 2, 'V', 2, '01', 40, '16:00:00', '18:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 2, 'V', 2, '02', 40, '18:00:00', '20:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, 3), -- LUNES Y MIERCOLES
('N', 242, 2, 'V', 2, '04', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 3),
('N', 242, 2, 'V', 2, '05', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 3),
('N', 242, 2, 'V', 2, '03', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 2, 'V', 2, '06', 40, NULL, NULL, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', 3),-- MIERCOLES Y VIERNES
('N', 242, 2, 'V', 2, '07', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 3); -- LUNES

-- INSERTS SEMESTRE 3 grupo 1 informatica matutino
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 3, 'M', 1, '02', 40, '09:00:00', '11:00:00', NULL, NULL, '9:00:00', '11:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 3, 'M', 1, '01', 40, '11:00:00', '13:00:00', NULL, NULL, '7:00:00', '9:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 3, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 3),
('N', 242, 3, 'M', 1, '05', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 3),
('N', 242, 3, 'M', 1, '03', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 3, 'M', 1, '06', 40, NULL, NULL, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', 3),-- Miercoles y Viernes
('N', 242, 3, 'M', 1, '07', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 3); -- LUNES Y VIERNES

-- Grupo 2
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 3, 'M', 2, '01', 40, '10:00:00', '12:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 3, 'M', 2, '02', 40, '08:00:00', '10:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 3), -- LUNES Y MIERCOLES
('N', 242, 3, 'M', 2, '04', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 3),
('N', 242, 3, 'M', 2, '05', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 3),
('N', 242, 3, 'M', 2, '03', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 3, 'M', 2, '06', 40, NULL, NULL, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', 3),-- MIERCOLES Y VIERNES
('N', 242, 3, 'M', 2, '07', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 3); -- LUNES Y VIERNES

-- SEMESTRE 3 GRUPO 1 Informatica Vespertino
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 3, 'V', 1, '01', 40, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 3, 'V', 1, '02', 40, '19:00:00', '21:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 3, 'V', 1, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 3),
('N', 242, 3, 'V', 1, '05', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 3),
('N', 242, 3, 'V', 1, '03', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 3, 'V', 1, '06', 40, NULL, NULL, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', 3),-- Miercoles y Viernes
('N', 242, 3, 'V', 1, '07', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 3); -- LUNES Y VIERNES

-- Grupo 2
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 3, 'V', 2, '01', 40, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 3, 'V', 2, '02', 40, '19:00:00', '21:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 3, 'V', 2, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 3),
('N', 242, 3, 'V', 2, '05', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 3),
('N', 242, 3, 'V', 2, '03', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 3, 'V', 2, '06', 40, NULL, NULL, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', 3),-- Miercoles y Viernes
('N', 242, 3, 'V', 2, '07', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 3); -- LUNES Y VIERNES

-- INSERTS SEMESTRE 4 grupo 1 informatica matutino
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 4, 'M', 1, '02', 40, '09:00:00', '11:00:00', NULL, NULL, '9:00:00', '11:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 4, 'M', 1, '01', 40, '11:00:00', '13:00:00', NULL, NULL, '7:00:00', '9:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 4, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 3),
('N', 242, 4, 'M', 1, '05', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 3),
('N', 242, 4, 'M', 1, '03', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 4, 'M', 1, '06', 40, NULL, NULL, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', 3),-- Miercoles y Viernes
('N', 242, 4, 'M', 1, '07', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 3); -- LUNES Y VIERNES

-- Grupo 2
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 4, 'M', 2, '01', 40, '10:00:00', '12:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 4, 'M', 2, '02', 40, '08:00:00', '10:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 3), -- LUNES Y MIERCOLES
('N', 242, 4, 'M', 2, '04', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 3),
('N', 242, 4, 'M', 2, '05', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 3),
('N', 242, 4, 'M', 2, '03', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 4, 'M', 2, '06', 40, NULL, NULL, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', 3),-- MIERCOLES Y VIERNES
('N', 242, 4, 'M', 2, '07', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 3); -- LUNES Y VIERNES

-- SEMESTRE 4 GRUPO 1 Informatica Vespertino
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 4, 'V', 1, '01', 40, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 4, 'V', 1, '02', 40, '19:00:00', '21:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 4, 'V', 1, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 3),
('N', 242, 4, 'V', 1, '05', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 3),
('N', 242, 4, 'V', 1, '03', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 4, 'V', 1, '06', 40, NULL, NULL, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', 3),-- Miercoles y Viernes
('N', 242, 4, 'V', 1, '07', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 3); -- LUNES Y VIERNES

-- Grupo 2
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 4, 'V', 2, '01', 40, '16:00:00', '18:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 4, 'V', 2, '02', 40, '18:00:00', '20:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, 3), -- LUNES Y MIERCOLES
('N', 242, 4, 'V', 2, '04', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 3),
('N', 242, 4, 'V', 2, '05', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 3),
('N', 242, 4, 'V', 2, '03', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 4, 'V', 2, '06', 40, NULL, NULL, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', 3),-- Miercoles y Viernes
('N', 242, 4, 'V', 2, '07', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 3); -- LUNES Y VIERNES

-- INSERTS SEMESTRE 5 grupo 1 informatica matutino
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 5, 'M', 1, '02', 40, '09:00:00', '11:00:00', NULL, NULL, '9:00:00', '11:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 5, 'M', 1, '01', 40, '11:00:00', '13:00:00', NULL, NULL, '7:00:00', '9:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 5, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 3),
('N', 242, 5, 'M', 1, '05', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 3),
('N', 242, 5, 'M', 1, '03', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 5, 'M', 1, '06', 40, NULL, NULL, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', 3),-- Miercoles y Viernes
('N', 242, 5, 'M', 1, '07', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 3); -- LUNES Y VIERNES

-- Grupo 2
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 5, 'M', 2, '01', 40, '10:00:00', '12:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 5, 'M', 2, '02', 40, '08:00:00', '10:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 3), -- LUNES Y MIERCOLES
('N', 242, 5, 'M', 2, '04', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 3),
('N', 242, 5, 'M', 2, '05', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 3),
('N', 242, 5, 'M', 2, '03', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 5, 'M', 2, '06', 40, NULL, NULL, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', 3),-- MIERCOLES Y VIERNES
('N', 242, 5, 'M', 2, '07', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 3); -- LUNES Y VIERNES

-- SEMESTRE 5 GRUPO 1 Informatica Vespertino
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 5, 'V', 1, '01', 40, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 5, 'V', 1, '02', 40, '19:00:00', '21:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 242, 5, 'V', 1, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 3),
('N', 242, 5, 'V', 1, '05', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 3),
('N', 242, 5, 'V', 1, '03', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 5, 'V', 1, '06', 40, NULL, NULL, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', 3),-- Miercoles y Viernes
('N', 242, 5, 'V', 1, '07', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 3); -- LUNES Y VIERNES

-- Grupo 2
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 5, 'V', 2, '01', 40, '16:00:00', '18:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, 3),
('N', 242, 5, 'V', 2, '02', 40, '18:00:00', '20:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, 3), -- LUNES Y MIERCOLES
('N', 242, 5, 'V', 2, '04', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 3),
('N', 242, 5, 'V', 2, '05', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 3),
('N', 242, 5, 'V', 2, '03', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 242, 5, 'V', 2, '06', 40, NULL, NULL, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', 3),-- MIERCOLES Y VIERNES
('N', 242, 5, 'V', 2, '07', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 3); -- LUNES Y VIERNES

-- OPTATIVAS
INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 242, 5, 'M', 7, '08', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '13:00:00', '15:00:00', 3),
('N', 242, 5, 'M', 8, '09', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '13:00:00', '15:00:00', 3),
('N', 242, 5, 'M', 9, '10', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '13:00:00', '15:00:00', 3),
('N', 242, 5, 'V', 7, '08', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '19:00:00', '22:00:00', 3),
('N', 242, 5, 'V', 8, '09', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '19:00:00', '22:00:00', 3),
('N', 242, 5, 'V', 9, '10', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '19:00:00', '22:00:00', 3);

-- Semestre 1 - Ingeniería Industrial - Matutino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 1, 'M', 1, '01', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 7), -- LUNES Y VIERNES
('I', 242, 1, 'M', 1, '02', 40, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, NULL, NULL, 7), -- LUNES Y MIERCOLES
('I', 242, 1, 'M', 1, '03', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 7), -- MARTES Y JUEVES
('I', 242, 1, 'M', 1, '04', 40, NULL, NULL, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', 7), -- MIERCOLES Y VIERNES
('I', 242, 1, 'M', 1, '05', 40, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, NULL, NULL, 7), -- LUNES Y MIERCOLES
('I', 242, 1, 'M', 1, '06', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 7), -- MARTES Y JUEVES
('I', 242, 1, 'M', 1, '07', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 7); -- MARTES Y JUEVES

-- Semestre 1 - Ingeniería Industrial - Matutino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 1, 'M', 2, '01', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 7),
('I', 242, 1, 'M', 2, '02', 40, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 1, 'M', 2, '03', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 7),
('I', 242, 1, 'M', 2, '04', 40, NULL, NULL, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', 7),
('I', 242, 1, 'M', 2, '05', 40, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 1, 'M', 2, '06', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 7),
('I', 242, 1, 'M', 2, '07', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 7);

-- Semestre 1 - Ingeniería Industrial - Vespertino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 1, 'V', 1, '01', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 7),
('I', 242, 1, 'V', 1, '02', 40, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 1, 'V', 1, '03', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 7),
('I', 242, 1, 'V', 1, '04', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', 7),
('I', 242, 1, 'V', 1, '05', 40, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 1, 'V', 1, '06', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 7),
('I', 242, 1, 'V', 1, '07', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 7);

-- Semestre 1 - Ingeniería Industrial - Vespertino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 1, 'V', 2, '01', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 7),
('I', 242, 1, 'V', 2, '02', 40, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 1, 'V', 2, '03', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 7),
('I', 242, 1, 'V', 2, '04', 40, NULL, NULL, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', 7),
('I', 242, 1, 'V', 2, '05', 40, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 1, 'V', 2, '06', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 7),
('I', 242, 1, 'V', 2, '07', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 7);

-- Semestre 2 - Ingeniería Industrial - Matutino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 2, 'M', 1, '01', 40, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 2, 'M', 1, '02', 40, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '07:00:00', '09:00:00', 7),
('I', 242, 2, 'M', 1, '03', 40, '09:00:00', '11:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 7),
('I', 242, 2, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 7),
('I', 242, 2, 'M', 1, '05', 40, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 2, 'M', 1, '06', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 7),
('I', 242, 2, 'M', 1, '07', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 7),
('I', 242, 2, 'M', 1, '08', 40, NULL, NULL, NULL, NULL, '13:00:00', '15:00:00', NULL, NULL, '11:00:00', '13:00:00', 7);

-- Semestre 2 - Ingeniería Industrial - Matutino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 2, 'M', 2, '01', 40, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 2, 'M', 2, '02', 40, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '08:00:00', '10:00:00', 7),
('I', 242, 2, 'M', 2, '03', 40, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 7),
('I', 242, 2, 'M', 2, '04', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 7),
('I', 242, 2, 'M', 2, '05', 40, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 2, 'M', 2, '06', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 7),
('I', 242, 2, 'M', 2, '07', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 7),
('I', 242, 2, 'M', 2, '08', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '12:00:00', '14:00:00', 7);

-- Semestre 2 - Ingeniería Industrial - Vespertino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 2, 'V', 1, '01', 40, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 2, 'V', 1, '02', 40, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '14:00:00', '16:00:00', 7),
('I', 242, 2, 'V', 1, '03', 40, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 7),
('I', 242, 2, 'V', 1, '04', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 7),
('I', 242, 2, 'V', 1, '05', 40, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 2, 'V', 1, '06', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 7),
('I', 242, 2, 'V', 1, '07', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 7),
('I', 242, 2, 'V', 1, '08', 40, NULL, NULL, NULL, NULL, '20:00:00', '22:00:00', NULL, NULL, '18:00:00', '20:00:00', 7);

-- Semestre 2 - Ingeniería Industrial - Vespertino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 2, 'V', 2, '01', 40, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 2, 'V', 2, '02', 40, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', 7),
('I', 242, 2, 'V', 2, '03', 40, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 7),
('I', 242, 2, 'V', 2, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 7),
('I', 242, 2, 'V', 2, '05', 40, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 2, 'V', 2, '06', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 7),
('I', 242, 2, 'V', 2, '07', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 7),
('I', 242, 2, 'V', 2, '08', 40, NULL, NULL, NULL, NULL, '21:00:00', '23:00:00', NULL, NULL, '19:00:00', '21:00:00', 7);

-- Semestre 3 - Ingeniería Industrial - Matutino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 3, 'M', 1, '01', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 7),
('I', 242, 3, 'M', 1, '02', 40, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 3, 'M', 1, '03', 40, NULL, NULL, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', 7),
('I', 242, 3, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 7),
('I', 242, 3, 'M', 1, '05', 40, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 3, 'M', 1, '06', 40, NULL, NULL, NULL, NULL, '13:00:00', '15:00:00', NULL, NULL, '11:00:00', '13:00:00', 7),
('I', 242, 3, 'M', 1, '07', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 7),
('I', 242, 3, 'M', 1, '08', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 7),
('I', 242, 3, 'M', 1, '09', 40, '13:00:00', '15:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '13:00:00', '15:00:00', 7),
('I', 242, 3, 'M', 1, '10', 40, NULL, NULL, '13:00:00', '15:00:00', NULL, NULL, '13:00:00', '15:00:00', NULL, NULL, 7);

-- Semestre 3 - Ingeniería Industrial - Matutino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 3, 'M', 2, '01', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 7),
('I', 242, 3, 'M', 2, '02', 40, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 3, 'M', 2, '03', 40, NULL, NULL, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', 7),
('I', 242, 3, 'M', 2, '04', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 7),
('I', 242, 3, 'M', 2, '05', 40, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 3, 'M', 2, '06', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '12:00:00', '14:00:00', 7),
('I', 242, 3, 'M', 2, '07', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 7),
('I', 242, 3, 'M', 2, '08', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 7),
('I', 242, 3, 'M', 2, '09', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', 7),
('I', 242, 3, 'M', 2, '10', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 7);

-- Semestre 3 - Ingeniería Industrial - Vespertino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 3, 'V', 1, '01', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 7),
('I', 242, 3, 'V', 1, '02', 40, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 3, 'V', 1, '03', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', 7),
('I', 242, 3, 'V', 1, '04', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 7),
('I', 242, 3, 'V', 1, '05', 40, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 3, 'V', 1, '06', 40, NULL, NULL, NULL, NULL, '20:00:00', '22:00:00', NULL, NULL, '18:00:00', '20:00:00', 7),
('I', 242, 3, 'V', 1, '07', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 7),
('I', 242, 3, 'V', 1, '08', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 7),
('I', 242, 3, 'V', 1, '09', 40, '20:00:00', '22:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '20:00:00', '22:00:00', 7),
('I', 242, 3, 'V', 1, '10', 40, NULL, NULL, '20:00:00', '22:00:00', NULL, NULL, '20:00:00', '22:00:00', NULL, NULL, 7);

-- Semestre 3 - Ingeniería Industrial - Vespertino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 3, 'V', 2, '01', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 7),
('I', 242, 3, 'V', 2, '02', 40, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 3, 'V', 2, '03', 40, NULL, NULL, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', 7),
('I', 242, 3, 'V', 2, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 7),
('I', 242, 3, 'V', 2, '05', 40, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 3, 'V', 2, '06', 40, NULL, NULL, NULL, NULL, '21:00:00', '23:00:00', NULL, NULL, '19:00:00', '21:00:00', 7),
('I', 242, 3, 'V', 2, '07', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 7),
('I', 242, 3, 'V', 2, '08', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 7),
('I', 242, 3, 'V', 2, '09', 40, '21:00:00', '23:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '21:00:00', '23:00:00', 7),
('I', 242, 3, 'V', 2, '10', 40, NULL, NULL, '21:00:00', '23:00:00', NULL, NULL, '21:00:00', '23:00:00', NULL, NULL, 7);

-- Semestre 4 - Ingeniería Industrial - Matutino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 4, 'M', 1, '01', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 7),
('I', 242, 4, 'M', 1, '02', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 7),
('I', 242, 4, 'M', 1, '03', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 7),
('I', 242, 4, 'M', 1, '04', 40, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 4, 'M', 1, '05', 40, NULL, NULL, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', 7),
('I', 242, 4, 'M', 1, '06', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 7),
('I', 242, 4, 'M', 1, '07', 40, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 4, 'M', 1, '08', 40, NULL, NULL, NULL, NULL, NULL, NULL, '13:00:00', '15:00:00', '11:00:00', '13:00:00', 7),
('I', 242, 4, 'M', 1, '09', 40, NULL, NULL, '13:00:00', '15:00:00', NULL, NULL, '13:00:00', '15:00:00', NULL, NULL, 7);

-- Semestre 4 - Ingeniería Industrial - Matutino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 4, 'M', 2, '01', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 7),
('I', 242, 4, 'M', 2, '02', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 7),
('I', 242, 4, 'M', 2, '03', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 7),
('I', 242, 4, 'M', 2, '04', 40, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 4, 'M', 2, '05', 40, NULL, NULL, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', 7),
('I', 242, 4, 'M', 2, '06', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 7),
('I', 242, 4, 'M', 2, '07', 40, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 4, 'M', 2, '08', 40, NULL, NULL, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', '12:00:00', '14:00:00', 7),
('I', 242, 4, 'M', 2, '09', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 7);

-- Semestre 4 - Ingeniería Industrial - Vespertino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 4, 'V', 1, '01', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 7),
('I', 242, 4, 'V', 1, '02', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 7),
('I', 242, 4, 'V', 1, '03', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 7),
('I', 242, 4, 'V', 1, '04', 40, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 4, 'V', 1, '05', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', 7),
('I', 242, 4, 'V', 1, '06', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 7),
('I', 242, 4, 'V', 1, '07', 40, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 4, 'V', 1, '08', 40, NULL, NULL, NULL, NULL, NULL, NULL, '20:00:00', '22:00:00', '18:00:00', '20:00:00', 7),
('I', 242, 4, 'V', 1, '09', 40, NULL, NULL, '20:00:00', '22:00:00', NULL, NULL, '20:00:00', '22:00:00', NULL, NULL, 7);

-- Semestre 4 - Ingeniería Industrial - Vespertino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 4, 'V', 2, '01', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 7),
('I', 242, 4, 'V', 2, '02', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 7),
('I', 242, 4, 'V', 2, '03', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 7),
-- Semestre 4 - Ingeniería Industrial - Vespertino - Grupo 2 (Continuación)
('I', 242, 4, 'V', 2, '04', 40, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 4, 'V', 2, '05', 40, NULL, NULL, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', 7),
('I', 242, 4, 'V', 2, '06', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 7),
('I', 242, 4, 'V', 2, '07', 40, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 4, 'V', 2, '08', 40, NULL, NULL, NULL, NULL, NULL, NULL, '21:00:00', '23:00:00', '19:00:00', '21:00:00', 7),
('I', 242, 4, 'V', 2, '09', 40, NULL, NULL, '21:00:00', '23:00:00', NULL, NULL, '21:00:00', '23:00:00', NULL, NULL, 7);

-- Semestre 5 - Ingeniería Industrial - Matutino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 5, 'M', 1, '01', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 7),
('I', 242, 5, 'M', 1, '02', 40, NULL, NULL, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', 7),
('I', 242, 5, 'M', 1, '03', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 7),
('I', 242, 5, 'M', 1, '04', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 7),
('I', 242, 5, 'M', 1, '05', 40, '09:00:00', '11:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '11:00:00', '13:00:00', 7),
('I', 242, 5, 'M', 1, '06', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 7),
('I', 242, 5, 'M', 1, '07', 40, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 5, 'M', 1, '08', 40, NULL, NULL, NULL, NULL, '13:00:00', '15:00:00', NULL, NULL, '13:00:00', '15:00:00', 7),
('I', 242, 5, 'M', 1, '09', 40, NULL, NULL, '13:00:00', '15:00:00', NULL, NULL, '13:00:00', '15:00:00', NULL, NULL, 7),
('I', 242, 5, 'M', 1, '10', 40, '13:00:00', '15:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '15:00:00', '17:00:00', 7);

-- Semestre 5 - Ingeniería Industrial - Matutino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 5, 'M', 2, '01', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 7),
('I', 242, 5, 'M', 2, '02', 40, NULL, NULL, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', 7),
('I', 242, 5, 'M', 2, '03', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 7),
('I', 242, 5, 'M', 2, '04', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 7),
('I', 242, 5, 'M', 2, '05', 40, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '12:00:00', '14:00:00', 7),
('I', 242, 5, 'M', 2, '06', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 7),
('I', 242, 5, 'M', 2, '07', 40, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 5, 'M', 2, '08', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', 7),
('I', 242, 5, 'M', 2, '09', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 7),
('I', 242, 5, 'M', 2, '10', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 7);

-- Semestre 5 - Ingeniería Industrial - Vespertino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 5, 'V', 1, '01', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 7),
('I', 242, 5, 'V', 1, '02', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', 7),
('I', 242, 5, 'V', 1, '03', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 7),
('I', 242, 5, 'V', 1, '04', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 7),
('I', 242, 5, 'V', 1, '05', 40, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '18:00:00', '20:00:00', 7),
('I', 242, 5, 'V', 1, '06', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 7),
('I', 242, 5, 'V', 1, '07', 40, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 5, 'V', 1, '08', 40, NULL, NULL, NULL, NULL, '20:00:00', '22:00:00', NULL, NULL, '20:00:00', '22:00:00', 7),
('I', 242, 5, 'V', 1, '09', 40, NULL, NULL, '20:00:00', '22:00:00', NULL, NULL, '20:00:00', '22:00:00', NULL, NULL, 7),
('I', 242, 5, 'V', 1, '10', 40, '20:00:00', '22:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '22:00:00', '24:00:00', 7);

-- Semestre 5 - Ingeniería Industrial - Vespertino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('I', 242, 5, 'V', 2, '01', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 7),
('I', 242, 5, 'V', 2, '02', 40, NULL, NULL, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', 7),
('I', 242, 5, 'V', 2, '03', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 7),
('I', 242, 5, 'V', 2, '04', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 7),
('I', 242, 5, 'V', 2, '05', 40, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '19:00:00', '21:00:00', 7),
('I', 242, 5, 'V', 2, '06', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 7),
('I', 242, 5, 'V', 2, '07', 40, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, NULL, NULL, 7),
('I', 242, 5, 'V', 2, '08', 40, NULL, NULL, NULL, NULL, '21:00:00', '23:00:00', NULL, NULL, '21:00:00', '23:00:00', 7),
('I', 242, 5, 'V', 2, '09', 40, NULL, NULL, '21:00:00', '23:00:00', NULL, NULL, '21:00:00', '23:00:00', NULL, NULL, 7),
('I', 242, 5, 'V', 2, '10', 40, '21:00:00', '23:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '23:00:00', '24:00:00', 7);

-- Semestre 1 - Ingeniería en Transporte - Matutino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 1, 'M', 1, '01', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 5), -- LUNES Y VIERNES
('T', 242, 1, 'M', 1, '02', 40, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, NULL, NULL, 5), -- LUNES Y MIERCOLES
('T', 242, 1, 'M', 1, '03', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 1, 'M', 1, '04', 40, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, NULL, NULL, 5), -- LUNES Y MIERCOLES
('T', 242, 1, 'M', 1, '05', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 1, 'M', 1, '06', 40, NULL, NULL, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', 5), -- MIERCOLES Y VIERNES
('T', 242, 1, 'M', 1, '07', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 5); -- MARTES Y JUEVES

-- Semestre 1 - Ingeniería en Transporte - Matutino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 1, 'M', 2, '01', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 5),
('T', 242, 1, 'M', 2, '02', 40, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 1, 'M', 2, '03', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 5),
('T', 242, 1, 'M', 2, '04', 40, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 1, 'M', 2, '05', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 5),
('T', 242, 1, 'M', 2, '06', 40, NULL, NULL, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', 5),
('T', 242, 1, 'M', 2, '07', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 5);

-- Semestre 1 - Ingeniería en Transporte - Vespertino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 1, 'V', 1, '01', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 5),
('T', 242, 1, 'V', 1, '02', 40, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 1, 'V', 1, '03', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 5),
('T', 242, 1, 'V', 1, '04', 40, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 1, 'V', 1, '05', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 5),
('T', 242, 1, 'V', 1, '06', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', 5),
('T', 242, 1, 'V', 1, '07', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 5);

-- Semestre 1 - Ingeniería en Transporte - Vespertino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 1, 'V', 2, '01', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 5),
('T', 242, 1, 'V', 2, '02', 40, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 1, 'V', 2, '03', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 5),
('T', 242, 1, 'V', 2, '04', 40, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 1, 'V', 2, '05', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 5),
('T', 242, 1, 'V', 2, '06', 40, NULL, NULL, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', 5),
('T', 242, 1, 'V', 2, '07', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 5);

-- Semestre 2 - Ingeniería en Transporte - Matutino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 2, 'M', 1, '01', 40, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, 5), -- LUNES Y MIERCOLES
('T', 242, 2, 'M', 1, '02', 40, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '07:00:00', '09:00:00', 5), -- MIERCOLES Y VIERNES
('T', 242, 2, 'M', 1, '03', 40, '09:00:00', '11:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 5), -- LUNES Y VIERNES
('T', 242, 2, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 2, 'M', 1, '05', 40, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, NULL, NULL, 5), -- LUNES Y MIERCOLES
('T', 242, 2, 'M', 1, '06', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 2, 'M', 1, '07', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 5); -- MARTES Y JUEVES

-- Semestre 2 - Ingeniería en Transporte - Matutino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 2, 'M', 2, '01', 40, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 2, 'M', 2, '02', 40, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '08:00:00', '10:00:00', 5),
('T', 242, 2, 'M', 2, '03', 40, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 5),
('T', 242, 2, 'M', 2, '04', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 5),
('T', 242, 2, 'M', 2, '05', 40, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 2, 'M', 2, '06', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 5),
('T', 242, 2, 'M', 2, '07', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 5);

-- Semestre 2 - Ingeniería en Transporte - Vespertino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 2, 'V', 1, '01', 40, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 2, 'V', 1, '02', 40, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '14:00:00', '16:00:00', 5),
('T', 242, 2, 'V', 1, '03', 40, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 5),
('T', 242, 2, 'V', 1, '04', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 5),
('T', 242, 2, 'V', 1, '05', 40, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 2, 'V', 1, '06', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 5),
('T', 242, 2, 'V', 1, '07', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 5);

-- Semestre 2 - Ingeniería en Transporte - Vespertino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 2, 'V', 2, '01', 40, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 2, 'V', 2, '02', 40, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', 5),
('T', 242, 2, 'V', 2, '03', 40, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 5),
('T', 242, 2, 'V', 2, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 5),
('T', 242, 2, 'V', 2, '05', 40, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 2, 'V', 2, '06', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 5),
('T', 242, 2, 'V', 2, '07', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 5);

-- Semestre 3 - Ingeniería en Transporte - Matutino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 3, 'M', 1, '01', 40, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, 5), -- LUNES Y MIERCOLES
('T', 242, 3, 'M', 1, '02', 40, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '07:00:00', '09:00:00', 5), -- MIERCOLES Y VIERNES
('T', 242, 3, 'M', 1, '03', 40, '09:00:00', '11:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 5), -- LUNES Y VIERNES
('T', 242, 3, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 3, 'M', 1, '05', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 3, 'M', 1, '06', 40, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, NULL, NULL, 5), -- LUNES Y MIERCOLES
('T', 242, 3, 'M', 1, '07', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 3, 'M', 1, '08', 40, NULL, NULL, NULL, NULL, '13:00:00', '15:00:00', NULL, NULL, '11:00:00', '13:00:00', 5); -- MIERCOLES Y VIERNES

-- Semestre 3 - Ingeniería en Transporte - Matutino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 3, 'M', 2, '01', 40, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 3, 'M', 2, '02', 40, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '08:00:00', '10:00:00', 5),
('T', 242, 3, 'M', 2, '03', 40, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 5),
('T', 242, 3, 'M', 2, '04', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 5),
('T', 242, 3, 'M', 2, '05', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 5),
('T', 242, 3, 'M', 2, '06', 40, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 3, 'M', 2, '07', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 5),
('T', 242, 3, 'M', 2, '08', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '12:00:00', '14:00:00', 5);

-- Semestre 3 - Ingeniería en Transporte - Vespertino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 3, 'V', 1, '01', 40, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 3, 'V', 1, '02', 40, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '14:00:00', '16:00:00', 5),
('T', 242, 3, 'V', 1, '03', 40, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 5),
('T', 242, 3, 'V', 1, '04', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 5),
('T', 242, 3, 'V', 1, '05', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 5),
('T', 242, 3, 'V', 1, '06', 40, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 3, 'V', 1, '07', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 5),
('T', 242, 3, 'V', 1, '08', 40, NULL, NULL, NULL, NULL, '20:00:00', '22:00:00', NULL, NULL, '18:00:00', '20:00:00', 5);

-- Semestre 3 - Ingeniería en Transporte - Vespertino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 3, 'V', 2, '01', 40, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 3, 'V', 2, '02', 40, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', 5),
('T', 242, 3, 'V', 2, '03', 40, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 5),
('T', 242, 3, 'V', 2, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 5),
('T', 242, 3, 'V', 2, '05', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 5),
('T', 242, 3, 'V', 2, '06', 40, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 3, 'V', 2, '07', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 5),
('T', 242, 3, 'V', 2, '08', 40, NULL, NULL, NULL, NULL, '21:00:00', '23:00:00', NULL, NULL, '19:00:00', '21:00:00', 5);

-- Semestre 4 - Ingeniería en Transporte - Matutino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 4, 'M', 1, '01', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 4, 'M', 1, '02', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 5), -- LUNES Y VIERNES
('T', 242, 4, 'M', 1, '03', 40, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, NULL, NULL, 5), -- LUNES Y MIERCOLES
('T', 242, 4, 'M', 1, '04', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 4, 'M', 1, '05', 40, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, NULL, NULL, 5), -- LUNES Y MIERCOLES
('T', 242, 4, 'M', 1, '06', 40, NULL, NULL, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', 5), -- MIERCOLES Y VIERNES
('T', 242, 4, 'M', 1, '07', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 5); -- MARTES Y JUEVES

-- Semestre 4 - Ingeniería en Transporte - Matutino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 4, 'M', 2, '01', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 5),
('T', 242, 4, 'M', 2, '02', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 5),
('T', 242, 4, 'M', 2, '03', 40, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 4, 'M', 2, '04', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 5),
('T', 242, 4, 'M', 2, '05', 40, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 4, 'M', 2, '06', 40, NULL, NULL, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', 5),
('T', 242, 4, 'M', 2, '07', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 5);

-- Semestre 4 - Ingeniería en Transporte - Vespertino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 4, 'V', 1, '01', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 5),
('T', 242, 4, 'V', 1, '02', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 5),
('T', 242, 4, 'V', 1, '03', 40, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 4, 'V', 1, '04', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 5),
('T', 242, 4, 'V', 1, '05', 40, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 4, 'V', 1, '06', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', 5),
('T', 242, 4, 'V', 1, '07', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 5);

-- Semestre 4 - Ingeniería en Transporte - Vespertino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 4, 'V', 2, '01', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 5),
('T', 242, 4, 'V', 2, '02', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 5),
('T', 242, 4, 'V', 2, '03', 40, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 4, 'V', 2, '04', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 5),
('T', 242, 4, 'V', 2, '05', 40, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 4, 'V', 2, '06', 40, NULL, NULL, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', 5),
('T', 242, 4, 'V', 2, '07', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 5);

-- Semestre 5 - Ingeniería en Transporte - Matutino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 5, 'M', 1, '01', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 5), -- LUNES Y VIERNES
('T', 242, 5, 'M', 1, '02', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 5, 'M', 1, '03', 40, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, NULL, NULL, 5), -- LUNES Y MIERCOLES
('T', 242, 5, 'M', 1, '04', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 5, 'M', 1, '05', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 5), -- MARTES Y JUEVES
('T', 242, 5, 'M', 1, '06', 40, '11:00:00', '13:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, NULL, NULL, 5), -- LUNES Y MIERCOLES
('T', 242, 5, 'M', 1, '07', 40, NULL, NULL, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '07:00:00', '09:00:00', 5); -- MIERCOLES Y VIERNES

-- Semestre 5 - Ingeniería en Transporte - Matutino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 5, 'M', 2, '01', 40, '08:00:00', '10:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '10:00:00', '12:00:00', 5),
('T', 242, 5, 'M', 2, '02', 40, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, 5),
('T', 242, 5, 'M', 2, '03', 40, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 5, 'M', 2, '04', 40, NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, '10:00:00', '12:00:00', NULL, NULL, 5),
('T', 242, 5, 'M', 2, '05', 40, NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, 5),
('T', 242, 5, 'M', 2, '06', 40, '12:00:00', '14:00:00', NULL, NULL, '12:00:00', '14:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 5, 'M', 2, '07', 40, NULL, NULL, NULL, NULL, '08:00:00', '10:00:00', NULL, NULL, '08:00:00', '10:00:00', 5);

-- Semestre 5 - Ingeniería en Transporte - Vespertino - Grupo 1
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 5, 'V', 1, '01', 40, '14:00:00', '16:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '16:00:00', '18:00:00', 5),
('T', 242, 5, 'V', 1, '02', 40, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, 5),
('T', 242, 5, 'V', 1, '03', 40, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 5, 'V', 1, '04', 40, NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, '16:00:00', '18:00:00', NULL, NULL, 5),
('T', 242, 5, 'V', 1, '05', 40, NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, 5),
('T', 242, 5, 'V', 1, '06', 40, '18:00:00', '20:00:00', NULL, NULL, '18:00:00', '20:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 5, 'V', 1, '07', 40, NULL, NULL, NULL, NULL, '14:00:00', '16:00:00', NULL, NULL, '14:00:00', '16:00:00', 5);

-- Semestre 5 - Ingeniería en Transporte - Vespertino - Grupo 2
INSERT INTO Grupo_Horario (abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan) VALUES
('T', 242, 5, 'V', 2, '01', 40, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '19:00:00', 5),
('T', 242, 5, 'V', 2, '02', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 5),
('T', 242, 5, 'V', 2, '03', 40, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 5, 'V', 2, '04', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 5),
('T', 242, 5, 'V', 2, '05', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 5),
('T', 242, 5, 'V', 2, '06', 40, '19:00:00', '21:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, NULL, NULL, 5),
('T', 242, 5, 'V', 2, '07', 40, NULL, NULL, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '15:00:00', '17:00:00', 5);

INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 221, 1, 'M', 1, '01', 40, '11:00:00', '13:00:00', NULL, NULL, '7:00:00', '9:00:00', NULL, NULL, NULL, NULL, 3),
('N', 221, 1, 'M', 1, '02', 40, '09:00:00', '11:00:00', NULL, NULL, '9:00:00', '11:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 221, 1, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 3),
('N', 221, 1, 'M', 1, '05', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 3),
('N', 221, 1, 'M', 1, '03', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 221, 1, 'M', 1, '06', 40, NULL, NULL, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', 3),-- Miercoles y Viernes
('N', 221, 1, 'M', 1, '07', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 3); -- LUNES Y VIERNES

INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 222, 1, 'M', 1, '01', 40, '11:00:00', '13:00:00', NULL, NULL, '7:00:00', '9:00:00', NULL, NULL, NULL, NULL, 3),
('N', 222, 1, 'M', 1, '02', 40, '09:00:00', '11:00:00', NULL, NULL, '9:00:00', '11:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 222, 1, 'M', 1, '04', 40, NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, 3),
('N', 222, 1, 'M', 1, '05', 40, NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, '09:00:00', '11:00:00', NULL, NULL, 3),
('N', 222, 1, 'M', 1, '03', 40, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 222, 1, 'M', 1, '06', 40, NULL, NULL, NULL, NULL, '11:00:00', '13:00:00', NULL, NULL, '07:00:00', '09:00:00', 3),-- Miercoles y Viernes
('N', 222, 1, 'M', 1, '07', 40, '07:00:00', '09:00:00', NULL, NULL, NULL, NULL, NULL, NULL, '09:00:00', '11:00:00', 3); -- LUNES Y VIERNES

INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 222, 2, 'V', 1, '01', 40, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 3),
('N', 222, 2, 'V', 1, '02', 40, '19:00:00', '21:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 222, 2, 'V', 1, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 3),
('N', 222, 2, 'V', 1, '05', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 3),
('N', 222, 2, 'V', 1, '03', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 222, 2, 'V', 1, '06', 40, NULL, NULL, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', 3),-- Miercoles y Viernes
('N', 222, 2, 'V', 1, '07', 40, '14:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3), -- LUNES
('N', 222, 2, 'V', 1, '08', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '17:00:00', '20:00:00', 3); -- VIERNES


INSERT INTO Grupo_Horario 
(abr_carr, id_periodo, semestre, turno, no_grupo, no_materia, cupo, lun_i, lun_f, mar_i, mar_f, mie_i, mie_f, jue_i, jue_f, vie_i, vie_f, id_plan)
VALUES
('N', 231, 3, 'V', 1, '01', 40, '17:00:00', '19:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, NULL, NULL, 3),
('N', 231, 3, 'V', 1, '02', 40, '19:00:00', '21:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, NULL, NULL, 3), -- lUNES Y MIERCOLES
('N', 231, 3, 'V', 1, '04', 40, NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, 3),
('N', 231, 3, 'V', 1, '05', 40, NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, '17:00:00', '19:00:00', NULL, NULL, 3),
('N', 231, 3, 'V', 1, '03', 40, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', NULL, NULL, 3),-- MARTES Y JUEVES
('N', 231, 3, 'V', 1, '06', 40, NULL, NULL, NULL, NULL, '19:00:00', '21:00:00', NULL, NULL, '15:00:00', '17:00:00', 3),-- Miercoles y Viernes
('N', 231, 3, 'V', 1, '07', 40, '14:00:00', '17:00:00', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3); -- LUNES
