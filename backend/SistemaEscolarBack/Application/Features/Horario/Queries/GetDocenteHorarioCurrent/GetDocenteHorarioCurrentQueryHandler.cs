using Application.DTOs.Horario;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetDocenteHorarioCurrent;

public class GetDocenteHorarioCurrentQueryHandler(
    ICurrentUserService currentUserService,
    IHorarioRepository horarioRepository
) : IRequestHandler<GetDocenteHorarioCurrentQuery, Response<List<DocenteHorarioDto>>>
{
    public async Task<Response<List<DocenteHorarioDto>>> Handle(GetDocenteHorarioCurrentQuery request, CancellationToken cancellationToken)
    {
        var rfc = currentUserService.UserName ?? 
                  throw new KeyNotFoundException("No se encontró RFC para el docente.");

        var horario = await horarioRepository.GetDocenteHorario(rfc);
        return Response<List<DocenteHorarioDto>>.Success(horario);
    }
}