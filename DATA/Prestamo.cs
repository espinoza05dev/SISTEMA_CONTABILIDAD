using System;
using System.Collections.Generic;

namespace DATA;

public partial class Prestamo
{
    public long Idprestamo { get; set; }

    public long Idcliente { get; set; }

    public string Cliente { get; set; } = null!;

    public decimal Monto { get; set; }

    public string Tasainteres { get; set; } = null!;

    public int Plazomeses { get; set; }

    public DateTime Fechainicio { get; set; }

    public DateTime Fechafinal { get; set; }

    public decimal PagosMensuales { get; set; }

    public decimal PagosTotales { get; set; }
}
