CREATE
OR REPLACE VIEW GetHorariosValidacion AS
SELECT CONCAT(gh.semestre, gh.abr_carr, gh.turno, gh.no_grupo, gh.no_materia) AS grupo_materia,
       gh.semestre,
       gh.abr_carr,
       gh.turno,
       gh.no_grupo,
       gh.id_plan,
       gh.id_periodo,
       lun_i,
       lun_f,
       mar_i,
       mar_f,
       mie_i,
       mie_f,
       jue_i,
       jue_f,
       vie_i,
       vie_f,
       cupo,
       disponibles,
       sobrecupo,
       mc.no_materia,
       mc.creditos
FROM Grupo_Horario gh
         JOIN
     Mapa_Curricular mc
     ON
         (mc.id_plan, mc.abr_carr, mc.semestre, mc.no_materia) =
         (gh.id_plan, gh.abr_carr, gh.semestre, gh.no_materia)
     JOIN
     Periodo_Escolar p
     ON
         p.id_periodo = gh.id_periodo
WHERE p.activo = 1;