using Application.DTOs.HistorialAcademico;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialAlumno;

public class GetHistorialAlumnoQueryHandler(IHistorialAcademicoRepository repository, IReadRepositoryAsync<Alumno> alumnoRepository) : IRequestHandler<GetHistorialAlumnoQuery, Response<HistorialAlumnoDto>>
{
    public async Task<Response<HistorialAlumnoDto>> Handle(GetHistorialAlumnoQuery request, CancellationToken cancellationToken)
    {
        _ = await alumnoRepository.GetByIdAsync(request.NoBoleta, cancellationToken) ??
            throw new KeyNotFoundException($"No se encontró el Alumno con boleta '{request.NoBoleta}'.");
        
        var historial = await repository.GetHistorialAlumno(request.NoBoleta);
        return Response<HistorialAlumnoDto>.Success(historial);
    }
}
