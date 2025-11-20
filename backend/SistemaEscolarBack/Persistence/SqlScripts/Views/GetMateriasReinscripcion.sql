CREATE VIEW GetMateriasReinscripcion 
AS
SELECT 	  e.no_boleta,
            m.nom_materia,
            CONCAT(gh.semestre, gh.abr_carr, gh.turno, gh.no_grupo) AS grupo,
            CONCAT(gh.abr_carr, gh.semestre, gh.no_materia) AS clave,
            CONCAT(lun_i, '-', lun_f) AS lunes,
            CONCAT(mar_i, '-', mar_f) AS martes,
            CONCAT(mie_i, '-', mie_f) AS miercoles,
            CONCAT(jue_i, '-', jue_f) AS jueves,
            CONCAT(vie_i, '-', vie_f) AS viernes,
            cupo,
            disponibles,
            gh.semestre,
            turno,
            gh.no_grupo,
            gh.no_materia,
            gh.abr_carr
FROM Periodo_Escolar p
         JOIN Grupo_Horario gh
              ON p.id_periodo = gh.id_periodo
         JOIN Estado_General e
              ON (e.abr_carr, e.semestre, e.id_plan, e.no_materia) =
                 (gh.abr_carr, gh.semestre, gh.id_plan, gh.no_materia)
         JOIN Historial_Academico ha 
              ON (ha.no_boleta, ha.id_plan) = (e.no_boleta, e.id_plan)
         JOIN Mapa_Curricular mc
              ON (gh.abr_carr, gh.semestre, gh.id_plan, gh.no_materia) =
                 (mc.abr_carr, mc.semestre, mc.id_plan, mc.no_materia)
         JOIN Materia m
              ON m.id_materia = mc.id_materia
WHERE p.activo = 1 AND (e.estado = 'REPROBADA' OR e.estado = 'NO CURSADA')
AND (gh.semestre BETWEEN (ultimo_semestre - 3) AND (ultimo_semestre + 3))