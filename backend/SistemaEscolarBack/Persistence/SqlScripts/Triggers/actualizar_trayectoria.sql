DELIMITER //

CREATE TRIGGER actualizar_trayectoria
    AFTER UPDATE ON Estado_General
    FOR EACH ROW
BEGIN
    DECLARE nuevos_creditos INT;
    IF NEW.estado = "CURSADA" THEN

    SELECT SUM(creditos) INTO nuevos_creditos
    FROM Mapa_Curricular
    WHERE
        (abr_carr, semestre, id_plan, no_materia) =
        (NEW.abr_carr, NEW.semestre, NEW.id_plan, NEW.no_materia);

    UPDATE Trayectoria_Alumno
    SET
        cred_obtenidos = cred_obtenidos + nuevos_creditos,
        cred_faltantes = cred_faltantes - nuevos_creditos
    WHERE (no_boleta, id_plan) = (NEW.no_boleta, NEW.id_plan);
END IF;
END //
			
DELIMITER ;
