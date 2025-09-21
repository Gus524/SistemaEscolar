CREATE OR ALTER VIEW GetGruposDocente AS
	SELECT
			m.nom_materia,
            dh.id_periodo,
            CONCAT(mc.abr_carr, mc.semestre, mc.no_materia) AS clave,
            CONCAT(dh.semestre, dh.abr_carr, dh.turno, dh.semestre, dh.no_grupo) AS grupo,
            dh.rfc
	FROM
		Docente_Horario dh
	JOIN
		Grupo gh
	ON
		(gh.id_periodo, gh.abr_carr, gh.id_plan, gh.semestre, gh.turno, gh.no_grupo) = 
		(dh.id_periodo, dh.abr_carr, dh.id_plan, dh.semestre, dh.turno, dh.no_grupo)
	JOIN
		Mapa_Curricular mc
	ON
		(mc.id_plan, mc.abr_carr, mc.semestre, mc.no_materia) =
        (dh.id_plan, dh.abr_carr, dh.semestre, dh.no_materia)
	JOIN
		Materia m
	ON
		m.id_materia = mc.id_materia
	JOIN
		Periodo_Escolar p
	ON
		p.id_periodo = gh.id_periodo
	WHERE
		p.activo = 1;