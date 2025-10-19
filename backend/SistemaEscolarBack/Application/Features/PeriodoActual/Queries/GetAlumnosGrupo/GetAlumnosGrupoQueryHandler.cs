using Application.DTOs.PeriodoActual;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.PeriodoActual.Queries.GetAlumnosGrupo;

public class GetAlumnosGrupoQueryHandler(
    IPeriodoActualRepository periodoRepository
) : IRequestHandler<GetAlumnosGrupoQuery, Response<List<AlumnosGrupoDto>>>
{
    public async Task<Response<List<AlumnosGrupoDto>>> Handle(GetAlumnosGrupoQuery request, CancellationToken cancellationToken)
    {
        var alumnos = await periodoRepository.GetAlumnosGrupo(request.Grupo, request.Clave);
        return Response<List<AlumnosGrupoDto>>.Success(alumnos);
    }
}