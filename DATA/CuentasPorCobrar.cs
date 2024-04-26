using System;
using System.Collections.Generic;

namespace DATA;

public partial class CuentasPorCobrar
{
    public long IdCliente { get; set; }

    public string NombreCliente { get; set; } = null!;

    public DateTime FechaFactura { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public string Concepto { get; set; } = null!;

    public decimal MontoFacturado { get; set; }

    public decimal MontoPendiente { get; set; }

    public string Estadopago { get; set; } = null!;
}
