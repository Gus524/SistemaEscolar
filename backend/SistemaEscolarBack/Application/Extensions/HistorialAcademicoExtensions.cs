using Application.DTOs.HistorialAcademico;

namespace Application.Extensions;

public static class HistorialAcademicoExtensions
{
    public static List<SemestreHistorialDto> ToSemestreDto(this IEnumerable<MateriaDetalleDto> materiaDetalle)
    {
        return materiaDetalle
            .GroupBy(d => d.Semestre)
            .Select(g => new SemestreHistorialDto
            {
                Semestre = g.Key,
                Materias = g.ToList()
            })
            .OrderBy(s => s.Semestre)
            .ToList();
    }
}