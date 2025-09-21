DELIMITER //

CREATE OR ALTER TRIGGER change_cupo_grupo_horario
    AFTER DELETE ON Inscripcion_Detalle
    FOR EACH ROW
BEGIN
    -- Se actualiza el cupo disponible de acuerdo al Grupo que se acaba de eliminar el registro
    UPDATE Grupo_Horario
    SET disponibles = disponibles + 1, inscritos = inscritos - 1
    WHERE
        (id_periodo, abr_carr, id_plan, semestre, turno, no_grupo, no_materia) =
        (OLD.id_periodo, OLD.abr_carr, OLD.id_plan, OLD.semestre, OLD.turno, OLD.no_grupo, OLD.no_materia);

END //

DELIMITER ;