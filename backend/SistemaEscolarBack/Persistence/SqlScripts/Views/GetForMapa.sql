CREATE OR REPLACE VIEW GetForMapa AS
	SELECT id_plan,
		   desc_plan AS plan,
           c.abr_carr
	FROM 
		Plan_Estudios p
	JOIN
		Carrera c
	ON
		c.abr_carr = p.abr_carr;