using Application.DTOs.DatosPersonales;
using Application.DTOs.HistorialAcademico;
using Application.DTOs.Horario;
using Application.DTOs.MapaCurricular;
using Application.DTOs.PeriodoActual;
using AutoMapper;
using Persistence.Views;

namespace Persistence.Mappers;

public class GeneralProfile : Profile
{
    public GeneralProfile()
    {
        #region Repository

        CreateMap<GetDatosAlumno, DatosPersonalesAlumnoDto>()
            .ForMember(dest => dest.EmailPersonal, opt => opt.MapFrom(src => src.EmailPAlumno))
            .ForMember(dest => dest.EmailInstitucional, opt => opt.MapFrom(src => src.EmailIAlumno))
            .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.TelfAlumno))
            .ForMember(dest => dest.TelefonoMovil, opt => opt.MapFrom(src => src.TelmAlumno));
            
        CreateMap<GetDatosDocente, DatosPersonalesDocenteDto>()
            .ForMember(dest => dest.Academia, opt => opt.MapFrom(src => src.NomAcademia))
            .ForMember(dest => dest.Edificio, opt => opt.MapFrom(src => src.DescEdificio))
            .ForMember(dest => dest.EmailPersonal, opt => opt.MapFrom(src => src.EmailPDoc))
            .ForMember(dest => dest.EmailInstitucional, opt => opt.MapFrom(src => src.EmailIDoc))
            .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.TelDoc));

        CreateMap<GetHistorialAlumno, HistorialAlumnoDto>()
            .ForMember(dest => dest.Carrera, opt => opt.MapFrom(src => src.DescCarr))
            .ForMember(dest => dest.Plan, opt => opt.MapFrom(src => src.DescPlan));

        CreateMap<GetHistorialDetalle, MateriaDetalleDto>()
            .ForMember(dest => dest.Materia, opt => opt.MapFrom(src => src.NomMateria));

        CreateMap<GetEstadoGeneralAlumno, EstadoGeneralAlumnoDto>()
            .ForMember(dest => dest.Materia, opt => opt.MapFrom(src => src.NomMateria));
        
        CreateMap<GetDocenteHorario, DocenteHorarioDto>()
            .ForMember(dest => dest.Materia, opt => opt.MapFrom(src => src.NomMateria));
        
        CreateMap<GetAlumnoHorario, AlumnoHorarioDto>()
            .ForMember(dest => dest.Materia, opt => opt.MapFrom(src => src.NomMateria))
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
            .ForMember(dest => dest.Final, opt => opt.MapFrom(src => src.CalFinal))
            .ForMember(dest => dest.EmailPersonal, opt => opt.MapFrom(src => src.EmailPAlumno))
            .ForMember(dest => dest.EmailInstitucional, opt => opt.MapFrom(src => src.EmailIAlumno));

        CreateMap<GetCarrerasInst, CarrerasDto>()
            .ForMember(dest => dest.NumeroSemestres, opt => opt.MapFrom(src => src.NoSem));

        CreateMap<GetForMapa, PlanEstudiosDto>();

        CreateMap<GetMapaCurricular, MapaCurricularDto>()
            .ForMember(dest => dest.NombreMateria, opt => opt.MapFrom(src => src.NomMateria))
            .ForMember(dest => dest.HorasPractica, opt => opt.MapFrom(src => src.HorasPrac));

        #endregion
    }
}