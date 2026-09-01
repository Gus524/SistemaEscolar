using Application.DTOs.Horario;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetAlumnoHorarioCurrent;

public class GetAlumnoHorarioCurrentQuery : IRequest<Response<List<AlumnoHorarioDto>>>;