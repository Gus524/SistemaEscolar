DELIMITER //

CREATE OR ALTER PROCEDURE InsertEstadoAlumno(
    IN boleta	BIGINT,
    IN plan		INT,
    IN carrera 	CHAR(1)
)
BEGIN 
	DECLARE done INT DEFAULT FALSE;
    DECLARE v_semestre 		INT;
    DECLARE v_no_materia	CHAR (2);
    
    DECLARE cur CURSOR FOR
SELECT semestre, no_materia
FROM Mapa_Curricular
WHERE (abr_carr, id_plan) = (carrera, plan);

DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

OPEN cur;

read_loop: LOOP
		FETCH cur INTO v_semestre, v_no_materia;
        IF done THEN
			LEAVE read_loop;
END IF;

INSERT INTO Estado_General (no_boleta, abr_carr, semestre, id_plan, no_materia)
VALUES (boleta, carrera, v_semestre, plan, v_no_materia);
END LOOP;

CLOSE cur;
END //

DELIMITER ;