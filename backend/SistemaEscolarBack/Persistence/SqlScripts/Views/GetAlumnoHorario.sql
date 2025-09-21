CREATE OR ALTER VIEW GetAlumnoHorario AS
	SELECT i.no_boleta, 
		i.id_periodo,
		CONCAT(g.semestre, g.abr_carr, g.turno, g.semestre, g.no_grupo) AS grupo,
		m.nom_materia,
        d.rfc,
		CONCAT(d.nom_doc, ' ', d.ap_doc, ' ', d.am_doc) AS nombre,
		CONCAT(mc.abr_carr, mc.semestre, mc.no_materia) AS clave,
		CONCAT(lun_i, '-', lun_f) AS lunes,
		CONCAT(mar_i, '-', mar_f) AS martes,
		CONCAT(mie_i, '-', mie_f) AS miercoles,
		CONCAT(jue_i, '-', jue_f) AS jue,
		CONCAT(vie_i, '-', vie_f) AS viernes
	FROM Inscripcion_Detalle i
	JOIN 
		Grupo_Horario g
	ON 
		(g.id_periodo, g.abr_carr, g.id_plan, g.semestre, g.turno, g.no_grupo, g.no_materia) = 
		(i.id_periodo, i.abr_carr, i.id_plan, i.semestre, i.turno, i.no_grupo, i.no_materia)
	JOIN 
		Mapa_Curricular mc
	ON 
		mc.semestre = i.semestre
	JOIN 
		Materia m
	ON 
		(m.id_materia = mc.id_materia AND
		mc.no_materia = i.no_materia)
	JOIN
		Docente_Horario dh
	ON 
		(g.id_periodo, g.abr_carr, g.id_plan, g.semestre, g.turno, g.no_grupo, g.no_materia) = 
		(dh.id_periodo, dh.abr_carr, dh.id_plan, dh.semestre, dh.turno, dh.no_grupo, dh.no_materia)
	JOIN
		Docente d
	ON
		d.rfc = dh.rfc
	JOIN
		Historial_Academico h 
	ON
		(h.no_boleta, h.id_plan) = (i.no_boleta, mc.id_plan);