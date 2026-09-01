using Application.DTOs.Inicio;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Inicio.Queries.GetInicioDocente;

public class GetInicioDocenteQuery(string rfc) : IRequest<Response<InicioDocenteDto>>
{
    public string Rfc => rfc;
}