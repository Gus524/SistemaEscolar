using Application.DTOs.PeriodoActual;
using Application.Wrapper;
using MediatR;

namespace Application.Features.PeriodoActual.Queries.GetAlumnoCalificacionesCurrent;

public class GetAlumnoCalificacionesCurrentQuery : IRequest<Response<List<AlumnoCalificacionesDto>>>;