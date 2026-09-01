using Application.DTOs.DatosPersonales;
using Application.Wrapper;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonalesAlumnoCurrent;

public class GetDatosPersonalesAlumnoCurrentQuery : IRequest<Response<DatosPersonalesAlumnoDto>>;
