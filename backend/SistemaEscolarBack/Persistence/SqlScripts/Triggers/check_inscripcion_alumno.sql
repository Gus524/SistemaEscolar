DELIMITER //

CREATE OR ALTER TRIGGER check_inscripcion_alumno
BEFORE INSERT ON Inscripcion_Detalle
FOR EACH ROW
BEGIN
	-- Variable para almacenar el cupo
	DECLARE cupo_disponible INT;
    
    SELECT disponibles INTO cupo_disponible
		FROM Grupo_Horario
	WHERE 
		(id_periodo, abr_carr, id_plan, semestre, turno, no_grupo, no_materia) =
        (NEW.id_periodo, NEW.abr_carr, NEW.id_plan, NEW.semestre, NEW.turno, NEW.no_grupo, NEW.no_materia);
	-- Comprobar cupo disponible mayor a 0
    IF cupo_disponible <= 0 THEN
		-- Lanza un error para detener el insert y detiene la transaccion
        SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'No hay cupo disponible para el grupo seleccionado.';
	END IF;
    
    -- Si el cupo es suficiente se reduce el cupo disponible y se aumenta la cantidad de inscritos
    UPDATE Grupo_Horario
    SET disponibles = disponibles - 1, inscritos = inscritos + 1
    WHERE 
		(id_periodo, abr_carr, id_plan, semestre, turno, no_grupo, no_materia) =
        (NEW.id_periodo, NEW.abr_carr, NEW.id_plan, NEW.semestre, NEW.turno, NEW.no_grupo, NEW.no_materia);
END //

DELIMITER ;