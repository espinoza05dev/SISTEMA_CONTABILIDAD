using System;
using System.Collections.Generic;

namespace DATA;

public partial class PresupuestoGasto
{
    public long IdGasto { get; set; }

    public string Concepto { get; set; } = null!;

    public decimal Montoasignado { get; set; }

    public decimal Montogastado { get; set; }

    public DateTime FechaRegistro { get; set; }
}
