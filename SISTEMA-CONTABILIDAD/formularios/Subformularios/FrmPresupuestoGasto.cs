using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    public partial class FrmPresupuestoGasto : Form
    {
        LOGICA.LHelpers lh = new LOGICA.LHelpers();
        LOGICA.DB db = new LOGICA.DB();
        public FrmPresupuestoGasto()
        {
            InitializeComponent();
        }

        private void CrgFrm()
        {
            btnnuevo.Enabled = true;
            btnguardar.Enabled = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            txtid.Enabled = false;
            txtconcepto.Enabled = false;
            txtmontoasignado.Enabled = false;
            txtmontogastado.Enabled = false;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
            txtid.Clear();
            txtconcepto.Clear();
            txtmontoasignado.Clear();
            txtmontogastado.Clear();
            db.LoadDataDGV(DGVDATOS, 8);
        }

        private void FrmPresupuestoGasto_Load(object sender, EventArgs e)
        {
            CrgFrm();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string[] txt = { txtconcepto.Text, txtmontoasignado.Text, txtmontogastado.Text };
            if (lh.Validar(txt) == 0)
            {
                if (db.SaveContent(txt, 8) > 0)
                {
                    lh.CudFrmSuccesfuly("c");
                    CrgFrm();
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea eliminar los datos seleccinados?") == true)
            {
                if (db.DeleteContent(txtid.Text, 8) > 0)
                {
                    lh.CudFrmSuccesfuly("d");
                    CrgFrm();
                }
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea actualizar los datos seleccionados?") == true)
            {
                string[] txt = { txtid.Text, txtconcepto.Text, txtmontoasignado.Text, txtmontogastado.Text };
                if (db.UpdateContent(txt, 8) > 0)
                {
                    lh.CudFrmSuccesfuly("u");
                    CrgFrm();
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea cancelar las operaciones actuales?") == true) CrgFrm();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            db.Search(ref DGVDATOS, 8, txtbuscar.Text);
        }

        private void DGVDATOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDATOS.Rows.Count > 0)
            {
                txtid.Text = DGVDATOS.CurrentRow.Cells[0].Value.ToString();
                txtconcepto.Text = DGVDATOS.CurrentRow.Cells[1].Value.ToString();
                txtmontoasignado.Text = DGVDATOS.CurrentRow.Cells[2].Value.ToString();
                txtmontogastado.Text = DGVDATOS.CurrentRow.Cells[3].Value.ToString();

                btnnuevo.Enabled = false;
                btnguardar.Enabled = false;
                btnactualizar.Enabled = true;
                btneliminar.Enabled = true;
                btncancelar.Enabled = true;
                btnsalir.Enabled = false;

                txtid.Enabled = false;
                txtconcepto.Enabled = true;
                txtmontoasignado.Enabled = true;
                txtmontogastado.Enabled = true;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnnuevo.Enabled = false;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = true;
            txtid.Enabled = false;
            txtconcepto.Enabled = true;
            txtmontoasignado.Enabled = true;
            txtmontogastado.Enabled = true;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = false;
        }

        private void txtconcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }

        private void txtmontoasignado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

        private void txtmontogastado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

        private void txtmontogastado_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToDouble(txtmontoasignado.Text) < Convert.ToDouble(txtmontogastado.Text)) lh.Warning("El monto asignado no puede ser menor al monto gastado");
        }
    }
}
