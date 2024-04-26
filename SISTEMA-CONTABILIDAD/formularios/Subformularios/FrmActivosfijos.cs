using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    public partial class FrmActivosfijos : Form
    {
        LOGICA.DB db = new LOGICA.DB();
        LOGICA.LHelpers lh = new LOGICA.LHelpers();
        public FrmActivosfijos()
        {
            InitializeComponent();
        }

        private void crgfrm()
        {
            btnnuevo.Enabled = true;
            btnguardar.Enabled = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            txtid.Enabled = false;
            txtdescripcion.Enabled = false;
            txtvaloradquisicion.Enabled = false;
            txtmetododepresiaion.Enabled = false;
            txtvidautil.Enabled = false;
            txtidresidual.Enabled = false;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
            txtid.Clear();
            txtdescripcion.Clear();
            txtvaloradquisicion.Clear();
            txtmetododepresiaion.Clear();
            txtvidautil.Clear();
            txtidresidual.Clear();
            db.LoadDataDGV(DGVDATOS, 6);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnnuevo.Enabled = false;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = true;
            txtid.Enabled = false;
            txtdescripcion.Enabled = true;
            txtvaloradquisicion.Enabled = true;
            txtmetododepresiaion.Enabled = true;
            txtvidautil.Enabled = true;
            txtidresidual.Enabled = false;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
            txtid.Clear();
            txtdescripcion.Clear();
            txtvaloradquisicion.Clear();
            txtmetododepresiaion.Clear();
            txtvidautil.Clear();
            txtidresidual.Clear();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string[] txt = { txtdescripcion.Text, txtvaloradquisicion.Text, txtmetododepresiaion.Text, txtvidautil.Text };
            if (lh.Validar(txt) == 0)
            {
                if (db.SaveContent(txt, 6) > 0)
                {
                    lh.CudFrmSuccesfuly("c");
                    crgfrm();
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea eliminar las operacion actuales?") == true)
            {
                if (db.DeleteContent(txtid.Text, 6) > 0)
                {
                    lh.CudFrmSuccesfuly("d");
                    crgfrm();
                }
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea actaulizar las operaciones actuales?") == true)
            {
                string[] txt = { txtid.Text, txtdescripcion.Text, txtvaloradquisicion.Text, txtmetododepresiaion.Text, txtvidautil.Text, txtidresidual.Text };
                if (db.UpdateContent(txt, 6) > 0)
                {
                    lh.CudFrmSuccesfuly("u");
                    crgfrm();
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea cancelar las operaciones actuales") == true) crgfrm();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            db.Search(ref DGVDATOS, 6, "", Convert.ToInt16(txtbuscar.Text));
        }

        private void FrmActivosfijos_Load(object sender, EventArgs e)
        {
            crgfrm();
        }

        private void txtvaloradquisicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

        private void txtmetododepresiaion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }

        private void txtvidautil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }

        private void DGVDATOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDATOS.Rows.Count > 0)
            {
                txtid.Text = DGVDATOS.CurrentRow.Cells[0].Value.ToString();
                txtdescripcion.Text = DGVDATOS.CurrentRow.Cells[1].Value.ToString();
                txtvaloradquisicion.Text = DGVDATOS.CurrentRow.Cells[3].Value.ToString();
                txtmetododepresiaion.Text = DGVDATOS.CurrentRow.Cells[4].Value.ToString();
                txtvidautil.Text = DGVDATOS.CurrentRow.Cells[5].Value.ToString();
                txtidresidual.Text = DGVDATOS.CurrentRow.Cells[6].Value.ToString();

                btnnuevo.Enabled = false;
                btnguardar.Enabled = false;
                btnactualizar.Enabled = true;
                btneliminar.Enabled = true;
                btncancelar.Enabled = true;
                txtid.Enabled = false;
                txtdescripcion.Enabled = true;
                txtvaloradquisicion.Enabled = true;
                txtmetododepresiaion.Enabled = true;
                txtvidautil.Enabled = true;
                txtidresidual.Enabled = false;
                txtbuscar.Enabled = true;
                btnsalir.Enabled = true;
            }
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }
    }
}
