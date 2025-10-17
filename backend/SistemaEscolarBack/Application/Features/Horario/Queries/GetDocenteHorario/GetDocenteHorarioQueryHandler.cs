using Application.DTOs.Horario;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Horario.Queries.GetDocenteHorario;

public class GetDocenteHorarioQueryHandler(IHorarioRepository repository, IReadRepositoryAsync<Docente> docenteRepository) : IRequestHandler<GetDocenteHorarioQuery, Response<List<DocenteHorarioDto>>>
{
    public async Task<Response<List<DocenteHorarioDto>>> Handle(GetDocenteHorarioQuery request, CancellationToken cancellationToken)
    {
        _ = await docenteRepository.GetByIdAsync(request.Rfc, cancellationToken) ??
            throw new KeyNotFoundException($"No se encontró el Docente con RFC '{request.Rfc}'.");
        
        var horario = await repository.GetDocenteHorario(request.Rfc);
        return Response<List<DocenteHorarioDto>>.Success(horario);
    }
}
