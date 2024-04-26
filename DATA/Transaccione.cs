using System;
using System.Collections.Generic;

namespace DATA;

public partial class Transaccione
{
    public long Idtransaccion { get; set; }

    public DateTime Fecha { get; set; }

    public bool CuentaDebito { get; set; }

    public bool CuentaCredito { get; set; }

    public double Monto { get; set; }

    public string Descripcion { get; set; } = null!;

    public string TipoTransaccion { get; set; } = null!;

    public bool RefFactura { get; set; }
}
