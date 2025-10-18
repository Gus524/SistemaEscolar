using Application.DTOs.DatosPersonales;
using Application.Wrapper;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonalesDocente;

public class GetDatosPersonalesDocenteQuery : IRequest<Response<DatosPersonalesDocenteDto>>
{
    public string Rfc { get; set; } = null!;
}
