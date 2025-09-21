CREATE OR ALTER VIEW GetInicioGestion AS
	SELECT 	g.usuario,
			i.id_inst,
			i.nom_inst
	FROM
		Institucion i
	JOIN
		Gestion g
	ON
		i.id_inst = g.id_inst;