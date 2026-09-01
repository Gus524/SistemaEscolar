DELIMITER //

CREATE TRIGGER add_historial_alumno
AFTER INSERT ON Historial_Academico
FOR EACH ROW
BEGIN
	DECLARE carrera CHAR(1);
    
    SELECT c.abr_carr INTO carrera
    FROM 
		Carrera c
    JOIN
		Plan_Estudios p
    ON 
		p.abr_carr = c.abr_carr
    WHERE 
		p.id_plan = NEW.id_plan;
    
	CALL InsertEstadoAlumno(NEW.no_boleta, NEW.id_plan, carrera);
    CALL InsertTrayectoriaAlumno(NEW.no_boleta, NEW.id_plan, carrera);

END //

DELIMITER ;