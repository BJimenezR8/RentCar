using System;
using System.Collections.Generic;

namespace RentCar.Models;

public partial class Devolucione
{
    public int IdDevolucion { get; set; }

    public int NoRenta { get; set; }

    public string? Empleado { get; set; }

    public int Vehiculo { get; set; }

    public int Cliente { get; set; }

    public DateTime FechaRenta { get; set; }

    public DateTime FechaDevolucion { get; set; }

    public int MontoPorDia { get; set; }

    public int CantidadDeDias { get; set; }

    public string? Comentario { get; set; }

    public int Estado { get; set; }
}
