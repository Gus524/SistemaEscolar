CREATE OR REPLACE VIEW GetInformacionGrupo AS
	SELECT gh.semestre, 
		   gh.turno,
		   gh.no_grupo,
		   mc.abr_carr, 
           mc.no_materia,
           m.nom_materia,
           gh.disponibles,
           gh.cupo,
           gh.sobrecupo
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
		Periodo_Escolar p
	ON
		p.id_periodo = gh.id_periodo;