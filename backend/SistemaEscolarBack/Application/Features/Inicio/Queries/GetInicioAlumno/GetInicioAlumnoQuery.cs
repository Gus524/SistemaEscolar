using Application.DTOs.Inicio;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Inicio.Queries.GetInicioAlumno;

public class GetInicioAlumnoQuery(string noBoleta) : IRequest<Response<InicioAlumnoDto>>
{
    public string NoBoleta => noBoleta;
}