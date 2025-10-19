using Application.DTOs.MapaCurricular;
using Application.Wrapper;
using MediatR;

namespace Application.Features.MapaCurricular.Queries.GetCarreras;

public class GetCarrerasQuery : IRequest<Response<List<CarrerasDto>>>
{
    public int Institucion { get; set; }
}