CREATE OR ALTER VIEW GetHistorialAlumno AS
	SELECT  a.no_boleta,
			CONCAT(nom_al, ' ', ap_al, ' ', am_al) AS nombre,
            desc_carr,
            desc_plan,
            p.id_plan,
            promedio,
            ultimo_semestre
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
		c.abr_carr = p.abr_carr;