using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.Identity.Client;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Xml;

namespace LOGICA
{
    public class DB:SistemaContabilidadContext
    {
        LHelpers lh = new LHelpers();

        public Int32 SaveContent(string[] txt, int ntable, Boolean[] Tc = null)
        {
            Int32 res = 0;
            if (ntable ==1){
                using (var db = new SistemaContabilidadContext()){
                     var d = new Cliente{
                        Nombre = txt[0],
                        Direccion = txt[1],
                        InfoContacto = txt[2],
                        SaldoActual = Convert.ToDouble(txt[3]),
                        SaldoPendiente = Convert.ToDouble(txt[4])
                    };
                    db.Clientes.Add(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 2){
                using (var db = new SistemaContabilidadContext()){
                    var d = new CuentasContable{
                        NombreCuenta = txt[0],
                        TipoCuenta = txt[1],
                        SaldoActual = Convert.ToDouble(txt[2]),
                        Moneda = txt[3],
                        Descripcion = txt[4]
                    };

                    db.CuentasContables.Add(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 3){
                using (var db = new SistemaContabilidadContext()){
                    var d = new Pago{
                        FacturaAsociada  = txt[0],
                        MetodoPago = txt[1],
                        MontoPagado = Convert.ToDouble(txt[2])
                    };

                    db.Pagos.Add(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 4){
                using (var db = new SistemaContabilidadContext()){
                    var d = new Prestamo {
                        Cliente = txt[0],
                        Monto = Convert.ToDecimal(txt[1]),
                        Tasainteres = txt[2],
                        Plazomeses = Convert.ToInt16(txt[3]),
                        Fechafinal = Convert.ToDateTime(txt[4]),
                        PagosMensuales = Convert.ToDecimal(txt[5]),
                        PagosTotales = Convert.ToDecimal(txt[6])
                    };

                    db.Prestamos.Add(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 5){
                using (var db = new SistemaContabilidadContext()){
                    var d = new Transaccione{
                        CuentaDebito = Tc[0],
                        CuentaCredito = Tc[1],
                        Monto = Convert.ToDouble(txt[0]),
                        Descripcion = txt[1],
                        TipoTransaccion = txt[2],
                        RefFactura = Tc[2]
                    };

                    db.Transacciones.Add(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 6)
            {
                using (var db = new SistemaContabilidadContext()){
                    var d = new ActivosFijo{
                        Descripcion = txt[0],
                        ValorAdquisicion = Convert.ToDecimal(txt[1]),
                        MetodoDepresiacion = txt[2],
                        VidaUtil = txt[3]
                    };

                    db.ActivosFijos.Add(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 7)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = new CuentasPorCobrar
                    {
                        NombreCliente = txt[0],
                        FechaVencimiento = Convert.ToDateTime(txt[1]),
                        Concepto = txt[2],
                        MontoFacturado = Convert.ToDecimal(txt[3]),
                        MontoPendiente = Convert.ToDecimal(txt[4]),
                        Estadopago = txt[5]
                    };

                    db.CuentasPorCobrars.Add(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 8)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = new PresupuestoGasto
                    {
                        Concepto = txt[0],
                        Montoasignado = Convert.ToDecimal(txt[1]),
                        Montogastado = Convert.ToDecimal(txt[2]),  
                    };

                    db.PresupuestoGastos.Add(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            return res;
        }

        public Int32 UpdateContent(string[] lista,int ntable, Boolean[] Tc = null)
        {
            Int32 res = 0;
            if (ntable == 1){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.Clientes.Single(b => b.Idcliente == Convert.ToInt64(lista[0]));
                    d.Nombre = lista[1];
                    d.Direccion = lista[2];
                    d.InfoContacto = lista[3];
                    d.SaldoActual = Convert.ToDouble(lista[4]);
                    d.SaldoPendiente = Convert.ToDouble(lista[5]);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 2){
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.CuentasContables.Single(b => b.Idcuenta == Convert.ToInt64(lista[0]));
                    d.NombreCuenta = lista[1];
                    d.TipoCuenta = lista[2];
                    d.SaldoActual = Convert.ToDouble(lista[3]);
                    d.Moneda = lista[4];
                    d.Descripcion = lista[5];
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 3){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.Pagos.Single(b => b.Idpago == Convert.ToInt64(lista[0]));
                    d.FacturaAsociada = lista[1];
                    d.MetodoPago = lista[2];
                    d.MontoPagado = Convert.ToDouble(lista[3]);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 4){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.Prestamos.Single(b => b.Idprestamo == Convert.ToInt64(lista[0]));
                    d.Cliente = lista[0];
                    d.Monto = Convert.ToDecimal(lista[1]);
                    d.Tasainteres = lista[2];
                    d.Plazomeses = Convert.ToInt16(lista[3]);
                    d.Fechafinal = Convert.ToDateTime(lista[4]);
                    d.PagosMensuales = Convert.ToDecimal(lista[5]);
                    d.PagosTotales = Convert.ToDecimal(lista[6]);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 5){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.Transacciones.Single(b => b.Idtransaccion == Convert.ToInt64(lista[0]));
                    d.CuentaDebito = Tc[0];
                    d.CuentaCredito = Tc[1];
                    d.Monto = Convert.ToDouble(lista[1]);
                    d.Descripcion = lista[2];
                    d.TipoTransaccion = lista[3];
                    d.RefFactura = Tc[2];
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 6)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.ActivosFijos.Single(b => b.IdActivo == Convert.ToInt64(lista[0]));
                    d.Descripcion = lista[0];
                    d.ValorAdquisicion = Convert.ToDecimal(lista[1]);
                    d.MetodoDepresiacion = lista[2];
                    d.VidaUtil = lista[3];
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 7)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.CuentasPorCobrars.Single(b => b.IdCliente == Convert.ToInt64(lista[0]));
                    d.NombreCliente = lista[1];
                    d.FechaVencimiento = Convert.ToDateTime(lista[2]);
                    d.Concepto = lista[3];
                    d.MontoFacturado = Convert.ToDecimal(lista[4]);
                    d.MontoPendiente = Convert.ToDecimal(lista[5]);
                    d.Estadopago = lista[6].ToString();
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 8)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.PresupuestoGastos.Single(b => b.IdGasto == Convert.ToInt64(lista[0]));
                    d.Concepto = lista[0];
                    d.Montoasignado = Convert.ToDecimal(lista[1]);
                    d.Montogastado = Convert.ToDecimal(lista[2]);
                    db.SaveChanges();
                    res++;
                     
                }
            }

            return res;
        }

        public Int32 DeleteContent(string lista,int ntable)
        {
            Int32 res = 0;
            if (ntable == 1){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.Clientes.Single(b => b.Idcliente == Convert.ToInt64(lista));
                    db.Clientes.Remove(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 2){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.CuentasContables.Single(b => b.Idcuenta == Convert.ToInt64(lista));
                    db.CuentasContables.Remove(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 3){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.Pagos.Single(b => b.Idpago == Convert.ToInt64(lista));
                    db.Pagos.Remove(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 4){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.Prestamos.Single(b => b.Idprestamo == Convert.ToInt64(lista));
                    db.Prestamos.Remove(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 5){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.Transacciones.Single(b => b.Idtransaccion == Convert.ToInt64(lista));
                    db.Transacciones.Remove(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 6)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.ActivosFijos.Single(b => b.IdActivo == Convert.ToInt64(lista));
                    db.ActivosFijos.Remove(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 7)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.CuentasPorCobrars.Single(b => b.IdCliente == Convert.ToInt64(lista));
                    db.CuentasPorCobrars.Remove(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }
            else if (ntable == 8)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.PresupuestoGastos.Single(b => b.IdGasto == Convert.ToInt64(lista));
                    db.PresupuestoGastos.Remove(d);
                    db.SaveChanges();
                    res++;
                     
                }
            }

            return res;
        }

        public void LoadDataDGV(DataGridView DGV,int ntable)
        {
            DGV.Rows.Clear();
            if (ntable == 1) {
                using (var db = new SistemaContabilidadContext()) {
                    var d = db.Clientes.ToList();
                    foreach (var data in d) {
                        DGV.Rows.Add(data.Idcliente,
                                            data.Nombre,
                                            data.Direccion,
                                            data.InfoContacto,
                                            data.SaldoActual,
                                            data.SaldoPendiente);
                    }
                     
                }
            }
            else if (ntable == 2)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.CuentasContables.ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.Idcuenta,
                                            data.NombreCuenta,
                                            data.TipoCuenta,
                                            data.SaldoActual,
                                            data.Moneda,
                                            data.FechaCreacion,
                                            data.Descripcion);
                    }
                     
                }

            }
            else if (ntable == 3)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.Pagos.ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.Idpago,
                                            data.FechaPago,
                                            data.FacturaAsociada,
                                            data.MetodoPago,
                                            data.MontoPagado);
                    }
                     
                }
            }
            else if (ntable == 5)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.Transacciones.ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.Idtransaccion,
                                            data.Fecha,
                                            data.CuentaDebito,
                                            data.CuentaCredito,
                                            data.Monto,
                                            data.Descripcion,
                                            data.TipoTransaccion,
                                            data.RefFactura);
                    }
                     
                }
            }
            else if (ntable == 4)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.Prestamos.ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.Idprestamo,
                                            data.Cliente,
                                            data.Monto,
                                            data.Tasainteres,
                                            data.Plazomeses,
                                            data.Fechainicio,
                                            data.Fechafinal,
                                            data.PagosMensuales,
                                            data.PagosTotales);
                    }
                     
                }
            }
            else if (ntable == 6)
            {
                using (var db = new SistemaContabilidadContext()){
                    var d = db.ActivosFijos.ToList();
                    foreach (var data in d){
                        DGV.Rows.Add(data.IdActivo,
                                            data.Descripcion,
                                            data.FechaAdquisicion,
                                            data.ValorAdquisicion,
                                            data.MetodoDepresiacion,
                                            data.VidaUtil,
                                            data.IdResidual);
                    }
                     
                }
            }
            else if (ntable == 7)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.CuentasPorCobrars.ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.IdCliente,
                                            data.NombreCliente,
                                            data.FechaFactura,
                                            data.FechaVencimiento,
                                            data.Concepto,
                                            data.MontoFacturado,
                                            data.MontoPendiente,
                                            data.Estadopago);
                    }
                     
                }
            }
            else if (ntable == 8)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.PresupuestoGastos.ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.IdGasto,
                                            data.Concepto,
                                            data.Montoasignado,
                                            data.Montogastado,
                                            data.FechaRegistro);
                    }
                     
                }
            }
        }

        public void Search(ref DataGridView DGV, int ntable, string txt = "",int id = 0)
        {
            DGV.Rows.Clear();
            if (ntable == 1) {
                using (var db = new SistemaContabilidadContext()) {
                    var d = db.Clientes.Where(c => c.Nombre.Contains(txt[0])).ToList();
                    foreach (var cd in d) {
                        DGV.Rows.Add(cd.Idcliente,
                                          cd.Nombre,
                                          cd.Direccion,
                                          cd.InfoContacto,
                                          cd.SaldoActual,
                                          cd.SaldoPendiente);
                    }
                     
                }
            }
            else if (ntable == 2){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.CuentasContables.Where(c=> c.NombreCuenta.Contains(txt)).ToList();
                    foreach (var data in d){
                        DGV.Rows.Add(data.Idcuenta,
                                            data.NombreCuenta,
                                            data.TipoCuenta,
                                            data.SaldoActual,
                                            data.Moneda,
                                            data.FechaCreacion,
                                            data.Descripcion);
                    }
                     
                }

            }
            else if (ntable == 3){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.Pagos.Where(c=> c.Idpago.Equals(id)).ToList();
                    foreach (var data in d){
                        DGV.Rows.Add(data.Idpago,
                                            data.FechaPago,
                                            data.FacturaAsociada,
                                            data.MetodoPago,
                                            data.MontoPagado);
                    }
                     
                }
            }
            else if (ntable == 4){
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.Prestamos.Where(c => c.Idprestamo.Equals(id)).ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.Idprestamo,
                                            data.Cliente,
                                            data.Monto,
                                            data.Tasainteres,
                                            data.Plazomeses,
                                            data.Fechainicio,
                                            data.Fechafinal,
                                            data.PagosMensuales,
                                            data.PagosTotales);
                    }
                }
            }
            else if (ntable == 5){
                using (var db = new SistemaContabilidadContext()){
                    var d = db.Transacciones.Where(c => c.Idtransaccion.Equals(id)).ToList();
                    foreach (var data in d){
                        DGV.Rows.Add(data.Idtransaccion,
                                            data.Fecha,
                                            data.CuentaDebito,
                                            data.CuentaCredito,
                                            data.Monto,
                                            data.Descripcion,
                                            data.TipoTransaccion,
                                            data.RefFactura);
                    }
                     
                }
            }
            else if (ntable == 6)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.ActivosFijos.Where(c => c.IdActivo.Equals(id)).ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.IdActivo,
                                            data.Descripcion,
                                            data.FechaAdquisicion,
                                            data.ValorAdquisicion,
                                            data.MetodoDepresiacion,
                                            data.VidaUtil,
                                            data.IdResidual);
                    }
                     
                }
            }
            else if (ntable == 7)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.CuentasPorCobrars.Where(c => c.IdCliente.Equals(id)).ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.IdCliente,
                                            data.NombreCliente,
                                            data.FechaFactura,
                                            data.FechaVencimiento,
                                            data.Concepto,
                                            data.MontoFacturado,
                                            data.MontoPendiente,
                                            data.Estadopago);
                    }
                     
                }
            }
            else if (ntable == 8)
            {
                using (var db = new SistemaContabilidadContext())
                {
                    var d = db.PresupuestoGastos.Where(c => c.IdGasto.Equals(id)).ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.IdGasto,
                                            data.Concepto,
                                            data.Montoasignado,
                                            data.Montogastado,
                                            data.FechaRegistro);
                    }
                     
                }
            }
        }

        public void loadclients(ComboBox cmb)
        {
            using (var db = new SistemaContabilidadContext()){
                var d = db.Clientes.ToList();
                cmb.DataSource = d;
                cmb.ValueMember = "IDCLIENTE";
                cmb.DisplayMember = "NOMBRE";
                cmb.SelectedIndex = -1;
            }
        }

        public Int32 LoginUser(string[] txt)
        {
            Int32 res = 0;
            using (var db = new SistemaContabilidadContext()){
                var u = db.Usuarios.Where(c => c.Usuario1.Contains(txt[0]) && c.Contra.Contains(txt[1])).ToList();
                res = u.Count > 0 ? 1 : 0;
            }
            return res;
        }
    }
}
