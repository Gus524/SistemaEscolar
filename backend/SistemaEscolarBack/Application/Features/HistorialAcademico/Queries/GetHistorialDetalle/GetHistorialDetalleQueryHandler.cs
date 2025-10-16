using Application.DTOs.HistorialAcademico;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialDetalle;

public class GetHistorialDetalleQueryHandler(IHistorialAcademicoRepository repository) : IRequestHandler<GetHistorialDetalleQuery, Response<List<SemestreHistorialDto>>>
{
    public async Task<Response<List<SemestreHistorialDto>>> Handle(GetHistorialDetalleQuery request, CancellationToken cancellationToken)
    {
        var detalleList = await repository.GetHistorialDetalle(request.NoBoleta);

        var groupedDetalle = detalleList
            .GroupBy(d => d.Semestre)
            .Select(g => new SemestreHistorialDto
            {
                Semestre = g.Key,
                Materias = g.ToList()
            })
            .OrderBy(s => s.Semestre)
            .ToList();

        return Response<List<SemestreHistorialDto>>.Success(groupedDetalle);
    }
}
