using Application.DTOs.Inicio;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Inicio.Queries.GetInicioGestion;

public class GetInicioGestionQuery(string usuario) : IRequest<Response<InicioGestionDto>>
{
    public string Usuario => usuario;
}