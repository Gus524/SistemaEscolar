using Application.DTOs.Horario;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetAlumnoHorario;

public class GetAlumnoHorarioQueryHandler(IHorarioRepository repository) : IRequestHandler<GetAlumnoHorarioQuery, Response<List<AlumnoHorarioDto>>>
{
    public async Task<Response<List<AlumnoHorarioDto>>> Handle(GetAlumnoHorarioQuery request, CancellationToken cancellationToken)
    {
        var horario = await repository.GetAlumnoHorario(request.NoBoleta);
        return Response<List<AlumnoHorarioDto>>.Success(horario);
    }
}
