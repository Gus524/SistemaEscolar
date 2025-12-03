namespace Domain.ValueObjects;

public readonly record struct HorarioBloque
{
    public DayOfWeek Dia { get; init; }
    public TimeOnly HoraInicio { get;  init; }
    public TimeOnly HoraFin { get;  init; }

    public HorarioBloque(DayOfWeek dia, TimeOnly horaInicio, TimeOnly horaFin)
    {
        if (horaInicio >= horaFin)
            throw new ArgumentException("La hora inicio debe ser menor a la hora de fin.");

        if (dia < DayOfWeek.Monday || dia > DayOfWeek.Friday)
            throw new ArgumentOutOfRangeException(nameof(dia), "El dia debe ser de lunes a viernes");
        
        Dia = dia;
        HoraInicio = horaInicio;
        HoraFin = horaFin;
    }

    public bool ComprobarEmpalme(HorarioBloque propuesta)
    {
        if (Dia != propuesta.Dia)
            return false;
        
        return HoraInicio < propuesta.HoraFin && propuesta.HoraInicio < HoraFin;
    }
}