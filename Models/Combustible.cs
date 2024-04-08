using System;
using System.Collections.Generic;

namespace RentCar.Models;

public partial class Combustible
{
    public int IdCombustible { get; set; }

    public string? Nombre { get; set; }

    public int Estado { get; set; }
}
