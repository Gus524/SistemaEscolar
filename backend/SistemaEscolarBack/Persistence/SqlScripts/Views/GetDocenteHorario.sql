CREATE OR REPLACE VIEW GetDocenteHorario AS
	SELECT 
		dh.id_periodo,
		CONCAT(d.nom_doc, ' ', d.ap_doc, ' ', d.am_doc) AS nombre,
		d.rfc,
        CONCAT(g.semestre, g.abr_carr, g.turno, g.semestre, g.no_grupo) AS grupo,
		CONCAT(mc.abr_carr, mc.semestre, mc.no_materia) AS clave,
        g.inscritos,
        m.nom_materia,
		CONCAT(lun_i, '-', lun_f) AS lunes,
		CONCAT(mar_i, '-', mar_f) AS martes,
		CONCAT(mie_i, '-', mie_f) AS miercoles,
		CONCAT(jue_i, '-', jue_f) AS jue,
		CONCAT(vie_i, '-', vie_f) AS viernes  
	FROM Docente d
	JOIN 
		Docente_Horario dh
	ON 
		dh.rfc = d.rfc
	JOIN 
		Grupo_Horario g
	ON
		(g.id_periodo, g.abr_carr, g.id_plan, g.semestre, g.turno, g.no_grupo, g.no_materia) = 
		(dh.id_periodo, dh.abr_carr, dh.id_plan, dh.semestre, dh.turno, dh.no_grupo, dh.no_materia)
	JOIN 
		Mapa_Curricular mc
	ON 
		(mc.id_plan, mc.abr_carr, mc.semestre, mc.no_materia) = 
        (g.id_plan, g.abr_carr, g.semestre, g.no_materia)
	JOIN 
		Materia m
	ON 
		m.id_materia = mc.id_materia
	JOIN
		Periodo_Escolar p
	ON
		p.id_periodo = dh.id_periodo
	WHERE 
		p.activo = 1;