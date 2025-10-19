using Application.DTOs.HistorialAcademico;
using Application.Wrapper;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialDetalle;

public class GetHistorialDetalleQuery : IRequest<Response<List<SemestreHistorialDto>>>
{
    public long NoBoleta { get; set; }
}
