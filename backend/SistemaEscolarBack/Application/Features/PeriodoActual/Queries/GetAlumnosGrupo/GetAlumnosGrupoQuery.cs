using Application.DTOs.PeriodoActual;
using Application.Wrapper;
using MediatR;

namespace Application.Features.PeriodoActual.Queries.GetAlumnosGrupo;

public class GetAlumnosGrupoQuery : IRequest<Response<List<AlumnosGrupoDto>>>
{
    public string Grupo { get; set; } = null!;
    public string Clave { get; set; } = null!;
}