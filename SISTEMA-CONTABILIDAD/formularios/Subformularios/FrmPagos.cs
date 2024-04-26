using LOGICA;
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
    public partial class FrmPagos : Form
    {
        LOGICA.DB db = new LOGICA.DB();
        LOGICA.LHelpers lh = new LOGICA.LHelpers();

        public FrmPagos()
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
            txtfactura.Enabled = false;
            CBMpago.Enabled = false;
            txtmontopagado.Enabled = false;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
            txtid.Clear();
            txtfactura.Clear();
            txtmontopagado.Clear();
            CBMpago.SelectedIndex = -1;
            db.LoadDataDGV(DGVDATOS, 3);
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            CrgFrm();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnnuevo.Enabled = false;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = true;
            txtid.Enabled = false;
            txtfactura.Enabled = true;
            CBMpago.Enabled = true;
            txtmontopagado.Enabled = true;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string[] txt = { txtfactura.Text, CBMpago.Text, txtmontopagado.Text };
            if (lh.Validar(txt) == 0){
                if (db.SaveContent(txt, 3) > 0){
                    lh.CudFrmSuccesfuly("c");
                    CrgFrm();
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea eliminar los datos seleccinados?") == true)
            {
                if (db.DeleteContent(txtid.Text, 3) > 0){
                    lh.CudFrmSuccesfuly("d");
                    CrgFrm();
                }
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (lh.Question("Desea actualizar los datos seleccionados?") == true)
            {
                string[] txt = { txtid.Text,txtfactura.Text, CBMpago.Text, txtmontopagado.Text };
                if (db.UpdateContent(txt, 3) > 0)
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
            db.Search(ref DGVDATOS, 3, txtbuscar.Text);
        }

        private void DGVDATOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDATOS.Rows.Count > 0)
            {
                txtid.Text = DGVDATOS.CurrentRow.Cells[0].Value.ToString();
                txtfactura.Text = DGVDATOS.CurrentRow.Cells[2].Value.ToString();
                CBMpago.Text = DGVDATOS.CurrentRow.Cells[3].Value.ToString();
                txtmontopagado.Text = DGVDATOS.CurrentRow.Cells[4].Value.ToString();

                btnnuevo.Enabled = false;
                btnguardar.Enabled = false;
                btnactualizar.Enabled = true;
                btneliminar.Enabled = true;
                btncancelar.Enabled = true;
                btnsalir.Enabled = false;

                txtid.Enabled = false;
                txtfactura.Enabled = true;
                CBMpago.Enabled = true;
                txtmontopagado.Enabled = true;
            }
        }

        private void txtmontopagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

        private void txtfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }
    }
}
