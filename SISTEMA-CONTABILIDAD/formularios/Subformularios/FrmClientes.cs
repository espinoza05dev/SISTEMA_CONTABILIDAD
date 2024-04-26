using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    public partial class FrmClientes : Form
    {
        LOGICA.DB db = new LOGICA.DB();
        LOGICA.LHelpers lh = new LOGICA.LHelpers();
        public FrmClientes()
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
            txtnombre.Enabled = false;
            txtdireccion.Enabled = false;
            txtsaldoactual.Enabled = false;
            txtsaldopendiente.Enabled = false;
            txtinfocontacto.Enabled = false;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
            txtid.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txtinfocontacto.Clear();
            txtsaldoactual.Clear();
            txtsaldopendiente.Clear();
            db.LoadDataDGV(DGVDATOS, 1);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnnuevo.Enabled = false;
            btnsalir.Enabled = false;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btncancelar.Enabled = true;
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            txtsaldoactual.Enabled = true;
            txtsaldopendiente.Enabled = true;
            txtinfocontacto.Enabled = true;

            txtid.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txtinfocontacto.Clear();
            txtsaldoactual.Clear();
            txtsaldopendiente.Clear();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string[] txt = { txtnombre.Text, txtdireccion.Text, txtinfocontacto.Text, txtsaldoactual.Text, txtsaldopendiente.Text };
            if (lh.Validar(txt) == 0)
            {
                if (db.SaveContent(txt, 1) > 0)
                {
                    lh.CudFrmSuccesfuly("c");
                    CrgFrm();
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea eliminar los datos seleccionados?") == true)
            {
                if (db.DeleteContent(txtid.Text, 1) > 0)
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
                string[] txt = { txtid.Text, txtnombre.Text, txtdireccion.Text, txtinfocontacto.Text, txtsaldoactual.Text, txtsaldopendiente.Text };
                if (db.UpdateContent(txt, 1) > 0)
                {
                    lh.CudFrmSuccesfuly("u");
                    CrgFrm();
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea Cancelar las operaciones actuales")) CrgFrm();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CrgFrm();
        }


        private void DGVDATOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDATOS.Rows.Count > 0)
            {
                txtid.Text = DGVDATOS.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = DGVDATOS.CurrentRow.Cells[1].Value.ToString();
                txtdireccion.Text = DGVDATOS.CurrentRow.Cells[2].Value.ToString();
                txtinfocontacto.Text = DGVDATOS.CurrentRow.Cells[3].Value.ToString();
                txtsaldoactual.Text = DGVDATOS.CurrentRow.Cells[4].Value.ToString();
                txtsaldopendiente.Text = DGVDATOS.CurrentRow.Cells[5].Value.ToString();

                btnnuevo.Enabled = false;
                btnguardar.Enabled = false;
                btnactualizar.Enabled = true;
                btneliminar.Enabled = true;
                btncancelar.Enabled = true;
                btnsalir.Enabled = false;

                txtnombre.Enabled = true;
                txtdireccion.Enabled = true;
                txtinfocontacto.Enabled = true;
                txtsaldoactual.Enabled = true;
                txtsaldopendiente.Enabled = true;
            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            db.Search(ref DGVDATOS, 1, txtbuscar.Text);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }

        private void txtinfocontacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }

        private void txtsaldoactual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

        private void txtsaldopendiente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

    }
}
