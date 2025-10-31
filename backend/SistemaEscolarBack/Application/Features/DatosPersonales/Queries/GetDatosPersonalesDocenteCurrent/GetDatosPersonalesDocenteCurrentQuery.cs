using Application.DTOs.DatosPersonales;
using Application.Wrapper;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonalesDocenteCurrent;

public class GetDatosPersonalesDocenteCurrentQuery : IRequest<Response<DatosPersonalesDocenteDto>>;