CREATE OR REPLACE VIEW GetInicioAlumno AS
	SELECT CONCAT(a.nom_al, " ", a.ap_al, ' ', a.am_al) as nombre,
		   a.no_boleta,
		   i.id_inst,
		   i.nom_inst,
           c.desc_carr,
           p.id_plan
	FROM
		Alumno a
	JOIN
		Historial_Academico h
	ON
		h.no_boleta = a.no_boleta
	JOIN
		Plan_Estudios p
	ON 
		p.id_plan = h.id_plan
	JOIN
		Carrera c
	ON
		c.abr_carr = p.abr_carr
	JOIN
		Institucion i
	ON
		i.id_inst = c.id_inst;