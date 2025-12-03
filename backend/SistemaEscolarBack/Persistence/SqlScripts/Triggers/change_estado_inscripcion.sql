DELIMITER //

CREATE TRIGGER change_estado_inscripcion
    AFTER INSERT ON Inscripcion_Detalle
    FOR EACH ROW
BEGIN
    -- Se actualiza el estado de la materia cuando un alumno se inscribe
    UPDATE Estado_General
    SET estado = 'EN CURSO'
    WHERE
        (id_plan, abr_carr, semestre, no_materia) =
        (NEW.id_plan, NEW.abr_carr, NEW.semestre, NEW.no_materia);
END //

DELIMITER ;