using System;
using System.Collections.Generic;

namespace RentCar.Models;

public partial class Vehiculo
{
    public int IdVehiculo { get; set; }

    public int IdTipoVehiculo { get; set; }

    public int IdModelo { get; set; }

    public int IdCombustible { get; set; }

    public int Estado { get; set; }

    public string? NoMotor { get; set; }

    public string? NoPlaca { get; set; }

    public string? Descripcion { get; set; }

    public int IdMarca { get; set; }

    public string? NoChasis { get; set; }
}
