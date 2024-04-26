namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    partial class FrmActivosfijos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            textBox1 = new TextBox();
            txtidresidual = new TextBox();
            label2 = new Label();
            textBox11 = new TextBox();
            txtvidautil = new TextBox();
            textBox9 = new TextBox();
            txtvaloradquisicion = new TextBox();
            textBox6 = new TextBox();
            txtmetododepresiaion = new TextBox();
            textBox4 = new TextBox();
            txtdescripcion = new TextBox();
            textBox7 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtid = new TextBox();
            groupBox1 = new GroupBox();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            textBox2 = new TextBox();
            DGVDATOS = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            DIRECCION = new DataGridViewTextBoxColumn();
            CLvalor = new DataGridViewTextBoxColumn();
            INFO = new DataGridViewTextBoxColumn();
            SALDO_AC = new DataGridViewTextBoxColumn();
            FEC = new DataGridViewTextBoxColumn();
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
            toolStrip1.Size = new Size(873, 25);
            toolStrip1.TabIndex = 1;
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
            GBtxts.Controls.Add(textBox1);
            GBtxts.Controls.Add(txtidresidual);
            GBtxts.Controls.Add(label2);
            GBtxts.Controls.Add(textBox11);
            GBtxts.Controls.Add(txtvidautil);
            GBtxts.Controls.Add(textBox9);
            GBtxts.Controls.Add(txtvaloradquisicion);
            GBtxts.Controls.Add(textBox6);
            GBtxts.Controls.Add(txtmetododepresiaion);
            GBtxts.Controls.Add(textBox4);
            GBtxts.Controls.Add(txtdescripcion);
            GBtxts.Controls.Add(textBox7);
            GBtxts.Controls.Add(label6);
            GBtxts.Controls.Add(label5);
            GBtxts.Controls.Add(label4);
            GBtxts.Controls.Add(label3);
            GBtxts.Controls.Add(label1);
            GBtxts.Controls.Add(txtid);
            GBtxts.ForeColor = SystemColors.ButtonFace;
            GBtxts.Location = new Point(4, 32);
            GBtxts.Name = "GBtxts";
            GBtxts.Size = new Size(865, 165);
            GBtxts.TabIndex = 2;
            GBtxts.TabStop = false;
            GBtxts.Text = "INFORMACION ACTIVO FIJO";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Blue;
            textBox1.Enabled = false;
            textBox1.Location = new Point(719, 142);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 1);
            textBox1.TabIndex = 25;
            // 
            // txtidresidual
            // 
            txtidresidual.BackColor = Color.FromArgb(64, 64, 64);
            txtidresidual.BorderStyle = BorderStyle.None;
            txtidresidual.Location = new Point(719, 119);
            txtidresidual.Name = "txtidresidual";
            txtidresidual.Size = new Size(100, 20);
            txtidresidual.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(719, 97);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 23;
            label2.Text = "ID RESIDUAL";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.Blue;
            textBox11.Enabled = false;
            textBox11.Location = new Point(719, 89);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(101, 1);
            textBox11.TabIndex = 22;
            // 
            // txtvidautil
            // 
            txtvidautil.BackColor = Color.FromArgb(64, 64, 64);
            txtvidautil.BorderStyle = BorderStyle.None;
            txtvidautil.Location = new Point(719, 66);
            txtvidautil.Name = "txtvidautil";
            txtvidautil.Size = new Size(100, 20);
            txtvidautil.TabIndex = 21;
            txtvidautil.KeyPress += txtvidautil_KeyPress;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Blue;
            textBox9.Enabled = false;
            textBox9.Location = new Point(306, 89);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(167, 1);
            textBox9.TabIndex = 20;
            // 
            // txtvaloradquisicion
            // 
            txtvaloradquisicion.BackColor = Color.FromArgb(64, 64, 64);
            txtvaloradquisicion.BorderStyle = BorderStyle.None;
            txtvaloradquisicion.Location = new Point(306, 66);
            txtvaloradquisicion.Name = "txtvaloradquisicion";
            txtvaloradquisicion.Size = new Size(166, 20);
            txtvaloradquisicion.TabIndex = 19;
            txtvaloradquisicion.KeyPress += txtvaloradquisicion_KeyPress;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Blue;
            textBox6.Enabled = false;
            textBox6.Location = new Point(494, 149);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(178, 1);
            textBox6.TabIndex = 18;
            // 
            // txtmetododepresiaion
            // 
            txtmetododepresiaion.BackColor = Color.FromArgb(64, 64, 64);
            txtmetododepresiaion.BorderStyle = BorderStyle.None;
            txtmetododepresiaion.Location = new Point(494, 64);
            txtmetododepresiaion.Multiline = true;
            txtmetododepresiaion.Name = "txtmetododepresiaion";
            txtmetododepresiaion.Size = new Size(178, 79);
            txtmetododepresiaion.TabIndex = 17;
            txtmetododepresiaion.KeyPress += txtmetododepresiaion_KeyPress;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Blue;
            textBox4.Enabled = false;
            textBox4.Location = new Point(117, 119);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 1);
            textBox4.TabIndex = 16;
            // 
            // txtdescripcion
            // 
            txtdescripcion.BackColor = Color.FromArgb(64, 64, 64);
            txtdescripcion.BorderStyle = BorderStyle.None;
            txtdescripcion.Location = new Point(117, 64);
            txtdescripcion.Multiline = true;
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(178, 52);
            txtdescripcion.TabIndex = 15;
            txtdescripcion.KeyPress += txtdescripcion_KeyPress;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Blue;
            textBox7.Enabled = false;
            textBox7.Location = new Point(10, 87);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(101, 1);
            textBox7.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(719, 44);
            label6.Name = "label6";
            label6.Size = new Size(79, 19);
            label6.TabIndex = 11;
            label6.Text = "VIDA UTIL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 44);
            label5.Name = "label5";
            label5.Size = new Size(168, 19);
            label5.TabIndex = 9;
            label5.Text = "VALOR ADQUISICION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 42);
            label4.Name = "label4";
            label4.Size = new Size(189, 19);
            label4.TabIndex = 7;
            label4.Text = "METODO DEPRESIACIÓN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 42);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 5;
            label3.Text = "DESCRIPCION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 42);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtid
            // 
            txtid.BackColor = Color.FromArgb(64, 64, 64);
            txtid.BorderStyle = BorderStyle.None;
            txtid.Location = new Point(10, 64);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 20);
            txtid.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnbuscar);
            groupBox1.Controls.Add(txtbuscar);
            groupBox1.Controls.Add(textBox2);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(311, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 86);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "BUSCAR CLIENTE POR NOMBRE DE CUENTA:";
            // 
            // btnbuscar
            // 
            btnbuscar.FlatAppearance.BorderSize = 0;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Location = new Point(22, 48);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(89, 25);
            btnbuscar.TabIndex = 18;
            btnbuscar.Text = "BUSCAR";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.BackColor = Color.FromArgb(64, 64, 64);
            txtbuscar.BorderStyle = BorderStyle.None;
            txtbuscar.Location = new Point(117, 50);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(100, 20);
            txtbuscar.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Blue;
            textBox2.Enabled = false;
            textBox2.Location = new Point(117, 73);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 1);
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
            DGVDATOS.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, DIRECCION, CLvalor, INFO, SALDO_AC, FEC });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVDATOS.DefaultCellStyle = dataGridViewCellStyle3;
            DGVDATOS.GridColor = SystemColors.ControlDark;
            DGVDATOS.Location = new Point(14, 308);
            DGVDATOS.Name = "DGVDATOS";
            DGVDATOS.ReadOnly = true;
            DGVDATOS.RowHeadersVisible = false;
            DGVDATOS.Size = new Size(855, 201);
            DGVDATOS.TabIndex = 20;
            DGVDATOS.CellDoubleClick += DGVDATOS_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID ";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 40;
            // 
            // NAME
            // 
            NAME.HeaderText = "DESCRIPCION";
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            NAME.Width = 187;
            // 
            // DIRECCION
            // 
            DIRECCION.HeaderText = "FECHA ADQUISICION";
            DIRECCION.Name = "DIRECCION";
            DIRECCION.ReadOnly = true;
            DIRECCION.Width = 130;
            // 
            // CLvalor
            // 
            CLvalor.HeaderText = "VALOR ADQUISICION";
            CLvalor.Name = "CLvalor";
            CLvalor.ReadOnly = true;
            CLvalor.Width = 120;
            // 
            // INFO
            // 
            INFO.HeaderText = "METODO DEPRESIACION";
            INFO.Name = "INFO";
            INFO.ReadOnly = true;
            INFO.Width = 140;
            // 
            // SALDO_AC
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SALDO_AC.DefaultCellStyle = dataGridViewCellStyle2;
            SALDO_AC.HeaderText = "VIDA UTIL";
            SALDO_AC.Name = "SALDO_AC";
            SALDO_AC.ReadOnly = true;
            SALDO_AC.Width = 105;
            // 
            // FEC
            // 
            FEC.HeaderText = "ID RESIDUAL";
            FEC.Name = "FEC";
            FEC.ReadOnly = true;
            FEC.Width = 125;
            // 
            // FrmActivosfijos
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(873, 521);
            Controls.Add(groupBox1);
            Controls.Add(DGVDATOS);
            Controls.Add(GBtxts);
            Controls.Add(toolStrip1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = Color.Maroon;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmActivosfijos";
            Text = "FrmActivosfijos";
            Load += FrmActivosfijos_Load;
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
        private TextBox textBox11;
        private TextBox txtvidautil;
        private TextBox textBox9;
        private TextBox txtvaloradquisicion;
        private TextBox textBox6;
        private TextBox txtmetododepresiaion;
        private TextBox textBox4;
        private TextBox txtdescripcion;
        private TextBox textBox7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtid;
        private TextBox textBox1;
        private TextBox txtidresidual;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private TextBox textBox2;
        private DataGridView DGVDATOS;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn DIRECCION;
        private DataGridViewTextBoxColumn CLvalor;
        private DataGridViewTextBoxColumn INFO;
        private DataGridViewTextBoxColumn SALDO_AC;
        private DataGridViewTextBoxColumn FEC;
    }
}