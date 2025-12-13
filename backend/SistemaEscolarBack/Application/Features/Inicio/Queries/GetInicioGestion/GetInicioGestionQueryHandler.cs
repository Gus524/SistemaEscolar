using Application.DTOs.Inicio;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Inicio.Queries.GetInicioGestion;

internal class GetInicioGestionQueryHandler(
    IGetInicioRepository inicioRepository
) : IRequestHandler<GetInicioGestionQuery, Response<InicioGestionDto>>
{
    public async Task<Response<InicioGestionDto>> Handle(GetInicioGestionQuery request, CancellationToken cancellationToken)
    {
        var inicioGestion = await inicioRepository.GetInicioGestion(request.Usuario);

        return inicioGestion is null
            ? Response<InicioGestionDto>.NotFound("Datos de gestión no encontrados.")
            : Response<InicioGestionDto>.Success(inicioGestion);
    }
}