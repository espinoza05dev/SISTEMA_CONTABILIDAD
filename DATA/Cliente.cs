using System;
using System.Collections.Generic;

namespace DATA;

public partial class Cliente
{
    public long Idcliente { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string InfoContacto { get; set; } = null!;

    public double SaldoActual { get; set; }

    public double SaldoPendiente { get; set; }
}
