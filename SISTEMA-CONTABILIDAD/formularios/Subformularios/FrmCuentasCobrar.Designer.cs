namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    partial class FrmCuentasCobrar
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            textBox2 = new TextBox();
            DGVDATOS = new DataGridView();
            NAME = new DataGridViewTextBoxColumn();
            DIRECCION = new DataGridViewTextBoxColumn();
            INFO = new DataGridViewTextBoxColumn();
            SALDO_AC = new DataGridViewTextBoxColumn();
            CCONCEPTO = new DataGridViewTextBoxColumn();
            CMONTO = new DataGridViewTextBoxColumn();
            CLMP = new DataGridViewTextBoxColumn();
            CESTADO = new DataGridViewTextBoxColumn();
            GBtxts = new GroupBox();
            CMBestadopago = new ComboBox();
            CBCLIENTE = new ComboBox();
            textBox3 = new TextBox();
            txtmontopendiente = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            txtmontofacturado = new TextBox();
            label6 = new Label();
            label2 = new Label();
            DTPfVencimiento = new DateTimePicker();
            textBox9 = new TextBox();
            textBox6 = new TextBox();
            txtconcepto = new TextBox();
            textBox4 = new TextBox();
            txtidcliente = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            toolStrip1.TabIndex = 24;
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
            groupBox1.Controls.Add(btnbuscar);
            groupBox1.Controls.Add(txtbuscar);
            groupBox1.Controls.Add(textBox2);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(320, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 86);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "BUSCAR CLIENTE:";
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
            DGVDATOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDATOS.Columns.AddRange(new DataGridViewColumn[] { NAME, DIRECCION, INFO, SALDO_AC, CCONCEPTO, CMONTO, CLMP, CESTADO });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVDATOS.DefaultCellStyle = dataGridViewCellStyle2;
            DGVDATOS.Location = new Point(28, 293);
            DGVDATOS.Name = "DGVDATOS";
            DGVDATOS.ReadOnly = true;
            DGVDATOS.RowHeadersVisible = false;
            DGVDATOS.Size = new Size(846, 201);
            DGVDATOS.TabIndex = 26;
            DGVDATOS.CellDoubleClick += DGVDATOS_CellDoubleClick;
            // 
            // NAME
            // 
            NAME.HeaderText = "ID CLIENTE";
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            // 
            // DIRECCION
            // 
            DIRECCION.HeaderText = "NOMBRE CLIENTE";
            DIRECCION.Name = "DIRECCION";
            DIRECCION.ReadOnly = true;
            // 
            // INFO
            // 
            INFO.HeaderText = "FECHA FACTURA";
            INFO.Name = "INFO";
            INFO.ReadOnly = true;
            // 
            // SALDO_AC
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SALDO_AC.DefaultCellStyle = dataGridViewCellStyle1;
            SALDO_AC.HeaderText = "FECHA VENCIMIENTO";
            SALDO_AC.Name = "SALDO_AC";
            SALDO_AC.ReadOnly = true;
            SALDO_AC.Width = 120;
            // 
            // CCONCEPTO
            // 
            CCONCEPTO.HeaderText = "CONCEPTO";
            CCONCEPTO.Name = "CCONCEPTO";
            CCONCEPTO.ReadOnly = true;
            // 
            // CMONTO
            // 
            CMONTO.HeaderText = "MONTO FACTURADO";
            CMONTO.Name = "CMONTO";
            CMONTO.ReadOnly = true;
            CMONTO.Width = 120;
            // 
            // CLMP
            // 
            CLMP.HeaderText = "MONTO PENDIENTE";
            CLMP.Name = "CLMP";
            CLMP.ReadOnly = true;
            // 
            // CESTADO
            // 
            CESTADO.HeaderText = "ESTADO PAGO";
            CESTADO.Name = "CESTADO";
            CESTADO.ReadOnly = true;
            // 
            // GBtxts
            // 
            GBtxts.Controls.Add(CMBestadopago);
            GBtxts.Controls.Add(CBCLIENTE);
            GBtxts.Controls.Add(textBox3);
            GBtxts.Controls.Add(txtmontopendiente);
            GBtxts.Controls.Add(label8);
            GBtxts.Controls.Add(textBox5);
            GBtxts.Controls.Add(label7);
            GBtxts.Controls.Add(textBox1);
            GBtxts.Controls.Add(txtmontofacturado);
            GBtxts.Controls.Add(label6);
            GBtxts.Controls.Add(label2);
            GBtxts.Controls.Add(DTPfVencimiento);
            GBtxts.Controls.Add(textBox9);
            GBtxts.Controls.Add(textBox6);
            GBtxts.Controls.Add(txtconcepto);
            GBtxts.Controls.Add(textBox4);
            GBtxts.Controls.Add(txtidcliente);
            GBtxts.Controls.Add(label5);
            GBtxts.Controls.Add(label4);
            GBtxts.Controls.Add(label3);
            GBtxts.ForeColor = SystemColors.ButtonFace;
            GBtxts.Location = new Point(28, 30);
            GBtxts.Name = "GBtxts";
            GBtxts.Size = new Size(865, 165);
            GBtxts.TabIndex = 25;
            GBtxts.TabStop = false;
            GBtxts.Text = "INFORMACION DE CUENTA";
            // 
            // CMBestadopago
            // 
            CMBestadopago.BackColor = Color.FromArgb(64, 64, 64);
            CMBestadopago.DropDownStyle = ComboBoxStyle.DropDownList;
            CMBestadopago.FlatStyle = FlatStyle.Popup;
            CMBestadopago.ForeColor = SystemColors.Info;
            CMBestadopago.FormattingEnabled = true;
            CMBestadopago.Items.AddRange(new object[] { "PAGADO", "NO COMPLETO" });
            CMBestadopago.Location = new Point(648, 111);
            CMBestadopago.Name = "CMBestadopago";
            CMBestadopago.Size = new Size(167, 27);
            CMBestadopago.TabIndex = 33;
            // 
            // CBCLIENTE
            // 
            CBCLIENTE.BackColor = Color.FromArgb(64, 64, 64);
            CBCLIENTE.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCLIENTE.FlatStyle = FlatStyle.Popup;
            CBCLIENTE.ForeColor = SystemColors.Info;
            CBCLIENTE.FormattingEnabled = true;
            CBCLIENTE.Location = new Point(6, 111);
            CBCLIENTE.Name = "CBCLIENTE";
            CBCLIENTE.Size = new Size(167, 27);
            CBCLIENTE.TabIndex = 32;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Blue;
            textBox3.Enabled = false;
            textBox3.Location = new Point(648, 72);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 1);
            textBox3.TabIndex = 31;
            // 
            // txtmontopendiente
            // 
            txtmontopendiente.BackColor = Color.FromArgb(64, 64, 64);
            txtmontopendiente.BorderStyle = BorderStyle.None;
            txtmontopendiente.Location = new Point(648, 50);
            txtmontopendiente.Multiline = true;
            txtmontopendiente.Name = "txtmontopendiente";
            txtmontopendiente.Size = new Size(167, 20);
            txtmontopendiente.TabIndex = 30;
            txtmontopendiente.KeyPress += txtmontopendiente_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(656, 28);
            label8.Name = "label8";
            label8.Size = new Size(151, 19);
            label8.TabIndex = 29;
            label8.Text = "MONTO PENDIENTE";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Blue;
            textBox5.Enabled = false;
            textBox5.Location = new Point(648, 140);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(167, 1);
            textBox5.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(656, 89);
            label7.Name = "label7";
            label7.Size = new Size(149, 19);
            label7.TabIndex = 26;
            label7.Text = "ESTADO DEL PAGO";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Blue;
            textBox1.Enabled = false;
            textBox1.Location = new Point(463, 144);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 1);
            textBox1.TabIndex = 25;
            // 
            // txtmontofacturado
            // 
            txtmontofacturado.BackColor = Color.FromArgb(64, 64, 64);
            txtmontofacturado.BorderStyle = BorderStyle.None;
            txtmontofacturado.Location = new Point(463, 122);
            txtmontofacturado.Multiline = true;
            txtmontofacturado.Name = "txtmontofacturado";
            txtmontofacturado.Size = new Size(167, 20);
            txtmontofacturado.TabIndex = 24;
            txtmontofacturado.KeyPress += txtmontofacturado_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 100);
            label6.Name = "label6";
            label6.Size = new Size(166, 19);
            label6.TabIndex = 23;
            label6.Text = "MONTO FACTURADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 25);
            label2.Name = "label2";
            label2.Size = new Size(192, 19);
            label2.TabIndex = 22;
            label2.Text = "FECHA DE VENCIMIENTO";
            // 
            // DTPfVencimiento
            // 
            DTPfVencimiento.Format = DateTimePickerFormat.Short;
            DTPfVencimiento.Location = new Point(482, 47);
            DTPfVencimiento.MaxDate = new DateTime(2110, 12, 31, 0, 0, 0, 0);
            DTPfVencimiento.MinDate = new DateTime(2024, 4, 6, 0, 0, 0, 0);
            DTPfVencimiento.Name = "DTPfVencimiento";
            DTPfVencimiento.Size = new Size(128, 27);
            DTPfVencimiento.TabIndex = 21;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Blue;
            textBox9.Enabled = false;
            textBox9.Location = new Point(6, 141);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(167, 1);
            textBox9.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Blue;
            textBox6.Enabled = false;
            textBox6.Location = new Point(191, 134);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(240, 1);
            textBox6.TabIndex = 18;
            // 
            // txtconcepto
            // 
            txtconcepto.BackColor = Color.FromArgb(64, 64, 64);
            txtconcepto.BorderStyle = BorderStyle.None;
            txtconcepto.Location = new Point(191, 47);
            txtconcepto.Multiline = true;
            txtconcepto.Name = "txtconcepto";
            txtconcepto.Size = new Size(240, 84);
            txtconcepto.TabIndex = 17;
            txtconcepto.KeyPress += txtconcepto_KeyPress;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Blue;
            textBox4.Enabled = false;
            textBox4.Location = new Point(39, 73);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 1);
            textBox4.TabIndex = 16;
            // 
            // txtidcliente
            // 
            txtidcliente.BackColor = Color.FromArgb(64, 64, 64);
            txtidcliente.BorderStyle = BorderStyle.None;
            txtidcliente.Location = new Point(39, 50);
            txtidcliente.Multiline = true;
            txtidcliente.Name = "txtidcliente";
            txtidcliente.Size = new Size(100, 20);
            txtidcliente.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 91);
            label5.Name = "label5";
            label5.Size = new Size(159, 19);
            label5.TabIndex = 9;
            label5.Text = "NOMBRE DE CLIENTE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 25);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 7;
            label4.Text = "CONCEPTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 28);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 5;
            label3.Text = "ID CLIENTE";
            // 
            // FrmCuentasCobrar
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
            Name = "FrmCuentasCobrar";
            Text = "FrmCuentasCobrar";
            Load += FrmCuentasCobrar_Load;
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
        private TextBox textBox9;
        private TextBox textBox6;
        private TextBox txtconcepto;
        private TextBox textBox4;
        private TextBox txtidcliente;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker DTPfVencimiento;
        private Label label2;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox1;
        private TextBox txtmontofacturado;
        private Label label6;
        private TextBox textBox3;
        private TextBox txtmontopendiente;
        private Label label8;
        private ComboBox CBCLIENTE;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn DIRECCION;
        private DataGridViewTextBoxColumn INFO;
        private DataGridViewTextBoxColumn SALDO_AC;
        private DataGridViewTextBoxColumn CCONCEPTO;
        private DataGridViewTextBoxColumn CMONTO;
        private DataGridViewTextBoxColumn CLMP;
        private DataGridViewTextBoxColumn CESTADO;
        private ComboBox CMBestadopago;
    }
}