using Application.DTOs.Reinscripcion;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Reinscripcion.Queries.GetMateriasReinscripcionCurrent;

public class GetMateriasReinscripcionCurrentQuery : IRequest<Response<IReadOnlyList<MateriasDisponiblesDto>>>;