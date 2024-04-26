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
    public partial class FrmCuentasContables : Form
    {
        LOGICA.DB db = new LOGICA.DB();
        LOGICA.LHelpers lh = new LOGICA.LHelpers();
        public FrmCuentasContables()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string[] txt = { txtnombrecuenta.Text, cmbtipocuenta.Text, txtsaldoactual.Text, cmbmoneda.Text, txtdescripcion.Text };
            if (lh.Validar(txt) == 0)
            {
                if (db.SaveContent(txt, 2) > 0)
                {
                    lh.CudFrmSuccesfuly("c");
                    CrgFrm();
                }
            }
        }

        private void CrgFrm()
        {
            btnnuevo.Enabled = true;
            btnguardar.Enabled = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            txtid.Enabled = false;
            txtnombrecuenta.Enabled = false;
            cmbtipocuenta.Enabled = false;
            txtsaldoactual.Enabled = false;
            cmbmoneda.Enabled = false;
            txtdescripcion.Enabled = false;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
            txtid.Clear();
            cmbmoneda.SelectedIndex = -1;
            txtnombrecuenta.Clear();
            cmbtipocuenta.SelectedIndex = -1;
            txtsaldoactual.Clear();
            txtdescripcion.Clear();
            db.LoadDataDGV(DGVDATOS, 2);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnnuevo.Enabled = false;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = true;
            txtid.Enabled = false;
            txtnombrecuenta.Enabled = true;
            cmbtipocuenta.Enabled = true;
            txtsaldoactual.Enabled = true;
            cmbmoneda.Enabled = true;
            txtdescripcion.Enabled = true;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea eliminar los datos seleccinados?") == true)
            {
                if (db.DeleteContent(txtid.Text, 2) > 0)
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
                string[] txt = { txtid.Text, txtnombrecuenta.Text, cmbtipocuenta.Text, txtsaldoactual.Text, cmbmoneda.Text, txtdescripcion.Text };
                if (db.UpdateContent(txt, 2) > 0)
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
            db.Search(ref DGVDATOS, 2, txtbuscar.Text);
        }

        private void DGVDATOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDATOS.Rows.Count > 0)
            {
                txtid.Text = DGVDATOS.CurrentRow.Cells[0].Value.ToString();
                txtnombrecuenta.Text = DGVDATOS.CurrentRow.Cells[1].Value.ToString();
                cmbtipocuenta.Text = DGVDATOS.CurrentRow.Cells[2].Value.ToString();
                txtsaldoactual.Text = DGVDATOS.CurrentRow.Cells[3].Value.ToString();
                cmbmoneda.Text = DGVDATOS.CurrentRow.Cells[4].Value.ToString();
                txtdescripcion.Text = DGVDATOS.CurrentRow.Cells[6].Value.ToString();

                btnnuevo.Enabled = false;
                btnguardar.Enabled = false;
                btnactualizar.Enabled = true;
                btneliminar.Enabled = true;
                btncancelar.Enabled = true;
                btnsalir.Enabled = false;

                txtid.Enabled = false;
                txtnombrecuenta.Enabled = true;
                cmbtipocuenta.Enabled = true;
                txtsaldoactual.Enabled = true;
                cmbmoneda.Enabled = true;
                txtdescripcion.Enabled = true;
            }
        }

        private void FrmCuentasContables_Load(object sender, EventArgs e)
        {
            CrgFrm();
        }

        private void txtsaldoactual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

        private void txtnombrecuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }
    }
}
