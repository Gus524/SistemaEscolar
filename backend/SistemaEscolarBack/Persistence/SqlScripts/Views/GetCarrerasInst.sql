CREATE OR ALTER VIEW GetCarrerasInst AS
	SELECT 
	   i.id_inst,
	   c.abr_carr,
       c.no_sem,
	   c.desc_carr AS carrera
	FROM
		Carrera c
	JOIN
		Institucion i
	ON
		i.id_inst = c.id_inst;