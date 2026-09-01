using Application.DTOs.DatosPersonales;
using Application.Wrapper;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonales;

public class GetDatosPersonalesQuery : IRequest<Response<DatosPersonalesAlumnoDto>>
{
    public long NoBoleta { get; set; }
}