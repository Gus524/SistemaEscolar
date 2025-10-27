namespace Application.DTOs.Reinscripcion;

public record IdentificadorGrupoHorario(
    string Carrera,
    int IdPlan,
    int Semestre,
    char Turno,
    int NoGrupo,
    string NoMateria
);