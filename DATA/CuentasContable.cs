using System;
using System.Collections.Generic;

namespace DATA;

public partial class CuentasContable
{
    public long Idcuenta { get; set; }

    public string NombreCuenta { get; set; } = null!;

    public string TipoCuenta { get; set; } = null!;

    public double SaldoActual { get; set; }

    public string Moneda { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string? Descripcion { get; set; }
}
