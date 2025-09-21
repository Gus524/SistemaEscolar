DELIMITER //

CREATE OR ALTER TRIGGER update_historial_alumno
    AFTER INSERT ON Historial_Detalle
    FOR EACH ROW
BEGIN
    -- Actualiza el semestre mas alto cursado por el alumno
    IF NEW.semestre > (SELECT ultimo_semestre 
    FROM Historial_Academico 
		WHERE (no_boleta, id_plan) = (NEW.no_boleta, NEW.id_plan))
	THEN
    UPDATE Historial_Academico SET ultimo_semestre = NEW.semestre
    WHERE (no_boleta, id_plan) = (NEW.no_boleta, NEW.id_plan);
END IF;

-- Actualiza el promedio general del alumno
UPDATE Historial_Academico SET
    promedio = (SELECT AVG(calificacion)
                FROM Historial_Detalle
                WHERE (no_boleta, id_plan) = (NEW.no_boleta, NEW.id_plan))
WHERE (no_boleta, id_plan) = (NEW.no_boleta, NEW.id_plan);
END //

DELIMITER  ;