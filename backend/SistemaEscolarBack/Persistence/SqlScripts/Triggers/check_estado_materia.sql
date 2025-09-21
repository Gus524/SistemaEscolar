DELIMITER //

CREATE OR ALTER TRIGGER check_estado_materia
    AFTER UPDATE ON Historial_Detalle
    FOR EACH ROW
BEGIN
    -- Actualiza el promedio general del alumno
    UPDATE Historial_Academico SET
        promedio = (SELECT AVG(calificacion)
                    FROM Historial_Detalle
                    WHERE (no_boleta, id_plan) = (NEW.no_boleta, NEW.id_plan))
    WHERE (no_boleta, id_plan) = (NEW.no_boleta, NEW.id_plan);
END //

DELIMITER ;