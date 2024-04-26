using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DATA;

public partial class SistemaContabilidadContext : DbContext
{
    public SistemaContabilidadContext()
    {
    }

    public SistemaContabilidadContext(DbContextOptions<SistemaContabilidadContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActivosFijo> ActivosFijos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<CuentasContable> CuentasContables { get; set; }

    public virtual DbSet<CuentasPorCobrar> CuentasPorCobrars { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Prestamo> Prestamos { get; set; }

    public virtual DbSet<PresupuestoGasto> PresupuestoGastos { get; set; }

    public virtual DbSet<Transaccione> Transacciones { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-TB39PMF\\LOCAL; DataBase=SISTEMA-CONTABILIDAD; TrustServerCertificate=True; Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActivosFijo>(entity =>
        {
            entity.HasKey(e => e.IdActivo);

            entity.ToTable("ACTIVOS_FIJOS");

            entity.Property(e => e.IdActivo)
                .ValueGeneratedNever()
                .HasColumnName("ID_ACTIVO");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaAdquisicion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ADQUISICION");
            entity.Property(e => e.IdResidual)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_RESIDUAL");
            entity.Property(e => e.MetodoDepresiacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("METODO_DEPRESIACION");
            entity.Property(e => e.ValorAdquisicion)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("VALOR_ADQUISICION");
            entity.Property(e => e.VidaUtil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VIDA_UTIL");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Idcliente);

            entity.ToTable("CLIENTES");

            entity.Property(e => e.Idcliente).HasColumnName("IDCLIENTE");
            entity.Property(e => e.Direccion)
                .HasColumnType("text")
                .HasColumnName("DIRECCION");
            entity.Property(e => e.InfoContacto)
                .HasColumnType("text")
                .HasColumnName("INFO_CONTACTO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.SaldoActual).HasColumnName("SALDO_ACTUAL");
            entity.Property(e => e.SaldoPendiente).HasColumnName("SALDO_PENDIENTE");
        });

        modelBuilder.Entity<CuentasContable>(entity =>
        {
            entity.HasKey(e => e.Idcuenta);

            entity.ToTable("CUENTAS_CONTABLES");

            entity.Property(e => e.Idcuenta).HasColumnName("IDCUENTA");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CREACION");
            entity.Property(e => e.Moneda)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MONEDA");
            entity.Property(e => e.NombreCuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CUENTA");
            entity.Property(e => e.SaldoActual).HasColumnName("SALDO_ACTUAL");
            entity.Property(e => e.TipoCuenta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_CUENTA");
        });

        modelBuilder.Entity<CuentasPorCobrar>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("CUENTAS POR COBRAR");

            entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");
            entity.Property(e => e.Concepto)
                .IsUnicode(false)
                .HasColumnName("CONCEPTO");
            entity.Property(e => e.Estadopago)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ESTADOPAGO");
            entity.Property(e => e.FechaFactura)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_FACTURA");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO");
            entity.Property(e => e.MontoFacturado)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("MONTO_FACTURADO");
            entity.Property(e => e.MontoPendiente)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("MONTO_PENDIENTE");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CLIENTE");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.Idpago);

            entity.ToTable("PAGOS");

            entity.Property(e => e.Idpago).HasColumnName("IDPAGO");
            entity.Property(e => e.FacturaAsociada)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FACTURA_ASOCIADA");
            entity.Property(e => e.FechaPago)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_PAGO");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("METODO_PAGO");
            entity.Property(e => e.MontoPagado).HasColumnName("MONTO_PAGADO");
        });

        modelBuilder.Entity<Prestamo>(entity =>
        {
            entity.HasKey(e => e.Idprestamo);

            entity.ToTable("PRESTAMOS");

            entity.Property(e => e.Idprestamo).HasColumnName("IDPRESTAMO");
            entity.Property(e => e.Cliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Fechafinal)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFINAL");
            entity.Property(e => e.Fechainicio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.Idcliente).HasColumnName("IDCLIENTE");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.PagosMensuales)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PAGOS_MENSUALES");
            entity.Property(e => e.PagosTotales)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PAGOS_TOTALES");
            entity.Property(e => e.Plazomeses).HasColumnName("PLAZOMESES");
            entity.Property(e => e.Tasainteres)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("TASAINTERES");
        });

        modelBuilder.Entity<PresupuestoGasto>(entity =>
        {
            entity.HasKey(e => e.IdGasto);

            entity.ToTable("PRESUPUESTO_GASTOS");

            entity.Property(e => e.IdGasto).HasColumnName("ID_GASTO");
            entity.Property(e => e.Concepto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CONCEPTO");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO");
            entity.Property(e => e.Montoasignado)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("MONTOASIGNADO");
            entity.Property(e => e.Montogastado)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("MONTOGASTADO");
        });

        modelBuilder.Entity<Transaccione>(entity =>
        {
            entity.HasKey(e => e.Idtransaccion);

            entity.ToTable("TRANSACCIONES");

            entity.Property(e => e.Idtransaccion).HasColumnName("IDTRANSACCION");
            entity.Property(e => e.CuentaCredito).HasColumnName("CUENTA_CREDITO");
            entity.Property(e => e.CuentaDebito).HasColumnName("CUENTA_DEBITO");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Monto).HasColumnName("MONTO");
            entity.Property(e => e.RefFactura).HasColumnName("REF_FACTURA");
            entity.Property(e => e.TipoTransaccion)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO_TRANSACCION");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Usuario1);

            entity.ToTable("USUARIOS");

            entity.Property(e => e.Usuario1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Contra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTRA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
