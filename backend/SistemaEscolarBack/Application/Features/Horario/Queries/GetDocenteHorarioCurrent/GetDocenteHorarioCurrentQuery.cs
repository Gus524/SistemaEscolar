using Application.DTOs.Horario;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetDocenteHorarioCurrent;

public class GetDocenteHorarioCurrentQuery : IRequest<Response<List<DocenteHorarioDto>>>;