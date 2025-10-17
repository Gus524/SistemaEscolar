using Application.DTOs.DatosPersonales;
using Application.DTOs.HistorialAcademico;
using Application.DTOs.Horario;
using Application.DTOs.PeriodoActual;
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

        CreateMap<GetAlumnoCalificaciones, AlumnoCalificacionesDto>()
            .ForMember(dest => dest.PrimerParcial, opt => opt.MapFrom(src => src.CalParcial1))
            .ForMember(dest => dest.SegundoParcial, opt => opt.MapFrom(src => src.CalParcial2))
            .ForMember(dest => dest.TercerParcial, opt => opt.MapFrom(src => src.CalParcial3))
            .ForMember(dest => dest.Extra, opt => opt.MapFrom(src => src.CalExtra))
            .ForMember(dest => dest.CalificacionFinal, opt => opt.MapFrom(src => src.CalFinal))
            .ForMember(dest => dest.Materia, opt => opt.MapFrom(src => src.NomMateria));

        CreateMap<GetAlumnosGrupo, AlumnosGrupoDto>()
            .ForMember(dest => dest.PrimerParcial, opt => opt.MapFrom(src => src.CalParcial1))
            .ForMember(dest => dest.SegundoParcial, opt => opt.MapFrom(src => src.CalParcial2))
            .ForMember(dest => dest.TercerParcial, opt => opt.MapFrom(src => src.CalParcial3))
            .ForMember(dest => dest.Extra, opt => opt.MapFrom(src => src.CalExtra))
            .ForMember(dest => dest.Final, opt => opt.MapFrom(src => src.CalFinal));
        
        #endregion
    }
}