using Application.DTOs.HistorialAcademico;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetEstadoGeneralAlumno;

public class GetEstadoGeneralAlumnoQueryHandler(IHistorialAcademicoRepository repository) : IRequestHandler<GetEstadoGeneralAlumnoQuery, Response<List<EstadoGeneralAlumnoDto>>>
{
    public async Task<Response<List<EstadoGeneralAlumnoDto>>> Handle(GetEstadoGeneralAlumnoQuery request, CancellationToken cancellationToken)
    {
        var estadoGeneral = await repository.GetEstadoGeneralAlumno(request.NoBoleta, request.IdPlan);
        return Response<List<EstadoGeneralAlumnoDto>>.Success(estadoGeneral);
    }
}
