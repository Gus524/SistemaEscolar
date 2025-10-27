using Application.DTOs.Reinscripcion;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Reinscripcion.Commands.ValidarNuevaMateria;

public class ValidarNuevaMateriaCommandHandler(
    ICurrentUserService currentUserService,
    IReadRepositoryAsync<GrupoHorario> grupoHorarioRepository, 
    IReadRepositoryAsync<EstadoGeneral> estadoGeneralRepository
) : IRequestHandler<ValidarNuevaMateriaCommand, Response<List<IdentificadorGrupoHorario>>>
{
    public async Task<Response<List<IdentificadorGrupoHorario>>> Handle(ValidarNuevaMateriaCommand request, CancellationToken cancellationToken)
    {
        // TODO Validar empalme de materia nueva, creditos para materia nueva, repeticion de materia nueva en la lista recibida, validacion de que puede inscribir materia nueva
        throw new NotImplementedException();
    }
}