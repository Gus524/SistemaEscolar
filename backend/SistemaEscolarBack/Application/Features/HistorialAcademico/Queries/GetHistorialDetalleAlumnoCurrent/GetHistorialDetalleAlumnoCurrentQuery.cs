using Application.DTOs.HistorialAcademico;
using Application.Wrapper;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialDetalleAlumnoCurrent;

public class GetHistorialDetalleAlumnoCurrentQuery : IRequest<Response<HistorialAlumnoResponseDto>>;