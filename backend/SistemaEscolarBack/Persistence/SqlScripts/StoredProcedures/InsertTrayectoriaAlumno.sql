DELIMITER //

CREATE PROCEDURE InsertTrayectoriaAlumno(
    IN boleta		BIGINT,
    IN plan			INT,
    IN carrera		CHAR(1)
)
BEGIN
	DECLARE done INT DEFAULT FALSE;
    DECLARE v_periodos_per INT;
    DECLARE v_cred_faltantes INT;
    
    DECLARE cur CURSOR FOR
SELECT cred_total, max_semestres
FROM Carrera
WHERE abr_carr = carrera;

DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

OPEN cur;

read_loop: LOOP
		FETCH cur INTO v_cred_faltantes, v_periodos_per;
		IF done THEN
			LEAVE read_loop;
END IF;

INSERT INTO Trayectoria_Alumno (per_disponibles, cred_faltantes, no_boleta, id_plan)
VALUES (v_periodos_per, v_cred_faltantes, boleta, plan);
END LOOP;

CLOSE cur;
END //

DELIMITER ;