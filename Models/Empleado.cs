using System;
using System.Collections.Generic;

namespace RentCar.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public int Cedula { get; set; }

    public int NoTarjeTandaLabor { get; set; }

    public int PorcientoComision { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int Estado { get; set; }
}
