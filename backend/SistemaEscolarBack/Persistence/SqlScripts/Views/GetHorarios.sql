CREATE OR ALTER VIEW GetHorarios AS
	SELECT  CONCAT(d.nom_doc, ' ', d.ap_doc, ' ', d.am_doc) AS nombre,
            m.nom_materia AS materia,
            gh.semestre,
            gh.abr_carr, 
            gh.turno, 
            gh.no_grupo,
            gh.id_plan,
            gh.id_periodo,
            CONCAT(lun_i, '-', lun_f) AS lunes,
			CONCAT(mar_i, '-', mar_f) AS martes,
			CONCAT(mie_i, '-', mie_f) AS miercoles,
			CONCAT(jue_i, '-', jue_f) AS jue,
			CONCAT(vie_i, '-', vie_f) AS viernes,
            cupo,
            disponibles,
            sobrecupo,
            mc.no_materia,
            p.activo
	FROM
		Grupo_Horario gh
	JOIN
		Mapa_Curricular mc
	ON
		(mc.id_plan, mc.abr_carr, mc.semestre, mc.no_materia) =
        (gh.id_plan, gh.abr_carr, gh.semestre, gh.no_materia)
	JOIN
		Materia m
	ON
		m.id_materia = mc.id_materia
	JOIN
		Docente_Horario dh
	ON
		(dh.id_periodo, dh.abr_carr, dh.id_plan, dh.semestre, dh.turno, dh.no_grupo, dh.no_materia) =
        (gh.id_periodo, gh.abr_carr, gh.id_plan, gh.semestre, gh.turno, gh.no_grupo, gh.no_materia)
	JOIN
		Docente d
	ON
		d.rfc = dh.rfc
	JOIN
		Periodo_Escolar p
	ON
		p.id_periodo = gh.id_periodo;