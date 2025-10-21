using Application.DTOs.HistorialAcademico;
using Application.Extensions;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialDetalle;

public class GetHistorialDetalleQueryHandler(
    IHistorialAcademicoRepository repository, 
    IReadRepositoryAsync<Alumno> alumnoRepository
) : IRequestHandler<GetHistorialDetalleQuery, Response<List<SemestreHistorialDto>>>
{
    public async Task<Response<List<SemestreHistorialDto>>> Handle(GetHistorialDetalleQuery request, CancellationToken cancellationToken)
    {
        _ = await alumnoRepository.GetByIdAsync(request.NoBoleta, cancellationToken) ??
            throw new KeyNotFoundException($"No se encontró el Alumno con boleta '{request.NoBoleta}'.");
        
        var detalleList = await repository.GetHistorialDetalle(request.NoBoleta);

        var groupedDetalle = detalleList.ToSemestreDto();

        return Response<List<SemestreHistorialDto>>.Success(groupedDetalle);
    }
}
