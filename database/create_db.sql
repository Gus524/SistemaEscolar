DROP DATABASE IF EXISTS db_escolar;
CREATE DATABASE  db_escolar;
USE db_escolar;

-- Escuelas que existen en la institucion (se puede adapatar aqui y agregar direccion)
CREATE TABLE Institucion (
	id_inst				INT PRIMARY KEY AUTO_INCREMENT,
    nom_inst			VARCHAR(128) NOT NULL,
    abreviatura			VARCHAR(20) NOT NULL,
    UNIQUE (nom_inst),
    UNIQUE (abreviatura)
);

CREATE TABLE Gestion (
	usuario				VARCHAR(64),
    id_inst				INT,
    FOREIGN KEY (id_inst) REFERENCES Institucion (id_inst)
);

-- Carreras que ofrece cada escuela con los detalles
CREATE TABLE Carrera (
    abr_carr			CHAR(1) PRIMARY KEY,
    desc_carr			VARCHAR(64) NOT NULL,
    no_sem				INT NOT NULL,
    max_semestres		INT,
    id_inst				INT NOT NULL,
    cred_total			INT NOT NULL,
    FOREIGN KEY (id_inst) REFERENCES Institucion(id_inst)
);

-- Plan de estudios para cada Carrera (pueden tener mas de uno)
CREATE TABLE Plan_Estudios (
    id_plan 			INT AUTO_INCREMENT PRIMARY KEY,
    desc_plan	 		VARCHAR(64) NOT NULL,
    no_plan				NUMERIC(3) NOT NULL, -- 20, 21, etc
    abr_carr			CHAR(1) NOT NULL,
    FOREIGN KEY (abr_carr) REFERENCES Carrera(abr_carr)
);

-- Edificios que existen en cada Escuela
CREATE TABLE Edificio (
    id_edificio 		INT AUTO_INCREMENT PRIMARY KEY,
    desc_edificio 		VARCHAR(64) NOT NULL,
    abr_edificio		CHAR(3) NOT NULL,
    id_inst				INT NOT NULL,
    FOREIGN KEY (id_inst) REFERENCES Institucion(id_inst)
);

-- Academias por edificio
CREATE TABLE Academia (
    id_academia 		INT AUTO_INCREMENT PRIMARY KEY,
    nom_academia 		VARCHAR(64) NOT NULL,
    id_edificio			INT NOT NULL,
    FOREIGN KEY (id_edificio) REFERENCES Edificio(id_edificio)
);

-- Materias que se imparten en todo el instituto
CREATE TABLE Materia (
    id_materia 			INT AUTO_INCREMENT PRIMARY KEY,
    tipo_materia 		VARCHAR(20) NOT NULL, -- Obligatoria u Optativa
    nom_materia 		VARCHAR(64) NOT NULL,
    horas_teoria		INT NOT NULL,
    horas_prac			INT NOT NULL,
    id_academia			INT NOT NULL,
    FOREIGN KEY (id_academia) REFERENCES Academia (id_academia)
    -- tiempo_auto		 	INT
);

-- Mapa curricular de cada plan de estudios
-- Llave compuesta de la carrera, el semestre, plan de estudios al que pertenece y una serie que empieza desde 01 por semestre
CREATE TABLE Mapa_Curricular (
	abr_carr			CHAR(1) NOT NULL,
    id_plan	 			INT NOT NULL,
    id_materia 			INT NOT NULL,
    semestre 			INT NOT NULL,
    creditos			INT NOT NULL,
    no_materia			CHAR(2) NOT NULL,
    PRIMARY KEY (id_plan, abr_carr, semestre, no_materia),
    FOREIGN KEY (id_plan) REFERENCES Plan_Estudios(id_plan),
    FOREIGN KEY (id_materia) REFERENCES Materia(id_materia),
    FOREIGN KEY (abr_carr) REFERENCES Carrera (abr_carr)
);

-- Docentes registrados en el sistema, cada docente pertenece a una academa (si un docente puede impartir clases en varias escuelas
-- Se debe agregar una tabla de apoyo para relacionar varios docentes en varias academias)
CREATE TABLE Docente (
    rfc 				VARCHAR(13) PRIMARY KEY,
    id_academia 		INT NOT NULL,
    nom_doc 			VARCHAR(64) NOT NULL,
    ap_doc 				VARCHAR(64) NOT NULL,
    am_doc	 			VARCHAR(64) NOT NULL,
    email_p_doc	 		VARCHAR(128),
    email_i_doc 		VARCHAR(128),
    tel_doc 			VARCHAR(10),
    calle				VARCHAR(64) NOT NULL,
    no_ext				VARCHAR(10) NOT NULL,
    no_int				VARCHAR(10) NOT NULL,
    colonia				VARCHAR(64) NOT NULL,
    delegacion			VARCHAR(64) NOT NULL,
    cp					NUMERIC(5) NOT NULL,
    FOREIGN KEY (id_academia) REFERENCES Academia(id_academia)
);

-- Periodos escolares (se puede adaptar a varios en un anio)
CREATE TABLE Periodo_Escolar (
    id_periodo 			INT PRIMARY KEY,
    desc_periodo 		VARCHAR(4) NOT NULL,  -- Ej: 24/1
    fecha_inicio		DATE,
    fecha_fin			DATE,
    activo				TINYINT(1) DEFAULT 0
    CHECK (activo IN(0, 1))
);

-- Grupos generados por plan de estudios (los planes de estudio ya tienen asignada una institucion)
CREATE TABLE Grupo (
	semestre 			INT NOT NULL,
    abr_carr			CHAR(1) NOT NULL,
    id_plan				INT NOT NULL,
    turno 				CHAR(1) NOT NULL,
    no_grupo 			INT NOT NULL,
    id_periodo 			INT NOT NULL,
    PRIMARY KEY (id_periodo, abr_carr, id_plan, semestre, turno, no_grupo),
    CHECK (turno IN('M', 'V')),
    FOREIGN KEY (abr_carr) REFERENCES Carrera(abr_carr),
    FOREIGN KEY (id_periodo) REFERENCES Periodo_Escolar(id_periodo)
);

-- Detalles de horario y materia para cada grupo creado
CREATE TABLE Grupo_Horario (
	semestre 			INT NOT NULL,
    abr_carr			CHAR(1) NOT NULL,
    turno 				CHAR(1) NOT NULL,
    no_grupo 			INT NOT NULL,
    id_periodo 			INT NOT NULL,
    no_materia 			CHAR (2) NOT NULL,
    id_plan				INT NOT NULL,
    cupo				INT DEFAULT 40,
    disponibles			INT DEFAULT 40,
    sobrecupo			INT DEFAULT 0,
    inscritos			INT DEFAULT 0,
	lun_i 				TIME,
    lun_f				TIME,
    lun_sal				VARCHAR(10),
    mar_i 				TIME,
    mar_f				TIME,
    mar_sal				VARCHAR(10),
    mie_i 				TIME,
    mie_f				TIME,
    mie_sal				VARCHAR(10),
    jue_i 				TIME,
    jue_f				TIME,
    jue_sal				VARCHAR(10),
    vie_i 				TIME,
    vie_f				TIME,
    vie_sal				VARCHAR(10),
    PRIMARY KEY (id_periodo, abr_carr, id_plan, semestre, turno, no_grupo, no_materia),
    FOREIGN KEY (id_periodo, abr_carr, id_plan, semestre, turno, no_grupo)
        REFERENCES Grupo (id_periodo, abr_carr, id_plan, semestre, turno, no_grupo),
    FOREIGN KEY (id_plan, abr_carr, semestre, no_materia) 
		REFERENCES Mapa_Curricular (id_plan, abr_carr, semestre, no_materia)
);

-- Relacion de los docentes con los horarios, se genera de manera aparte para materias que se puedan impartir por dos docentes
CREATE TABLE Docente_Horario (
	rfc					VARCHAR(13) NOT NULL,
    semestre 			INT NOT NULL,
    abr_carr			CHAR(1) NOT NULL,
    id_plan				INT NOT NULL,
    turno 				CHAR(1) NOT NULL,
    no_grupo 			INT NOT NULL,
    id_periodo 			INT NOT NULL,
    no_materia 			CHAR (2) NOT NULL,
    FOREIGN KEY (rfc) REFERENCES Docente (rfc),
    FOREIGN KEY (id_periodo, abr_carr, id_plan, semestre, turno, no_grupo, no_materia)
        REFERENCES Grupo_Horario (id_periodo, abr_carr, id_plan, semestre, turno, no_grupo, no_materia)
);

-- Alumnos registrados en el sistema
CREATE TABLE Alumno (
	no_boleta			BIGINT NOT NULL,
    nom_al 				VARCHAR(64) NOT NULL,
    ap_al 				VARCHAR(64) NOT NULL,
    am_al 				VARCHAR(64) NOT NULL,
    curp 				VARCHAR(20),
    email_p_alumno 		VARCHAR(128) NOT NULL,
    email_i_alumno 		VARCHAR(128),
    telf_alumno 		VARCHAR(12),
    telm_alumno 		VARCHAR(12),
    calle				VARCHAR(64) NOT NULL,
    no_ext				VARCHAR(10) NOT NULL,
    no_int				VARCHAR(10) NOT NULL,
    colonia				VARCHAR(64) NOT NULL,
    delegacion			VARCHAR(64) NOT NULL,
    cp					NUMERIC(5) NOT NULL,
    CONSTRAINT no_boleta PRIMARY KEY (no_boleta),
    CHECK (no_boleta >= 1000000000 AND no_boleta <= 9999999999)
);

-- Tabla que relaciona la carrera (plan de estudios) al que un alumno esta inscrito
-- Al hacerlo de esta manera permite que un alumno se registre en varias carreras
-- Permite mantener el historial si un alumno realizo un cambio de plan de estudios o cambio de carrera
CREATE TABLE Historial_Academico (
    no_boleta			BIGINT,
    id_plan				INT NOT NULL,
    promedio			FLOAT DEFAULT 0.0,
    ultimo_semestre		INT DEFAULT 0,
    PRIMARY KEY (no_boleta, id_plan),
    FOREIGN KEY (no_boleta) REFERENCES Alumno (no_boleta),
    FOREIGN KEY (id_plan) REFERENCES Plan_Estudios (id_plan)
);

-- Detalle de los historiales de cada alumno, se hace un nuevo registro cada que acaba un periodo escolar
-- O cuando se realiza un examen ETS
-- Como si fuera el Kardex
CREATE TABLE Historial_Detalle (
	calificacion		INT NOT NULL,
    forma_eval			VARCHAR(3),
    fecha_eval			DATE NOT NULL,
    id_periodo			INT NOT NULL,
    no_boleta			BIGINT NOT NULL,
    abr_carr			CHAR(1) NOT NULL,
    id_plan				INT NOT NULL,
    semestre			INT NOT NULL,
    no_materia			CHAR (2) NOT NULL,
    PRIMARY KEY (no_boleta, id_plan, semestre, no_materia),
    FOREIGN KEY (id_periodo) REFERENCES Periodo_Escolar (id_periodo),
    FOREIGN KEY (no_boleta, id_plan) 
		REFERENCES Historial_Academico (no_boleta, id_plan),
    FOREIGN KEY (id_plan, abr_carr, semestre, no_materia) 
		REFERENCES Mapa_Curricular (id_plan, abr_carr, semestre, no_materia),
	CHECK(forma_eval IN('ORD', 'REC', 'EXT', 'ETS', 'EQV'))
);

-- Tabla que mantiene un historial general del alumno, mostrando las materias que tiene reprobadas, no cursadas o desfasadas
CREATE TABLE Estado_General (
    estado				VARCHAR(10) DEFAULT 'NO CURSADA',
    no_boleta			BIGINT,
    abr_carr			CHAR(1) NOT NULL,
    semestre			INT NOT NULL,
    id_plan				INT NOT NULL,
    no_materia			CHAR(2) NOT NULL,
    FOREIGN KEY (no_boleta, id_plan) REFERENCES Historial_Academico (no_boleta, id_plan),
    FOREIGN KEY (id_plan, abr_carr, semestre, no_materia) 
		REFERENCES Mapa_Curricular (id_plan, abr_carr, semestre, no_materia),
	CHECK (estado IN ('REPROBADA', 'NO CURSADA', 'DESFASADA', 'CURSADA', 'EN CURSO'))
);

-- Trayectoria por creditos de un alumno, se mantiene la misma logica que del historial (revisar si puede resultar incluida en otra tabla)
CREATE TABLE Trayectoria_Alumno (
    per_cursados		INT DEFAULT 0,
    per_disponibles		INT,
    cred_permitidos		FLOAT DEFAULT 0,
    cred_faltantes		FLOAT,
    cred_obtenidos		FLOAT DEFAULT 0,
    no_boleta			BIGINT,
    id_plan				INT,
    FOREIGN KEY (no_boleta, id_plan) 
		REFERENCES Historial_Academico (no_boleta, id_plan)
);

-- Inscripciones de los alumnos, se genera una fecha para permitir la inscripcion al alumno
-- Agregar otro atributo para registrar la fecha en que el alumno se inscribio
CREATE TABLE Inscripcion (
    no_boleta 			BIGINT NOT NULL,
    id_periodo 			INT NOT NULL,
    id_plan				INT NOT NULL,
    fecha_inscripcion 	DATE NOT NULL,
    PRIMARY KEY (no_boleta, id_periodo, id_plan),
    FOREIGN KEY (no_boleta, id_plan) REFERENCES Historial_Academico(no_boleta, id_plan),
    FOREIGN KEY (id_periodo) REFERENCES Periodo_Escolar(id_periodo)
);

-- Relacion de Inscripcion y Grupo_Horario, se agregan las calificaciones de cada parcial y examen extraordinario para el
-- Registro de cada materia inscrita por el alumno
CREATE TABLE Inscripcion_Detalle (
    cal_parcial_1 		INT,
    cal_parcial_2 		INT,
    cal_parcial_3 		INT,
	cal_extra			INT, 
    cal_final 			INT,
    no_boleta			BIGINT,
    semestre 			INT NOT NULL,
    abr_carr			CHAR(1),
    turno 				CHAR(1),
    no_grupo 			INT NOT NULL,
    id_periodo 			INT NOT NULL,
    no_materia 			CHAR (2) NOT NULL,
    id_plan				INT NOT NULL,
    PRIMARY KEY (no_boleta, id_periodo, id_plan, abr_carr, semestre, turno, no_grupo, no_materia),
    FOREIGN KEY (no_boleta, id_periodo, id_plan)
		REFERENCES Inscripcion (no_boleta, id_periodo, id_plan),
    FOREIGN KEY (id_periodo, abr_carr, id_plan, semestre, turno, no_grupo, no_materia)
        REFERENCES Grupo_Horario (id_periodo, abr_carr, id_plan, semestre, turno, no_grupo, no_materia)
);

-- Tramites que realiza un alumno
CREATE TABLE Tramite (
	id_tramite			INT PRIMARY KEY AUTO_INCREMENT,
    tipo_tramite		VARCHAR(64),
    estado				VARCHAR(20) CHECK (estado IN ('EN PROCESO', 'ACEPTADO', 'RECHAZADO')),
    no_boleta			BIGINT, 
    FOREIGN KEY (no_boleta) REFERENCES Alumno (no_boleta)
);

-- Tabla de Examenes ETS junto con su horario y docente que lo aplicara
CREATE TABLE ETS (
	rfc					VARCHAR (13),
    abr_carr			CHAR(1),
    id_plan				INT,
    turno				CHAR(1),
    semestre			INT,
    no_materia			CHAR(2),
    dia					VARCHAR(8),
    hora_i				TIME,
    hora_fin			TIME,
    salon				VARCHAR(20),
	id_periodo			INT,
    ronda				INT,
    PRIMARY KEY (id_periodo, abr_carr, id_plan, ronda, semestre, turno, no_materia),
    FOREIGN KEY (rfc) REFERENCES Docente (rfc),
    FOREIGN KEY (id_periodo) REFERENCES Periodo_Escolar (id_periodo),
    FOREIGN KEY (id_plan, abr_carr, semestre, no_materia)
		REFERENCES Mapa_Curricular (id_plan, abr_carr, semestre, no_materia),
	CHECK (turno IN ('M', 'V')),
	CHECK (dia IN ('Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes')),
    CHECK (ronda IN (1, 2))
);

-- Tabla de Alumnos registrados a un ETS
CREATE TABLE Alumno_ETS (
	calificacion		INT,
	no_boleta			BIGINT,
	abr_carr			CHAR(1),
    id_plan				INT,
    turno				CHAR(1),
    semestre			INT,
    no_materia			CHAR(2),
    id_periodo			INT,
    ronda				INT,
	FOREIGN KEY (no_boleta) REFERENCES Alumno (no_boleta),
    FOREIGN KEY (id_periodo, abr_carr, id_plan, ronda, semestre, turno, no_materia)
		REFERENCES ETS (id_periodo, abr_carr, id_plan, ronda, semestre, turno, no_materia)
);

-- PENDIENTE
-- Tabla para registro de saberes previos
-- CREATE TABLE SPA (
-- 	calificacion		INT,
-- 	abr_carr			CHAR(1),
--     id_plan				INT,
--     turno				CHAR(1),
--     semestre			INT,
--     no_materia			CHAR(2),
-- 	FOREIGN KEY (abr_carr, semestre, id_plan, no_materia)
-- 		REFERENCES Mapa_Curricular (abr_carr, semestre, id_plan, no_materia)
-- );

