using Application.DTOs.Inicio;

namespace Application.Interfaces;

public interface IGetInicioRepository
{
    Task<InicioAlumnoDto?> GetInicioAlumno(long noBoleta);
    Task<InicioDocenteDto?> GetInicioDocente(string rfc);
    Task<InicioGestionDto?> GetInicioGestion(string usuario);
}