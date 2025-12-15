CREATE OR REPLACE VIEW GetGruposPlan AS
	SELECT  CONCAT(semestre, abr_carr, turno, no_grupo) AS secuencia,
			semestre,
			p.id_periodo,
            id_plan,
            turno,
            p.activo
	FROM
		Grupo g
	JOIN
		Periodo_Escolar p
	ON 
		g.id_periodo = p.id_periodo;