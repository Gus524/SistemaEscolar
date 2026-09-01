CREATE OR REPLACE VIEW GetMapaCurricular AS
	SELECT CONCAT(mc.abr_carr, mc.semestre, mc.no_materia) AS clave, 
	   m.nom_materia, 
       m.tipo_materia,
       mc.creditos,
       m.horas_teoria,
       m.horas_prac,
       mc.abr_carr,
       p.id_plan,
       mc.semestre
	FROM
		Mapa_Curricular mc
	JOIN
		Materia m
	ON
		m.id_materia = mc.id_materia
	JOIN 
		Plan_Estudios p
	ON
		p.id_plan = mc.id_plan;