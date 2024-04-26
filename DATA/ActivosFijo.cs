using System;
using System.Collections.Generic;

namespace DATA;

public partial class ActivosFijo
{
    public long IdActivo { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime FechaAdquisicion { get; set; }

    public decimal ValorAdquisicion { get; set; }

    public string MetodoDepresiacion { get; set; } = null!;

    public string VidaUtil { get; set; } = null!;

    public long IdResidual { get; set; }
}
