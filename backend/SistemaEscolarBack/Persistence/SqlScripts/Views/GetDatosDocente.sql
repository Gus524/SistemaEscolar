CREATE OR REPLACE VIEW GetDatosDocente AS
	SELECT 	rfc,
			CONCAT(nom_doc, ' ', ap_doc, ' ', am_doc) AS nombre,
            email_p_doc,
            email_i_doc,
            tel_doc,
            calle,
            no_ext,
            no_int,
            colonia,
            delegacion,
            cp,
            a.nom_academia,
            e.desc_edificio
	FROM
		Docente d
	JOIN
		Academia a
	ON
		d.id_academia = a.id_academia
	JOIN
		Edificio e
	ON
		e.id_edificio = a.id_edificio;