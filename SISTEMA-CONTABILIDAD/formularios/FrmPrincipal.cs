using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_CONTABILIDAD.formularios
{
    public partial class FrmPrincipal : Form
    {
        LOGICA.LHelpers lh = new LOGICA.LHelpers();
        public string usuario_sesion = "";
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "VENTANA PRINCIPAL USUARIO: " + usuario_sesion;
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            lh.ABRIRfrm(new formularios.Subformularios.FrmClientes(), P_Frm);
        }

        private void btncuentascontable_Click(object sender, EventArgs e)
        {
            lh.ABRIRfrm(new formularios.Subformularios.FrmCuentasContables(), P_Frm);
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            lh.ABRIRfrm(new formularios.Subformularios.FrmPagos(),P_Frm);
        }

        private void btnprestamo_Click(object sender, EventArgs e)
        {
            lh.ABRIRfrm(new formularios.Subformularios.FrmPrestamos(),P_Frm);
        }

        private void btntransaccion_Click(object sender, EventArgs e)
        {
            lh.ABRIRfrm(new formularios.Subformularios.Frmtransacciones(),P_Frm);
        }

        private void btnactivosfijos_Click(object sender, EventArgs e)
        {
            lh.ABRIRfrm(new formularios.Subformularios.FrmActivosfijos(),P_Frm);
        }

        private void btnpresupuestogasto_Click(object sender, EventArgs e)
        {
            lh.ABRIRfrm(new formularios.Subformularios.FrmPresupuestoGasto(),P_Frm);
        }

        private void btncuentasporcobrar_Click(object sender, EventArgs e)
        {
            lh.ABRIRfrm(new formularios.Subformularios.FrmCuentasCobrar(),P_Frm);
        }
    }
}
