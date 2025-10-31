using Application.DTOs.Horario;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetAlumnoHorarioCurrent;

public class GetAlumnoHorarioCurrentQueryHandler(
    ICurrentUserService currentUserService,
    IHorarioRepository horarioRepository
) : IRequestHandler<GetAlumnoHorarioCurrentQuery, Response<List<AlumnoHorarioDto>>>
{
    public async Task<Response<List<AlumnoHorarioDto>>> Handle(GetAlumnoHorarioCurrentQuery request, CancellationToken cancellationToken)
    {
        var boleta = currentUserService.UserName ??
                     throw new KeyNotFoundException("No se encontró boleta para el alumno.");

        var horario = await horarioRepository.GetAlumnoHorario(long.Parse(boleta));
        
        return Response<List<AlumnoHorarioDto>>.Success(horario);
    }
}