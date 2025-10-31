using Application.DTOs.DatosPersonales;
using Application.Wrapper;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonalesAlumnoCurrent;

public class GetDatosPeronalesAlumnoCurrentQuery : IRequest<Response<DatosPersonalesAlumnoDto>>;