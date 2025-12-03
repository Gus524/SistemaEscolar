CREATE OR REPLACE VIEW GetAlumnosGrupo AS
	SELECT 	d.rfc,
			a.no_boleta,
			a.email_p_alumno,
			a.email_i_alumno,
            CONCAT(d.semestre, d.abr_carr, d.turno, d.semestre, d.no_grupo) AS grupo,
            CONCAT(d.abr_carr, d.semestre, d.no_materia) As clave,
			a.nom_al AS nombre, 
			a.ap_al AS ap,
			a.am_al AS am,
			id.cal_parcial_1,
			id.cal_parcial_2,
			id.cal_parcial_3,
			id.cal_extra,
			id.cal_final
	FROM 
		Inscripcion_Detalle id
	JOIN
		Docente_Horario d
	ON
		(d.id_periodo, d.abr_carr, d.id_plan, d.semestre, d.turno, d.no_grupo, d.no_materia) =
		(id.id_periodo, id.abr_carr, id.id_plan, id.semestre, id.turno, id.no_grupo, id.no_materia)
	JOIN 
		Alumno a 
	ON 
		a.no_boleta = id.no_boleta
	JOIN
		Periodo_Escolar p
	ON
		p.id_periodo = d.id_periodo
	WHERE 
		p.activo = 1;