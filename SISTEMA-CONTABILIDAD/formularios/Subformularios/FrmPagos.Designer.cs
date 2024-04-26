namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    partial class FrmPagos
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
            GBtxts = new GroupBox();
            CBMpago = new ComboBox();
            textBox9 = new TextBox();
            textBox6 = new TextBox();
            txtmontopagado = new TextBox();
            textBox4 = new TextBox();
            txtfactura = new TextBox();
            textBox7 = new TextBox();
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
            INFO = new DataGridViewTextBoxColumn();
            SALDO_AC = new DataGridViewTextBoxColumn();
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
            toolStrip1.Size = new Size(905, 25);
            toolStrip1.TabIndex = 2;
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
            GBtxts.Controls.Add(CBMpago);
            GBtxts.Controls.Add(textBox9);
            GBtxts.Controls.Add(textBox6);
            GBtxts.Controls.Add(txtmontopagado);
            GBtxts.Controls.Add(textBox4);
            GBtxts.Controls.Add(txtfactura);
            GBtxts.Controls.Add(textBox7);
            GBtxts.Controls.Add(label5);
            GBtxts.Controls.Add(label4);
            GBtxts.Controls.Add(label3);
            GBtxts.Controls.Add(label1);
            GBtxts.Controls.Add(txtid);
            GBtxts.ForeColor = SystemColors.ButtonFace;
            GBtxts.Location = new Point(12, 28);
            GBtxts.Name = "GBtxts";
            GBtxts.Size = new Size(865, 165);
            GBtxts.TabIndex = 3;
            GBtxts.TabStop = false;
            GBtxts.Text = "INFORMACION DE PAGO";
            // 
            // CBMpago
            // 
            CBMpago.BackColor = Color.FromArgb(64, 64, 64);
            CBMpago.DropDownStyle = ComboBoxStyle.DropDownList;
            CBMpago.FlatStyle = FlatStyle.Popup;
            CBMpago.ForeColor = SystemColors.Info;
            CBMpago.FormattingEnabled = true;
            CBMpago.Items.AddRange(new object[] { "Efectivo", "Tarjeta de débito", "Tarjeta de crédito", "Transferencia bancaria", "Pago móvil", "Billeteras electrónicas (e-wallets)", "Criptomonedas", "Cheques", "adelantado", "contra entrega (COD)", "en línea", "domiciliación bancaria", "por teléfono", "tarjeta virtual", "códigos QR", "Pago a través de plataformas de comercio electrónico", "tarjeta de regalo", "mensajería instantánea", "reconocimiento facial o biométrico", "wearables", "tarjeta virtual desechable", "", "", "" });
            CBMpago.Location = new Point(509, 46);
            CBMpago.Name = "CBMpago";
            CBMpago.Size = new Size(232, 27);
            CBMpago.TabIndex = 33;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Blue;
            textBox9.Enabled = false;
            textBox9.Location = new Point(509, 76);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(232, 1);
            textBox9.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Blue;
            textBox6.Enabled = false;
            textBox6.Location = new Point(546, 147);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(178, 1);
            textBox6.TabIndex = 18;
            // 
            // txtmontopagado
            // 
            txtmontopagado.BackColor = Color.FromArgb(64, 64, 64);
            txtmontopagado.BorderStyle = BorderStyle.None;
            txtmontopagado.Location = new Point(546, 125);
            txtmontopagado.Multiline = true;
            txtmontopagado.Name = "txtmontopagado";
            txtmontopagado.Size = new Size(178, 20);
            txtmontopagado.TabIndex = 17;
            txtmontopagado.KeyPress += txtmontopagado_KeyPress;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Blue;
            textBox4.Enabled = false;
            textBox4.Location = new Point(60, 148);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 1);
            textBox4.TabIndex = 16;
            // 
            // txtfactura
            // 
            txtfactura.BackColor = Color.FromArgb(64, 64, 64);
            txtfactura.BorderStyle = BorderStyle.None;
            txtfactura.Location = new Point(60, 125);
            txtfactura.Multiline = true;
            txtfactura.Name = "txtfactura";
            txtfactura.Size = new Size(167, 20);
            txtfactura.TabIndex = 15;
            txtfactura.KeyPress += txtfactura_KeyPress;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Blue;
            textBox7.Enabled = false;
            textBox7.Location = new Point(96, 69);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(101, 1);
            textBox7.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(562, 28);
            label5.Name = "label5";
            label5.Size = new Size(126, 19);
            label5.TabIndex = 9;
            label5.Text = "METODO PAGO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(562, 103);
            label4.Name = "label4";
            label4.Size = new Size(142, 19);
            label4.TabIndex = 7;
            label4.Text = "MONTO PAGADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 103);
            label3.Name = "label3";
            label3.Size = new Size(167, 19);
            label3.TabIndex = 5;
            label3.Text = "FACTURA ASOCIADA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 24);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtid
            // 
            txtid.BackColor = Color.FromArgb(64, 64, 64);
            txtid.BorderStyle = BorderStyle.None;
            txtid.Location = new Point(96, 46);
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
            groupBox1.Location = new Point(312, 209);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 86);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "BUSCAR PAGO POR FACTURA ASOCIADA:";
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
            DGVDATOS.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, DIRECCION, INFO, SALDO_AC });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVDATOS.DefaultCellStyle = dataGridViewCellStyle2;
            DGVDATOS.Location = new Point(60, 301);
            DGVDATOS.Name = "DGVDATOS";
            DGVDATOS.ReadOnly = true;
            DGVDATOS.RowHeadersVisible = false;
            DGVDATOS.Size = new Size(756, 201);
            DGVDATOS.TabIndex = 22;
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
            NAME.HeaderText = "FECHA DE PAGO";
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            NAME.Width = 160;
            // 
            // DIRECCION
            // 
            DIRECCION.HeaderText = "FACTURA ASOCIADA";
            DIRECCION.Name = "DIRECCION";
            DIRECCION.ReadOnly = true;
            DIRECCION.Width = 195;
            // 
            // INFO
            // 
            INFO.HeaderText = "METODO DE PAGO";
            INFO.Name = "INFO";
            INFO.ReadOnly = true;
            INFO.Width = 175;
            // 
            // SALDO_AC
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SALDO_AC.DefaultCellStyle = dataGridViewCellStyle1;
            SALDO_AC.HeaderText = "MONTO PAGADO";
            SALDO_AC.Name = "SALDO_AC";
            SALDO_AC.ReadOnly = true;
            SALDO_AC.Width = 170;
            // 
            // FrmPagos
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
            Name = "FrmPagos";
            Text = "FrmPagos";
            Load += FrmPagos_Load;
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
        private TextBox textBox9;
        private TextBox textBox6;
        private TextBox txtmontopagado;
        private TextBox textBox4;
        private TextBox txtfactura;
        private TextBox textBox7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtid;
        private GroupBox groupBox1;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private TextBox textBox2;
        private DataGridView DGVDATOS;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn DIRECCION;
        private DataGridViewTextBoxColumn INFO;
        private DataGridViewTextBoxColumn SALDO_AC;
        private ComboBox CBMpago;
    }
}