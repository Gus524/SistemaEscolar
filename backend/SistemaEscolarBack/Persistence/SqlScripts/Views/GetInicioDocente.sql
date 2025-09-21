CREATE OR ALTER VIEW GetInicioDocente AS
	SELECT CONCAT(d.nom_doc, ' ', d.ap_doc, ' ', d.am_doc) AS nombre,
	   a.nom_academia,
       i.nom_inst,
       d.rfc,
       i.id_inst
	FROM
		Docente d
	JOIN
		Academia a 
	ON
		d.id_academia = a.id_academia
	JOIN
		Edificio e
	ON
		e.id_edificio = a.id_edificio
	JOIN
		Institucion i 
	ON
		e.id_inst = i.id_inst;