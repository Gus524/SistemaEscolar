CREATE OR ALTER VIEW GetEstadoGeneralAlumno AS
	SELECT 	e.no_boleta,
			e.id_plan,
			e.estado,
            m.nom_materia,
            a.nom_academia
	FROM
		Estado_General e
	JOIN
		Historial_Academico h 
	ON
		(e.no_boleta, e.id_plan) = (h.no_boleta, h.id_plan)
	JOIN
		Mapa_Curricular mc
	ON
		(e.id_plan, e.abr_carr, e.semestre, e.no_materia) =
        (mc.id_plan, mc.abr_carr, mc.semestre, mc.no_materia)
	JOIN 
		Materia m
	ON
		m.id_materia = mc.id_materia
	JOIN
		Academia a
	ON
		a.id_academia = m.id_academia;