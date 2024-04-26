using System;
using System.Collections.Generic;

namespace DATA;

public partial class Pago
{
    public long Idpago { get; set; }

    public DateTime FechaPago { get; set; }

    public string FacturaAsociada { get; set; } = null!;

    public string MetodoPago { get; set; } = null!;

    public double MontoPagado { get; set; }
}
