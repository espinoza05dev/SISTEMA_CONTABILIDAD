using DATA;
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
using static System.Net.Mime.MediaTypeNames;

namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    public partial class Frmtransacciones : Form
    {
        LOGICA.LHelpers lh = new LOGICA.LHelpers();
        LOGICA.DB db = new LOGICA.DB();
        public Frmtransacciones()
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
            rdcredito.Enabled = false;
            rddebito.Enabled = false;
            txtmonto.Enabled = false;
            txtdescripcion.Enabled = false;
            CBtipotransaccion.Enabled = false;
            rdreffactura.Enabled = false;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
            txtid.Clear();
            rdcredito.Checked = false;
            rddebito.Checked = false;
            txtmonto.Clear();
            txtdescripcion.Clear();
            CBtipotransaccion.SelectedIndex = -1;
            rdreffactura.Checked = false;
            db.LoadDataDGV(DGVDATOS, 5);
        }

        private void DGVDATOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDATOS.Rows.Count > 0)
            {
                txtid.Text = DGVDATOS.CurrentRow.Cells[0].Value.ToString();
                rddebito.Checked = Convert.ToBoolean(DGVDATOS.CurrentRow.Cells[2].Value.ToString());
                rdcredito.Checked = Convert.ToBoolean(DGVDATOS.CurrentRow.Cells[3].Value.ToString());
                txtmonto.Text = DGVDATOS.CurrentRow.Cells[4].Value.ToString();
                txtdescripcion.Text = DGVDATOS.CurrentRow.Cells[5].Value.ToString();
                CBtipotransaccion.Text = DGVDATOS.CurrentRow.Cells[6].Value.ToString();
                rdreffactura.Checked = Convert.ToBoolean(DGVDATOS.CurrentRow.Cells[7].Value.ToString());

                btnnuevo.Enabled = false;
                btnguardar.Enabled = false;
                btnactualizar.Enabled = true;
                btneliminar.Enabled = true;
                btncancelar.Enabled = true;
                btnsalir.Enabled = false;

                txtid.Enabled = false;
                rddebito.Enabled = true;
                rdcredito.Enabled = true;
                txtmonto.Enabled = true;
                txtdescripcion.Enabled = true;
                CBtipotransaccion.Enabled = true;
                rdreffactura.Enabled = true;
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
            rdcredito.Enabled = true;
            rddebito.Enabled = true;
            txtmonto.Enabled = true;
            txtdescripcion.Enabled = true;
            CBtipotransaccion.Enabled = true;
            rdreffactura.Enabled = true;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string[] txt = { txtmonto.Text, txtdescripcion.Text, CBtipotransaccion.Text };
            bool d = rddebito.Checked == true ? Convert.ToBoolean(1) : Convert.ToBoolean(0), c = rdcredito.Checked == true ? Convert.ToBoolean(1) : Convert.ToBoolean(0), rf = rdreffactura.Checked == true ? Convert.ToBoolean(1) : Convert.ToBoolean(0);
            bool[] rds = { d, c, rf };
            if (lh.Validar(txt) == 0)
            {
                if (db.SaveContent(txt, 5, rds) > 0)
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
                if (db.DeleteContent(txtid.Text, 5) > 0)
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
                string[] txt = { txtid.Text, txtmonto.Text, txtdescripcion.Text, CBtipotransaccion.Text };
                bool d = rddebito.Checked == true ? Convert.ToBoolean(1) : Convert.ToBoolean(0), c = rdcredito.Checked == true ? Convert.ToBoolean(1) : Convert.ToBoolean(0), rf = rdreffactura.Checked == true ? Convert.ToBoolean(1) : Convert.ToBoolean(0);
                bool[] rds = { d, c, rf };
                if (db.UpdateContent(txt, 5, rds) > 0)
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

        private void Frmtransacciones_Load(object sender, EventArgs e)
        {
            CrgFrm();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            db.Search(ref DGVDATOS, 5, txtbuscar.Text);
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.OnlyNumber(e) ? false : true;
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Onlystrings(e) ? false : true;
        }
    }
}
