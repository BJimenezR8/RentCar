using System;
using System.Collections.Generic;

namespace RentCar.Models;

public partial class TipoVehiculo
{
    public int IdTipoVehiculo { get; set; }

    public string? Nombre { get; set; }

    public int Estado { get; set; }
}
