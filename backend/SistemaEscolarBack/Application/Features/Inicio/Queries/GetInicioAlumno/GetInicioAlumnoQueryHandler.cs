using Application.DTOs.Inicio;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Inicio.Queries.GetInicioAlumno;

internal class GetInicioAlumnoQueryHandler(
    IGetInicioRepository inicioRepository
) : IRequestHandler<GetInicioAlumnoQuery, Response<InicioAlumnoDto>>
{
    public async Task<Response<InicioAlumnoDto>> Handle(GetInicioAlumnoQuery request, CancellationToken cancellationToken)
    {
        var boleta = long.Parse(request.NoBoleta);
        
        var inicioAlumno = await inicioRepository.GetInicioAlumno(boleta);
        
        return inicioAlumno is null 
            ? Response<InicioAlumnoDto>.NotFound("Datos del alumno no econtrados.") 
            : Response<InicioAlumnoDto>.Success(inicioAlumno);
    }
}