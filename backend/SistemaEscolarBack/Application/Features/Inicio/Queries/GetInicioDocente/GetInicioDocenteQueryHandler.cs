using Application.DTOs.Inicio;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Inicio.Queries.GetInicioDocente;

internal class GetInicioDocenteQueryHandler(
    IGetInicioRepository inicioRepository
) : IRequestHandler<GetInicioDocenteQuery, Response<InicioDocenteDto>>
{
    public async Task<Response<InicioDocenteDto>> Handle(GetInicioDocenteQuery request, CancellationToken cancellationToken)
    {
        var inicioDocente = await inicioRepository.GetInicioDocente(request.Rfc);

        return inicioDocente is null
            ? Response<InicioDocenteDto>.NotFound("No se encontraron datos para el docente.")
            : Response<InicioDocenteDto>.Success(inicioDocente);
    }
}