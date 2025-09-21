CREATE OR ALTER VIEW GetAlumnoCalificaciones AS
	SELECT i.no_boleta, 
		i.id_plan,
		i.id_periodo,
		CONCAT(g.semestre, g.abr_carr, g.turno, g.semestre, g.no_grupo) AS grupo,
		m.nom_materia,
		CONCAT(mc.abr_carr, mc.semestre, mc.no_materia) AS clave,
        i.cal_parcial_1,
        i.cal_parcial_2,
        i.cal_parcial_3,
        i.cal_extra,
        i.cal_final
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
		Historial_Academico h 
	ON
		(h.no_boleta, h.id_plan) = (i.no_boleta, mc.id_plan)
	JOIN
		Periodo_Escolar p
	ON
		p.id_periodo = g.id_periodo
	WHERE
		p.activo = 1;