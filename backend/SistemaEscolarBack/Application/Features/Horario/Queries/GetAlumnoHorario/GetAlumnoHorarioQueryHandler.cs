using Application.DTOs.Horario;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Horario.Queries.GetAlumnoHorario;

public class GetAlumnoHorarioQueryHandler(IHorarioRepository repository, IReadRepositoryAsync<Alumno> alumnoRepository) : IRequestHandler<GetAlumnoHorarioQuery, Response<List<AlumnoHorarioDto>>>
{
    public async Task<Response<List<AlumnoHorarioDto>>> Handle(GetAlumnoHorarioQuery request, CancellationToken cancellationToken)
    {
        _ = await alumnoRepository.GetByIdAsync(request.NoBoleta, cancellationToken) ??
            throw new KeyNotFoundException($"No se encontró el Alumno con boleta '{request.NoBoleta}'.");
        
        var horario = await repository.GetAlumnoHorario(request.NoBoleta);
        return Response<List<AlumnoHorarioDto>>.Success(horario);
    }
}
