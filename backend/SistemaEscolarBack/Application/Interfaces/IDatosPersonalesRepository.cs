using Application.DTOs.DatosPersonales;

namespace Application.Interfaces;

public interface IDatosPersonalesRepository
{
    Task<DatosPersonalesAlumnoDto> GetDatosPersonalesAlumno(long noBoleta);
    Task<DatosPersonalesDocenteDto> GetDatosPersonalesDocente(string rfc);
}