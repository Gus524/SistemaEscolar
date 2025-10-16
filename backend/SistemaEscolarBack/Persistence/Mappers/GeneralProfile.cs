using Application.DTOs.DatosPersonales;
using AutoMapper;
using Persistence.Views;

namespace Persistence.Mappers;

public class GeneralProfile : Profile
{
    public GeneralProfile()
    {
        #region Repository

        CreateMap<GetDatosAlumno, DatosPersonalesAlumnoDto>();
        CreateMap<GetDatosDocente, DatosPersonalesDocenteDto>();

        #endregion
    }
}