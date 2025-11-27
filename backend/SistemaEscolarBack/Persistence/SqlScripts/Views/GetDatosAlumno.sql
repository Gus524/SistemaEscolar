CREATE OR REPLACE VIEW GetDatosAlumno AS
	SELECT	a.no_boleta,
			CONCAT(a.nom_al, ' ', a.ap_al, ' ', a.am_al) AS nombre,
            a.email_p_alumno,
            a.email_i_alumno,
            CONCAT(REPEAT('*', LENGTH(a.curp) - 14), RIGHT(a.curp, 4)) AS curp,
            CONCAT(REPEAT('*', LENGTH(a.telf_alumno) - 6), RIGHT(a.telf_alumno, 4)) AS telf_alumno,
            CONCAT(REPEAT('*', LENGTH(a.telm_alumno) - 6), RIGHT(a.telm_alumno, 4)) AS telm_alumno,
            a.calle,
            a.no_ext,
            a.no_int,
            a.colonia,
            a.delegacion,
            a.cp,
            c.desc_carr,
            p.desc_plan,
            ha.promedio,
            i.nom_inst AS institucion
	FROM
		Alumno a
	JOIN
		Historial_Academico ha
	ON
		ha.no_boleta = a.no_boleta
	JOIN
		Plan_Estudios p
	ON
		p.id_plan = ha.id_plan
	JOIN
		Carrera c
	ON
		c.abr_carr = p.abr_carr
	JOIN
		Institucion i 
	ON
		i.id_inst = c.id_inst;