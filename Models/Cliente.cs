using System;
using System.Collections.Generic;

namespace RentCar.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Cedula { get; set; }

    public string? NoTarjetaCr { get; set; }

    public string? LimiteDeCredito { get; set; }

    public string? TipoPersona { get; set; }

    public int Estado { get; set; }
}
