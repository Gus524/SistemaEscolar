namespace Application.DTOs.Reinscripcion;

public record IdentificadorGrupoHorario(
    string Carrera,
    int IdPlan,
    int Semestre,
    string Turno,
    int NoGrupo,
    string NoMateria,
    int Creditos
);