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
    public partial class FrmPrestamos : Form
    {
        LOGICA.DB db = new LOGICA.DB();
        LOGICA.LHelpers lh = new LOGICA.LHelpers();
        double Po;
        double tasaInteresAnual;
        public FrmPrestamos()
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
            CBCLIENTE.Enabled = false;
            DTPfechafinal.Enabled = false;
            txtmonto.Enabled = false;
            txtTasainteres.Enabled = false;
            txtplazomeses.Enabled = false;
            txtpagosM.Enabled = false;
            txtpagosT.Enabled = false;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = true;
            txtid.Clear();
            txtmonto.Clear();
            txtTasainteres.Clear();
            txtplazomeses.Clear();
            txtpagosM.Clear();
            txtpagosT.Clear();
            db.LoadDataDGV(DGVDATOS, 4);
            db.loadclients(CBCLIENTE);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnnuevo.Enabled = false;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = true;
            txtid.Enabled = false;
            CBCLIENTE.Enabled = true;
            DTPfechafinal.Enabled = true;
            txtmonto.Enabled = true;
            txtTasainteres.Enabled = true;
            txtplazomeses.Enabled = true;
            txtpagosM.Enabled = false;
            txtpagosT.Enabled = false;
            txtbuscar.Enabled = true;
            btnsalir.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string[] txt = { CBCLIENTE.Text, txtmonto.Text, txtTasainteres.Text, txtplazomeses.Text, DTPfechafinal.Text, txtpagosM.Text, txtpagosT.Text };
            if (lh.Validar(txt) == 0)
            {
                if (db.SaveContent(txt, 4) > 0)
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
                if (db.DeleteContent(txtid.Text, 4) > 0)
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
                string[] txt = { CBCLIENTE.Text, txtmonto.Text, txtplazomeses.Text, DTPfechafinal.Text, txtpagosM.Text, txtpagosT.Text };
                if (db.UpdateContent(txt, 4) > 0)
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
            db.Search(ref DGVDATOS, 4, "", Convert.ToInt32(txtbuscar.Text));
        }

        private void DGVDATOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDATOS.Rows.Count > 0)
            {
                txtid.Text = DGVDATOS.CurrentRow.Cells[0].Value.ToString();
                CBCLIENTE.Text = DGVDATOS.CurrentRow.Cells[1].Value.ToString();
                txtmonto.Text = DGVDATOS.CurrentRow.Cells[2].Value.ToString();
                txtTasainteres.Text = DGVDATOS.CurrentRow.Cells[3].Value.ToString();
                txtplazomeses.Text = DGVDATOS.CurrentRow.Cells[4].Value.ToString();
                DTPfechafinal.Text = DGVDATOS.CurrentRow.Cells[6].Value.ToString();
                txtpagosM.Text = DGVDATOS.CurrentRow.Cells[7].Value.ToString();
                txtpagosT.Text = DGVDATOS.CurrentRow.Cells[8].Value.ToString();

                btnnuevo.Enabled = false;
                btnguardar.Enabled = false;
                btnactualizar.Enabled = true;
                btneliminar.Enabled = true;
                btncancelar.Enabled = true;
                btnsalir.Enabled = false;

                txtid.Enabled = false;
                CBCLIENTE.Enabled = true;
                txtmonto.Enabled = true;
                txtTasainteres.Enabled = true;
                txtplazomeses.Enabled = true;
                DTPfechafinal.Enabled = true;
                txtpagosM.Enabled = true;
                txtpagosT.Enabled = true;
            }
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            CrgFrm();
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.Money(e) ? false : true;
        }

        private void txtplazomeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.OnlyNumber(e) ? false : true;
        }

        private void txtTasainteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = lh.OnlyNumber(e) ? false : true;
        }

        private Int32 Validaciontxts()
        {
            Int32 res = 0;

            if (txtmonto.Text.Length == 0){
                lh.Warning("El monto del prestamo es necesario");
                res++;
            }else if (txtTasainteres.Text.Length == 0){
                lh.Warning("La taza de interes es necesaria");
                res++;
            }else if (txtplazomeses.Text.Length == 0){
                lh.Warning("el plazo en años es necesario");
                res++;
            }

            return res;
        }

        private void porcentaje()
        {
            if (Convert.ToDouble(txtTasainteres.Text) == 1) tasaInteresAnual = 0.01;
            if (Convert.ToDouble(txtTasainteres.Text) == 2) tasaInteresAnual = 0.02;
            if (Convert.ToDouble(txtTasainteres.Text) == 3) tasaInteresAnual = 0.03;
            if (Convert.ToDouble(txtTasainteres.Text) == 4) tasaInteresAnual = 0.04;
            if (Convert.ToDouble(txtTasainteres.Text) == 5) tasaInteresAnual = 0.05;
            if (Convert.ToDouble(txtTasainteres.Text) == 6) tasaInteresAnual = 0.06;
            if (Convert.ToDouble(txtTasainteres.Text) == 7) tasaInteresAnual = 0.07;
            if (Convert.ToDouble(txtTasainteres.Text) == 8) tasaInteresAnual = 0.08;
            if (Convert.ToDouble(txtTasainteres.Text) == 9) tasaInteresAnual = 0.09;
            if (Convert.ToDouble(txtTasainteres.Text) == 10) tasaInteresAnual = 0.10;
            if (Convert.ToDouble(txtTasainteres.Text) == 11) tasaInteresAnual = 0.11;
            if (Convert.ToDouble(txtTasainteres.Text) == 12) tasaInteresAnual = 0.12;
            if (Convert.ToDouble(txtTasainteres.Text) == 13) tasaInteresAnual = 0.13;
            if (Convert.ToDouble(txtTasainteres.Text) == 14) tasaInteresAnual = 0.14;
            if (Convert.ToDouble(txtTasainteres.Text) == 15) tasaInteresAnual = 0.15;
            if (Convert.ToDouble(txtTasainteres.Text) == 16) tasaInteresAnual = 0.16;
            if (Convert.ToDouble(txtTasainteres.Text) == 17) tasaInteresAnual = 0.17;
            if (Convert.ToDouble(txtTasainteres.Text) == 18) tasaInteresAnual = 0.18;
            if (Convert.ToDouble(txtTasainteres.Text) == 19) tasaInteresAnual = 0.19;
            if (Convert.ToDouble(txtTasainteres.Text) == 20) tasaInteresAnual = 0.20;
        }

        private void cuotasmensuales()
        {
            tasaInteresAnual = Convert.ToDouble(txtTasainteres.Text); // Tasa de interés anual (10% en este ejemplo)
            double tasaInteresMensual = tasaInteresAnual / 12; // Tasa de interés mensual

            double cuotaMensual = (Convert.ToInt64(txtmonto.Text) * tasaInteresMensual) /
                (1 - Math.Pow(1 + tasaInteresMensual, - Convert.ToInt16(txtplazomeses.Text)));

            txtpagosM.Text = Math.Round(cuotaMensual,2).ToString();
            txtpagosT.Text = txtplazomeses.Text;
        }

        private void txtmonto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)if(Validaciontxts() == 0) cuotasmensuales();
        }

        private void txtTasainteres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                if (Validaciontxts() == 0){
                    porcentaje();
                    cuotasmensuales();
                }
            }
        }

        private void txtplazoaños_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) if (Validaciontxts() == 0) cuotasmensuales();
        }
    }
}
