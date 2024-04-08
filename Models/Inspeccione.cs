using System;
using System.Collections.Generic;

namespace RentCar.Models;

public partial class Inspeccione
{
    public int IdTransaccion { get; set; }

    public int IdVehiculo { get; set; }

    public int IdCliente { get; set; }

    public int Defectos { get; set; }

    public int CantidadCombustible { get; set; }

    public int Respuesta { get; set; }

    public int Gato { get; set; }

    public int Fecha { get; set; }

    public int EmpleadoInspeccion { get; set; }

    public int Estado { get; set; }
}
