namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    partial class FrmPrestamos
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            groupBox1 = new GroupBox();
            textBox16 = new TextBox();
            btnbuscar = new Button();
            textBox2 = new TextBox();
            txtbuscar = new TextBox();
            DGVDATOS = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            DIRECCION = new DataGridViewTextBoxColumn();
            INFO = new DataGridViewTextBoxColumn();
            SALDO_AC = new DataGridViewTextBoxColumn();
            CLFI = new DataGridViewTextBoxColumn();
            CLFF = new DataGridViewTextBoxColumn();
            CLPM = new DataGridViewTextBoxColumn();
            CLPT = new DataGridViewTextBoxColumn();
            GBtxts = new GroupBox();
            DTPfechafinal = new DateTimePicker();
            label9 = new Label();
            textBox14 = new TextBox();
            txtpagosT = new TextBox();
            label8 = new Label();
            textBox12 = new TextBox();
            txtpagosM = new TextBox();
            label7 = new Label();
            textBox11 = new TextBox();
            label6 = new Label();
            textBox9 = new TextBox();
            txtplazomeses = new TextBox();
            label3 = new Label();
            textBox8 = new TextBox();
            textBox5 = new TextBox();
            txtTasainteres = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            CBCLIENTE = new ComboBox();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            txtmonto = new TextBox();
            textBox4 = new TextBox();
            textBox7 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtid = new TextBox();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDATOS).BeginInit();
            GBtxts.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Gray;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnnuevo, toolStripSeparator1, btnguardar, toolStripSeparator2, btneliminar, toolStripSeparator3, btnactualizar, toolStripSeparator4, btncancelar, toolStripSeparator5, btnsalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(905, 25);
            toolStrip1.TabIndex = 3;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox16);
            groupBox1.Controls.Add(btnbuscar);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(txtbuscar);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(244, 207);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(282, 62);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "BUSCAR PRESTAMO:";
            // 
            // textBox16
            // 
            textBox16.BackColor = Color.Blue;
            textBox16.Enabled = false;
            textBox16.Location = new Point(139, 51);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(129, 1);
            textBox16.TabIndex = 45;
            // 
            // btnbuscar
            // 
            btnbuscar.FlatAppearance.BorderSize = 0;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Location = new Point(8, 21);
            btnbuscar.Margin = new Padding(4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(114, 32);
            btnbuscar.TabIndex = 18;
            btnbuscar.Text = "BUSCAR";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Blue;
            textBox2.Enabled = false;
            textBox2.Location = new Point(139, 52);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 0);
            textBox2.TabIndex = 17;
            // 
            // txtbuscar
            // 
            txtbuscar.BackColor = Color.FromArgb(64, 64, 64);
            txtbuscar.BorderStyle = BorderStyle.None;
            txtbuscar.ForeColor = Color.FromArgb(224, 224, 224);
            txtbuscar.Location = new Point(139, 24);
            txtbuscar.Margin = new Padding(4);
            txtbuscar.Multiline = true;
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(129, 27);
            txtbuscar.TabIndex = 16;
            // 
            // DGVDATOS
            // 
            DGVDATOS.AllowUserToAddRows = false;
            DGVDATOS.AllowUserToDeleteRows = false;
            DGVDATOS.AllowUserToResizeColumns = false;
            DGVDATOS.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVDATOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVDATOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDATOS.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, DIRECCION, INFO, SALDO_AC, CLFI, CLFF, CLPM, CLPT });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DGVDATOS.DefaultCellStyle = dataGridViewCellStyle6;
            DGVDATOS.GridColor = SystemColors.ControlDark;
            DGVDATOS.Location = new Point(5, 290);
            DGVDATOS.Margin = new Padding(4);
            DGVDATOS.Name = "DGVDATOS";
            DGVDATOS.ReadOnly = true;
            DGVDATOS.RowHeadersVisible = false;
            DGVDATOS.Size = new Size(892, 211);
            DGVDATOS.TabIndex = 25;
            DGVDATOS.CellDoubleClick += DGVDATOS_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID ";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 70;
            // 
            // NAME
            // 
            NAME.HeaderText = "CLIENTE";
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            NAME.Width = 160;
            // 
            // DIRECCION
            // 
            DIRECCION.HeaderText = "MONTO";
            DIRECCION.Name = "DIRECCION";
            DIRECCION.ReadOnly = true;
            DIRECCION.Width = 140;
            // 
            // INFO
            // 
            INFO.HeaderText = "TASA INTERES";
            INFO.Name = "INFO";
            INFO.ReadOnly = true;
            INFO.Width = 80;
            // 
            // SALDO_AC
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SALDO_AC.DefaultCellStyle = dataGridViewCellStyle5;
            SALDO_AC.HeaderText = "PLAZO AÑOS";
            SALDO_AC.Name = "SALDO_AC";
            SALDO_AC.ReadOnly = true;
            SALDO_AC.Width = 90;
            // 
            // CLFI
            // 
            CLFI.HeaderText = "FECHA INICIO";
            CLFI.Name = "CLFI";
            CLFI.ReadOnly = true;
            CLFI.Width = 70;
            // 
            // CLFF
            // 
            CLFF.HeaderText = "FECHA FINAL";
            CLFF.Name = "CLFF";
            CLFF.ReadOnly = true;
            CLFF.Width = 70;
            // 
            // CLPM
            // 
            CLPM.HeaderText = "PAGOS MENSUALES";
            CLPM.Name = "CLPM";
            CLPM.ReadOnly = true;
            // 
            // CLPT
            // 
            CLPT.HeaderText = "PAGOS TOTALES";
            CLPT.Name = "CLPT";
            CLPT.ReadOnly = true;
            // 
            // GBtxts
            // 
            GBtxts.Controls.Add(DTPfechafinal);
            GBtxts.Controls.Add(label9);
            GBtxts.Controls.Add(textBox14);
            GBtxts.Controls.Add(txtpagosT);
            GBtxts.Controls.Add(label8);
            GBtxts.Controls.Add(textBox12);
            GBtxts.Controls.Add(txtpagosM);
            GBtxts.Controls.Add(label7);
            GBtxts.Controls.Add(textBox11);
            GBtxts.Controls.Add(label6);
            GBtxts.Controls.Add(textBox9);
            GBtxts.Controls.Add(txtplazomeses);
            GBtxts.Controls.Add(label3);
            GBtxts.Controls.Add(textBox8);
            GBtxts.Controls.Add(textBox5);
            GBtxts.Controls.Add(txtTasainteres);
            GBtxts.Controls.Add(label2);
            GBtxts.Controls.Add(textBox3);
            GBtxts.Controls.Add(CBCLIENTE);
            GBtxts.Controls.Add(textBox1);
            GBtxts.Controls.Add(textBox6);
            GBtxts.Controls.Add(txtmonto);
            GBtxts.Controls.Add(textBox4);
            GBtxts.Controls.Add(textBox7);
            GBtxts.Controls.Add(label5);
            GBtxts.Controls.Add(label4);
            GBtxts.Controls.Add(label1);
            GBtxts.Controls.Add(txtid);
            GBtxts.ForeColor = SystemColors.ButtonFace;
            GBtxts.Location = new Point(15, 35);
            GBtxts.Margin = new Padding(4);
            GBtxts.Name = "GBtxts";
            GBtxts.Padding = new Padding(4);
            GBtxts.Size = new Size(877, 164);
            GBtxts.TabIndex = 24;
            GBtxts.TabStop = false;
            GBtxts.Text = "INFORMACION DE PRESTAMO:";
            // 
            // DTPfechafinal
            // 
            DTPfechafinal.Format = DateTimePickerFormat.Short;
            DTPfechafinal.Location = new Point(437, 109);
            DTPfechafinal.Name = "DTPfechafinal";
            DTPfechafinal.Size = new Size(133, 27);
            DTPfechafinal.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(348, 118);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(23, 19);
            label9.TabIndex = 52;
            label9.Text = "%";
            // 
            // textBox14
            // 
            textBox14.BackColor = Color.Blue;
            textBox14.Enabled = false;
            textBox14.Location = new Point(630, 136);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(134, 1);
            textBox14.TabIndex = 51;
            // 
            // txtpagosT
            // 
            txtpagosT.BackColor = Color.FromArgb(64, 64, 64);
            txtpagosT.BorderStyle = BorderStyle.None;
            txtpagosT.ForeColor = Color.FromArgb(224, 224, 224);
            txtpagosT.Location = new Point(630, 109);
            txtpagosT.Margin = new Padding(4);
            txtpagosT.Multiline = true;
            txtpagosT.Name = "txtpagosT";
            txtpagosT.Size = new Size(134, 25);
            txtpagosT.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(632, 86);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 19);
            label8.TabIndex = 49;
            label8.Text = "PAGOS TOTALES";
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.Blue;
            textBox12.Enabled = false;
            textBox12.Location = new Point(632, 70);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(134, 1);
            textBox12.TabIndex = 48;
            // 
            // txtpagosM
            // 
            txtpagosM.BackColor = Color.FromArgb(64, 64, 64);
            txtpagosM.BorderStyle = BorderStyle.None;
            txtpagosM.ForeColor = Color.FromArgb(224, 224, 224);
            txtpagosM.Location = new Point(632, 43);
            txtpagosM.Margin = new Padding(4);
            txtpagosM.Multiline = true;
            txtpagosM.Name = "txtpagosM";
            txtpagosM.Size = new Size(134, 25);
            txtpagosM.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(620, 20);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(155, 19);
            label7.TabIndex = 46;
            label7.Text = "PAGOS MENSUALES";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.Blue;
            textBox11.Enabled = false;
            textBox11.Location = new Point(436, 139);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(134, 1);
            textBox11.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(448, 90);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 42;
            label6.Text = "FECHA FINAL";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Blue;
            textBox9.Enabled = false;
            textBox9.Location = new Point(435, 74);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(134, 1);
            textBox9.TabIndex = 41;
            // 
            // txtplazomeses
            // 
            txtplazomeses.BackColor = Color.FromArgb(64, 64, 64);
            txtplazomeses.BorderStyle = BorderStyle.None;
            txtplazomeses.ForeColor = Color.FromArgb(224, 224, 224);
            txtplazomeses.Location = new Point(435, 47);
            txtplazomeses.Margin = new Padding(4);
            txtplazomeses.Multiline = true;
            txtplazomeses.Name = "txtplazomeses";
            txtplazomeses.Size = new Size(134, 25);
            txtplazomeses.TabIndex = 40;
            txtplazomeses.KeyDown += txtplazoaños_KeyDown;
            txtplazomeses.KeyPress += txtplazomeses_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 19);
            label3.TabIndex = 39;
            label3.Text = "PLAZO EN MESES";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Blue;
            textBox8.Enabled = false;
            textBox8.Location = new Point(288, 141);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(52, 1);
            textBox8.TabIndex = 38;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Blue;
            textBox5.Enabled = false;
            textBox5.Location = new Point(220, 74);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 1);
            textBox5.TabIndex = 35;
            // 
            // txtTasainteres
            // 
            txtTasainteres.BackColor = Color.FromArgb(64, 64, 64);
            txtTasainteres.BorderStyle = BorderStyle.None;
            txtTasainteres.ForeColor = Color.FromArgb(224, 224, 224);
            txtTasainteres.Location = new Point(288, 114);
            txtTasainteres.Margin = new Padding(4);
            txtTasainteres.Multiline = true;
            txtTasainteres.Name = "txtTasainteres";
            txtTasainteres.Size = new Size(52, 25);
            txtTasainteres.TabIndex = 37;
            txtTasainteres.KeyDown += txtTasainteres_KeyDown;
            txtTasainteres.KeyPress += txtTasainteres_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 19);
            label2.TabIndex = 36;
            label2.Text = "TASA DE INTERES ANUAL";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Blue;
            textBox3.Enabled = false;
            textBox3.Location = new Point(19, 138);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 1);
            textBox3.TabIndex = 34;
            // 
            // CBCLIENTE
            // 
            CBCLIENTE.BackColor = Color.FromArgb(64, 64, 64);
            CBCLIENTE.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCLIENTE.FlatStyle = FlatStyle.Popup;
            CBCLIENTE.ForeColor = Color.FromArgb(224, 224, 224);
            CBCLIENTE.FormattingEnabled = true;
            CBCLIENTE.Location = new Point(19, 108);
            CBCLIENTE.Name = "CBCLIENTE";
            CBCLIENTE.Size = new Size(167, 27);
            CBCLIENTE.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Blue;
            textBox1.Enabled = false;
            textBox1.Location = new Point(38, 70);
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
            // txtmonto
            // 
            txtmonto.BackColor = Color.FromArgb(64, 64, 64);
            txtmonto.BorderStyle = BorderStyle.None;
            txtmonto.ForeColor = Color.FromArgb(224, 224, 224);
            txtmonto.Location = new Point(220, 47);
            txtmonto.Margin = new Padding(4);
            txtmonto.Multiline = true;
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(176, 25);
            txtmonto.TabIndex = 17;
            txtmonto.KeyDown += txtmonto_KeyDown;
            txtmonto.KeyPress += txtmonto_KeyPress;
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
            textBox7.Location = new Point(38, 77);
            textBox7.Margin = new Padding(4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(129, 0);
            textBox7.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 86);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 9;
            label5.Text = "CLIENTE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 24);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 7;
            label4.Text = "MONTO ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 20);
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
            txtid.ForeColor = Color.FromArgb(224, 224, 224);
            txtid.Location = new Point(38, 48);
            txtid.Margin = new Padding(4);
            txtid.Name = "txtid";
            txtid.Size = new Size(129, 20);
            txtid.TabIndex = 0;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(905, 514);
            Controls.Add(groupBox1);
            Controls.Add(DGVDATOS);
            Controls.Add(GBtxts);
            Controls.Add(toolStrip1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = Color.Maroon;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmPrestamos";
            Text = "FrmPrestamos";
            Load += FrmPrestamos_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDATOS).EndInit();
            GBtxts.ResumeLayout(false);
            GBtxts.PerformLayout();
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
        private GroupBox groupBox1;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private TextBox textBox2;
        private DataGridView DGVDATOS;
        private GroupBox GBtxts;
        private TextBox textBox6;
        private TextBox txtmonto;
        private TextBox textBox4;
        private TextBox txtdireccion;
        private TextBox textBox7;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtid;
        private TextBox textBox1;
        private TextBox textBox3;
        private ComboBox CBCLIENTE;
        private TextBox textBox5;
        private TextBox textBox8;
        private TextBox txtTasainteres;
        private Label label2;
        private TextBox textBox11;
        private Label label6;
        private TextBox textBox9;
        private TextBox txtplazomeses;
        private Label label3;
        private TextBox textBox14;
        private TextBox txtpagosT;
        private Label label8;
        private TextBox textBox12;
        private TextBox txtpagosM;
        private Label label7;
        private TextBox textBox16;
        private Label label9;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn DIRECCION;
        private DataGridViewTextBoxColumn INFO;
        private DataGridViewTextBoxColumn SALDO_AC;
        private DataGridViewTextBoxColumn CLFI;
        private DataGridViewTextBoxColumn CLFF;
        private DataGridViewTextBoxColumn CLPM;
        private DataGridViewTextBoxColumn CLPT;
        private DateTimePicker DTPfechafinal;
    }
}