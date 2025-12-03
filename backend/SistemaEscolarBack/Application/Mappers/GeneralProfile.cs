using Application.DTOs.Reinscripcion;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappers;

public class GeneralProfile : Profile
{
    public GeneralProfile()
    {
        #region ToDomain

        CreateMap<HorariosValidacionDto, GrupoHorario>();

        #endregion
    }
}