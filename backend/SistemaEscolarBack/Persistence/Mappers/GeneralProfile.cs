using Application.DTOs.DatosPersonales;
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
            .ForMember(dest => dest.EmailPersonal, opt => opt.MapFrom(src => src.EmailPDoc))
            .ForMember(dest => dest.EmailInstitucional, opt => opt.MapFrom(src => src.EmailIDoc))
            .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.TelDoc));

        #endregion
    }
}