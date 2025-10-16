using Application.DTOs.DatosPersonales;
using Application.DTOs.HistorialAcademico;
using Application.DTOs.Horario;
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
        
        CreateMap<GetDocenteHorario, DocenteHorarioDto>();
        CreateMap<GetAlumnoHorario, AlumnoHorarioDto>()
            .ForMember(dest => dest.NombreDocente, opt => opt.MapFrom(src => src.Nombre));

        CreateMap<GetHorarios, HorarioGeneralDto>()
            .ForMember(dest => dest.NombreProfesor, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.Jueves, opt => opt.MapFrom(src => src.Jue));

        CreateMap<GetHorarios, HorarioPorGrupoDto>()
            .ForMember(dest => dest.NombreProfesor, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.Jueves, opt => opt.MapFrom(src => src.Jue));

        #endregion
    }
}