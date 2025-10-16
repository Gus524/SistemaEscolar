using Application.DTOs.Horario;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetDocenteHorario;

public class GetDocenteHorarioQueryHandler(IHorarioRepository repository) : IRequestHandler<GetDocenteHorarioQuery, Response<List<DocenteHorarioDto>>>
{
    public async Task<Response<List<DocenteHorarioDto>>> Handle(GetDocenteHorarioQuery request, CancellationToken cancellationToken)
    {
        var horario = await repository.GetDocenteHorario(request.Rfc);
        return Response<List<DocenteHorarioDto>>.Success(horario);
    }
}
