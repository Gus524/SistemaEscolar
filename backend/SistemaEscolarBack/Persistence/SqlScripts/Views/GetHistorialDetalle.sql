CREATE OR REPLACE VIEW GetHistorialDetalle AS
	SELECT	CONCAT(mc.abr_carr, mc.semestre, mc.no_materia) AS clave,
			m.nom_materia,
            dh.fecha_eval,
            p.desc_periodo,
            dh.forma_eval,
            dh.calificacion,
            dh.id_plan,
            dh.no_boleta,
            mc.semestre
	FROM
		Historial_Detalle dh
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
		p.id_periodo = dh.id_periodo;