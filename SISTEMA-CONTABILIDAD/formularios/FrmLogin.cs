using DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_CONTABILIDAD.formularios
{
    public partial class FrmLogin : Form
    {
        LOGICA.LHelpers h = new LOGICA.LHelpers();
        LOGICA.DB db = new LOGICA.DB();
        formularios.FrmPrincipal p = new formularios.FrmPrincipal();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private Int32 validar()
        {
            Int32 res = 0;
            if (txtusuario.Text.Length == 0){
                h.Warning("El usuario es necesario");
                txtusuario.Focus();
                res++;
                return res;
            }else if (txtcontra.Text.Length == 0){
                h.Warning("La contraseña es necesaria");
                txtcontra.Focus();
                res++;
                return res;
            }
            return res;
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (validar() == 0){
                string[] txt = { txtusuario.Text, txtcontra.Text };
                if (db.LoginUser(txt) > 0){
                    this.Hide();
                    p.usuario_sesion = txtusuario.Text;
                    p.Show();
                }else{
                    h.Warning("usuario y/o contraseña son incorrectos");
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtcontra.Focus();
            txtusuario.Focus();
        }
    }
}
