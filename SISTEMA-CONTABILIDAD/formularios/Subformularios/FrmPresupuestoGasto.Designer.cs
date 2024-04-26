namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    partial class FrmPresupuestoGasto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            btnnuevo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnguardar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btneliminar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnactualizar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btncancelar = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnsalir = new ToolStripButton();
            GBtxts = new GroupBox();
            textBox3 = new TextBox();
            txtmontogastado = new TextBox();
            label3 = new Label();
            textBox8 = new TextBox();
            textBox5 = new TextBox();
            txtconcepto = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            txtmontoasignado = new TextBox();
            textBox4 = new TextBox();
            textBox7 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtid = new TextBox();
            groupBox1 = new GroupBox();
            textBox16 = new TextBox();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            textBox2 = new TextBox();
            DGVDATOS = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            DIRECCION = new DataGridViewTextBoxColumn();
            INFO = new DataGridViewTextBoxColumn();
            SALDO_AC = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            GBtxts.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDATOS).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Gray;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnnuevo, toolStripSeparator1, btnguardar, toolStripSeparator2, btneliminar, toolStripSeparator3, btnactualizar, toolStripSeparator4, btncancelar, toolStripSeparator5, btnsalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(899, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "TSBOTONES";
            // 
            // btnnuevo
            // 
            btnnuevo.ForeColor = SystemColors.ButtonHighlight;
            btnnuevo.Image = Properties.Resources.boton_agregar;
            btnnuevo.ImageTransparentColor = Color.Magenta;
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(66, 22);
            btnnuevo.Text = "NUEVO";
            btnnuevo.Click += btnnuevo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnguardar
            // 
            btnguardar.ForeColor = SystemColors.ButtonHighlight;
            btnguardar.Image = Properties.Resources.save_24px;
            btnguardar.ImageTransparentColor = Color.Magenta;
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(81, 22);
            btnguardar.Text = "GUARDAR";
            btnguardar.Click += btnguardar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btneliminar
            // 
            btneliminar.ForeColor = SystemColors.ButtonHighlight;
            btneliminar.Image = Properties.Resources.delete_24px;
            btneliminar.ImageTransparentColor = Color.Magenta;
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(80, 22);
            btneliminar.Text = "ELIMINAR";
            btneliminar.Click += btneliminar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btnactualizar
            // 
            btnactualizar.ForeColor = SystemColors.ButtonHighlight;
            btnactualizar.Image = Properties.Resources.edit_24px;
            btnactualizar.ImageTransparentColor = Color.Magenta;
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(96, 22);
            btnactualizar.Text = "ACTUALIZAR";
            btnactualizar.Click += btnactualizar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // btncancelar
            // 
            btncancelar.ForeColor = SystemColors.ButtonHighlight;
            btncancelar.Image = Properties.Resources.cancel_24px;
            btncancelar.ImageTransparentColor = Color.Magenta;
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(87, 22);
            btncancelar.Text = "CANCELAR";
            btncancelar.Click += btncancelar_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // btnsalir
            // 
            btnsalir.Alignment = ToolStripItemAlignment.Right;
            btnsalir.ForeColor = SystemColors.ButtonHighlight;
            btnsalir.Image = Properties.Resources.exit_24px;
            btnsalir.ImageTransparentColor = Color.Magenta;
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(57, 22);
            btnsalir.Text = "SALIR";
            btnsalir.Click += btnsalir_Click;
            // 
            // GBtxts
            // 
            GBtxts.Controls.Add(textBox3);
            GBtxts.Controls.Add(txtmontogastado);
            GBtxts.Controls.Add(label3);
            GBtxts.Controls.Add(textBox8);
            GBtxts.Controls.Add(textBox5);
            GBtxts.Controls.Add(txtconcepto);
            GBtxts.Controls.Add(label2);
            GBtxts.Controls.Add(textBox1);
            GBtxts.Controls.Add(textBox6);
            GBtxts.Controls.Add(txtmontoasignado);
            GBtxts.Controls.Add(textBox4);
            GBtxts.Controls.Add(textBox7);
            GBtxts.Controls.Add(label4);
            GBtxts.Controls.Add(label1);
            GBtxts.Controls.Add(txtid);
            GBtxts.ForeColor = SystemColors.ButtonFace;
            GBtxts.Location = new Point(9, 29);
            GBtxts.Margin = new Padding(4);
            GBtxts.Name = "GBtxts";
            GBtxts.Padding = new Padding(4);
            GBtxts.Size = new Size(877, 164);
            GBtxts.TabIndex = 28;
            GBtxts.TabStop = false;
            GBtxts.Text = "INFORMACION DE PRESUPUESTO:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Blue;
            textBox3.Enabled = false;
            textBox3.Location = new Point(603, 137);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 1);
            textBox3.TabIndex = 41;
            // 
            // txtmontogastado
            // 
            txtmontogastado.BackColor = Color.FromArgb(64, 64, 64);
            txtmontogastado.BorderStyle = BorderStyle.None;
            txtmontogastado.Location = new Point(603, 110);
            txtmontogastado.Margin = new Padding(4);
            txtmontogastado.Multiline = true;
            txtmontogastado.Name = "txtmontogastado";
            txtmontogastado.Size = new Size(176, 25);
            txtmontogastado.TabIndex = 40;
            txtmontogastado.KeyDown += txtmontogastado_KeyDown;
            txtmontogastado.KeyPress += txtmontogastado_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(617, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 19);
            label3.TabIndex = 39;
            label3.Text = "MONTO GASTADO";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Blue;
            textBox8.Enabled = false;
            textBox8.Location = new Point(230, 151);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(292, 1);
            textBox8.TabIndex = 38;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Blue;
            textBox5.Enabled = false;
            textBox5.Location = new Point(603, 75);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 1);
            textBox5.TabIndex = 35;
            // 
            // txtconcepto
            // 
            txtconcepto.BackColor = Color.FromArgb(64, 64, 64);
            txtconcepto.BorderStyle = BorderStyle.None;
            txtconcepto.Location = new Point(230, 48);
            txtconcepto.Margin = new Padding(4);
            txtconcepto.Multiline = true;
            txtconcepto.Name = "txtconcepto";
            txtconcepto.Size = new Size(292, 100);
            txtconcepto.TabIndex = 37;
            txtconcepto.KeyPress += txtconcepto_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 36;
            label2.Text = "CONCEPTO";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Blue;
            textBox1.Enabled = false;
            textBox1.Location = new Point(72, 97);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 1);
            textBox1.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Blue;
            textBox6.Enabled = false;
            textBox6.Location = new Point(702, 186);
            textBox6.Margin = new Padding(4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(228, 0);
            textBox6.TabIndex = 18;
            // 
            // txtmontoasignado
            // 
            txtmontoasignado.BackColor = Color.FromArgb(64, 64, 64);
            txtmontoasignado.BorderStyle = BorderStyle.None;
            txtmontoasignado.Location = new Point(603, 48);
            txtmontoasignado.Margin = new Padding(4);
            txtmontoasignado.Multiline = true;
            txtmontoasignado.Name = "txtmontoasignado";
            txtmontoasignado.Size = new Size(176, 25);
            txtmontoasignado.TabIndex = 17;
            txtmontoasignado.KeyPress += txtmontoasignado_KeyPress;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Blue;
            textBox4.Enabled = false;
            textBox4.Location = new Point(172, 187);
            textBox4.Margin = new Padding(4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 0);
            textBox4.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Blue;
            textBox7.Enabled = false;
            textBox7.Location = new Point(72, 104);
            textBox7.Margin = new Padding(4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(129, 0);
            textBox7.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(613, 27);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(157, 19);
            label4.TabIndex = 7;
            label4.Text = "MONTO ASIGNADO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtid
            // 
            txtid.BackColor = Color.FromArgb(64, 64, 64);
            txtid.BorderStyle = BorderStyle.None;
            txtid.Location = new Point(72, 75);
            txtid.Margin = new Padding(4);
            txtid.Name = "txtid";
            txtid.Size = new Size(129, 20);
            txtid.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox16);
            groupBox1.Controls.Add(btnbuscar);
            groupBox1.Controls.Add(txtbuscar);
            groupBox1.Controls.Add(textBox2);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(312, 202);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(281, 73);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "BUSCAR PRESUPUESTO POR ID:";
            // 
            // textBox16
            // 
            textBox16.BackColor = Color.Blue;
            textBox16.Enabled = false;
            textBox16.Location = new Point(139, 60);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(129, 1);
            textBox16.TabIndex = 45;
            // 
            // btnbuscar
            // 
            btnbuscar.FlatAppearance.BorderSize = 0;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Location = new Point(16, 30);
            btnbuscar.Margin = new Padding(4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(114, 32);
            btnbuscar.TabIndex = 18;
            btnbuscar.Text = "BUSCAR";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.BackColor = Color.FromArgb(64, 64, 64);
            txtbuscar.BorderStyle = BorderStyle.None;
            txtbuscar.Location = new Point(139, 37);
            txtbuscar.Margin = new Padding(4);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(129, 20);
            txtbuscar.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Blue;
            textBox2.Enabled = false;
            textBox2.Location = new Point(151, 92);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 0);
            textBox2.TabIndex = 17;
            // 
            // DGVDATOS
            // 
            DGVDATOS.AllowUserToAddRows = false;
            DGVDATOS.AllowUserToDeleteRows = false;
            DGVDATOS.AllowUserToResizeColumns = false;
            DGVDATOS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVDATOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVDATOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDATOS.Columns.AddRange(new DataGridViewColumn[] { ID, DIRECCION, INFO, SALDO_AC, NAME });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DGVDATOS.DefaultCellStyle = dataGridViewCellStyle4;
            DGVDATOS.Location = new Point(166, 283);
            DGVDATOS.Margin = new Padding(4);
            DGVDATOS.Name = "DGVDATOS";
            DGVDATOS.ReadOnly = true;
            DGVDATOS.RowHeadersVisible = false;
            DGVDATOS.Size = new Size(568, 199);
            DGVDATOS.TabIndex = 56;
            DGVDATOS.CellDoubleClick += DGVDATOS_CellDoubleClick;
            // 
            // ID
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.HeaderText = "ID ";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 70;
            // 
            // DIRECCION
            // 
            DIRECCION.HeaderText = "CONCEPTO";
            DIRECCION.Name = "DIRECCION";
            DIRECCION.ReadOnly = true;
            DIRECCION.Width = 160;
            // 
            // INFO
            // 
            INFO.HeaderText = "MONTO ASIGNADO";
            INFO.Name = "INFO";
            INFO.ReadOnly = true;
            INFO.Width = 120;
            // 
            // SALDO_AC
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SALDO_AC.DefaultCellStyle = dataGridViewCellStyle3;
            SALDO_AC.HeaderText = "MONTO GASTADO";
            SALDO_AC.Name = "SALDO_AC";
            SALDO_AC.ReadOnly = true;
            SALDO_AC.Width = 120;
            // 
            // NAME
            // 
            NAME.HeaderText = "FECHA REGISTRO";
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            NAME.Width = 90;
            // 
            // FrmPresupuestoGasto
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(899, 495);
            Controls.Add(groupBox1);
            Controls.Add(GBtxts);
            Controls.Add(DGVDATOS);
            Controls.Add(toolStrip1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = Color.Maroon;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmPresupuestoGasto";
            Text = "FrmPresupuestoGasto";
            Load += FrmPresupuestoGasto_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            GBtxts.ResumeLayout(false);
            GBtxts.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDATOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnnuevo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnguardar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btneliminar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnactualizar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btncancelar;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnsalir;
        private GroupBox GBtxts;
        private TextBox textBox8;
        private TextBox textBox5;
        private TextBox txtconcepto;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox txtmontoasignado;
        private TextBox textBox4;
        private TextBox textBox7;
        private Label label4;
        private Label label1;
        private TextBox txtid;
        private GroupBox groupBox1;
        private TextBox textBox16;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private TextBox textBox2;
        private DataGridView DGVDATOS;
        private TextBox textBox3;
        private TextBox txtmontogastado;
        private Label label3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DIRECCION;
        private DataGridViewTextBoxColumn INFO;
        private DataGridViewTextBoxColumn SALDO_AC;
        private DataGridViewTextBoxColumn NAME;
    }
}