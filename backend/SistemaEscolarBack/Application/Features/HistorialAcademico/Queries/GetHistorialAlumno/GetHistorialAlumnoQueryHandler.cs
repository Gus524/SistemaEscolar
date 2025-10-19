using Application.DTOs.HistorialAcademico;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialAlumno;

public class GetHistorialAlumnoQueryHandler(IHistorialAcademicoRepository repository) : IRequestHandler<GetHistorialAlumnoQuery, Response<HistorialAlumnoDto>>
{
    public async Task<Response<HistorialAlumnoDto>> Handle(GetHistorialAlumnoQuery request, CancellationToken cancellationToken)
    {
        var historial = await repository.GetHistorialAlumno(request.NoBoleta);
        return Response<HistorialAlumnoDto>.Success(historial);
    }
}
