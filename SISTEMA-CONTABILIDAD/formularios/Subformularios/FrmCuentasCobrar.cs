using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    public partial class FrmCuentasCobrar : Form
    {
        LOGICA.DB db = new LOGICA.DB();
        LOGICA.LHelpers lh = new LOGICA.LHelpers();
        public FrmCuentasCobrar()
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
            txtidcliente.Enabled = false;
            CBCLIENTE.Enabled = false;
            DTPfVencimiento.Enabled = false;
            txtconcepto.Enabled = false;
            txtmontofacturado.Enabled = false;
            txtmontopendiente.Enabled = false;
            CMBestadopago.Enabled = false;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
            txtidcliente.Clear();
            CBCLIENTE.SelectedIndex = -1;
            txtconcepto.Clear();
            txtmontofacturado.Clear();
            txtmontopendiente.Clear();
            CMBestadopago.SelectedIndex = -1;
            db.LoadDataDGV(DGVDATOS, 7);
            db.loadclients(CBCLIENTE);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnnuevo.Enabled = false;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = true;
            txtidcliente.Enabled = false;
            CBCLIENTE.Enabled = true;
            DTPfVencimiento.Enabled = true;
            txtconcepto.Enabled = true;
            txtmontofacturado.Enabled = true;
            txtmontopendiente.Enabled = true;
            CMBestadopago.Enabled = true;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string[] txt = { CBCLIENTE.Text, DTPfVencimiento.Text, txtconcepto.Text, txtmontofacturado.Text, txtmontopendiente.Text, CMBestadopago.Text };
            if (lh.Validar(txt) == 0)
            {
                if (db.SaveContent(txt, 7) > 0)
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
                if (db.DeleteContent(txtidcliente.Text, 7) > 0)
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
                string[] txt = { txtidcliente.Text, CBCLIENTE.Text, DTPfVencimiento.Text, txtconcepto.Text, txtmontofacturado.Text, txtmontopendiente.Text, CMBestadopago.Text };
                if (db.UpdateContent(txt, 7) > 0)
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
            db.Search(ref DGVDATOS, 7, txtbuscar.Text);
        }

        private void DGVDATOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDATOS.Rows.Count > 0)
            {
                txtidcliente.Text = DGVDATOS.CurrentRow.Cells[0].Value.ToString();
                CBCLIENTE.Text = DGVDATOS.CurrentRow.Cells[1].Value.ToString();
                DTPfVencimiento.Text = DGVDATOS.CurrentRow.Cells[3].Value.ToString();
                txtconcepto.Text = DGVDATOS.CurrentRow.Cells[4].Value.ToString();
                txtmontofacturado.Text = DGVDATOS.CurrentRow.Cells[5].Value.ToString();
                txtmontopendiente.Text = DGVDATOS.CurrentRow.Cells[6].Value.ToString();
                CMBestadopago.Text = DGVDATOS.CurrentRow.Cells[7].Value.ToString();

                btnnuevo.Enabled = false;
                btnguardar.Enabled = false;
                btnactualizar.Enabled = true;
                btneliminar.Enabled = true;
                btncancelar.Enabled = true;
                txtidcliente.Enabled = false;
                CBCLIENTE.Enabled = true;
                DTPfVencimiento.Enabled = true;
                txtconcepto.Enabled = true;
                txtmontofacturado.Enabled = true;
                txtmontopendiente.Enabled = true;
                CMBestadopago.Enabled = true;
                txtbuscar.Enabled = true;
                btnsalir.Enabled = false;
            }
        }

        private void FrmCuentasCobrar_Load(object sender, EventArgs e)
        {
            CrgFrm();
        }

        private void txtconcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }

        private void txtmontofacturado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

        private void txtmontopendiente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

        private void txtestadopago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }
    }
}
