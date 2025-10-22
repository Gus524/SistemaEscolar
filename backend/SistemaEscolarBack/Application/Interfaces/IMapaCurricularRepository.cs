using Application.DTOs.MapaCurricular;

namespace Application.Interfaces;

public interface IMapaCurricularRepository
{ 
    Task<List<CarrerasDto>> GetCarreras(int institucion);
    Task<List<PlanEstudiosDto>> GetPlanEstudios(string carrera);
    Task<List<MapaCurricularDto>> GetMapaCurricular(int plan, string carrera);
}