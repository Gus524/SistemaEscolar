using Application.DTOs.DatosPersonales;
using Application.DTOs.HistorialAcademico;
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

        CreateMap<GetHistorialAlumno, HistorialAlumnoDto>();
        CreateMap<GetHistorialDetalle, MateriaDetalleDto>();

        CreateMap<GetEstadoGeneralAlumno, EstadoGeneralAlumnoDto>();

        #endregion
    }
}