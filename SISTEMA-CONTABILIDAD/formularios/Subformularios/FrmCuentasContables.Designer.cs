namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    partial class FrmCuentasContables
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
            cmbtipocuenta = new ComboBox();
            cmbmoneda = new ComboBox();
            textBox13 = new TextBox();
            textBox10 = new TextBox();
            textBox8 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox11 = new TextBox();
            txtdescripcion = new TextBox();
            textBox9 = new TextBox();
            textBox6 = new TextBox();
            txtsaldoactual = new TextBox();
            textBox2 = new TextBox();
            txtnombrecuenta = new TextBox();
            textBox7 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtid = new TextBox();
            DGVDATOS = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            DIRECCION = new DataGridViewTextBoxColumn();
            INFO = new DataGridViewTextBoxColumn();
            SALDO_AC = new DataGridViewTextBoxColumn();
            FEC = new DataGridViewTextBoxColumn();
            SALDO_PEN = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            textBox4 = new TextBox();
            toolStrip1.SuspendLayout();
            GBtxts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDATOS).BeginInit();
            groupBox1.SuspendLayout();
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
            GBtxts.Controls.Add(cmbtipocuenta);
            GBtxts.Controls.Add(cmbmoneda);
            GBtxts.Controls.Add(textBox13);
            GBtxts.Controls.Add(textBox10);
            GBtxts.Controls.Add(textBox8);
            GBtxts.Controls.Add(textBox5);
            GBtxts.Controls.Add(textBox3);
            GBtxts.Controls.Add(textBox1);
            GBtxts.Controls.Add(textBox11);
            GBtxts.Controls.Add(txtdescripcion);
            GBtxts.Controls.Add(textBox9);
            GBtxts.Controls.Add(textBox6);
            GBtxts.Controls.Add(txtsaldoactual);
            GBtxts.Controls.Add(textBox2);
            GBtxts.Controls.Add(txtnombrecuenta);
            GBtxts.Controls.Add(textBox7);
            GBtxts.Controls.Add(label6);
            GBtxts.Controls.Add(label5);
            GBtxts.Controls.Add(label4);
            GBtxts.Controls.Add(label3);
            GBtxts.Controls.Add(label2);
            GBtxts.Controls.Add(label1);
            GBtxts.Controls.Add(txtid);
            GBtxts.ForeColor = SystemColors.ButtonFace;
            GBtxts.Location = new Point(6, 35);
            GBtxts.Margin = new Padding(4);
            GBtxts.Name = "GBtxts";
            GBtxts.Padding = new Padding(4);
            GBtxts.Size = new Size(860, 143);
            GBtxts.TabIndex = 2;
            GBtxts.TabStop = false;
            GBtxts.Text = "INFORMACION DE CUENTA:";
            // 
            // cmbtipocuenta
            // 
            cmbtipocuenta.BackColor = Color.FromArgb(64, 64, 64);
            cmbtipocuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtipocuenta.FlatStyle = FlatStyle.Flat;
            cmbtipocuenta.ForeColor = SystemColors.InactiveCaptionText;
            cmbtipocuenta.FormattingEnabled = true;
            cmbtipocuenta.Items.AddRange(new object[] { "Cuenta corriente", "Cuenta de ahorros", "Cuenta de inversión", "Cuenta de cheques", "Cuenta de jubilación ", "Cuenta bancaria en línea", "Cuenta comercial", "Cuenta de usuario", "Cuenta de usuario premium", "Cuenta de usuario gratuita", "Cuenta de usuario verificada", "Cuenta de usuario suspendida", "Cuenta de usuario administrador", "Cuenta de usuario invitado", "Cuenta de usuario básica", "Cuenta de usuario de pago", "Cuenta de usuario de prueba", "Cuenta de usuario de demostración", "Cuenta de usuario compartida", "Cuenta de usuario conjunta" });
            cmbtipocuenta.Location = new Point(171, 66);
            cmbtipocuenta.Name = "cmbtipocuenta";
            cmbtipocuenta.Size = new Size(173, 27);
            cmbtipocuenta.TabIndex = 32;
            // 
            // cmbmoneda
            // 
            cmbmoneda.BackColor = Color.FromArgb(64, 64, 64);
            cmbmoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbmoneda.FlatStyle = FlatStyle.Flat;
            cmbmoneda.ForeColor = SystemColors.InactiveCaptionText;
            cmbmoneda.FormattingEnabled = true;
            cmbmoneda.Items.AddRange(new object[] { "LEMPIRAS", "DOLARES", "EUROS" });
            cmbmoneda.Location = new Point(361, 95);
            cmbmoneda.Name = "cmbmoneda";
            cmbmoneda.Size = new Size(129, 27);
            cmbmoneda.TabIndex = 31;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.Blue;
            textBox13.Enabled = false;
            textBox13.Location = new Point(498, 129);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(354, 1);
            textBox13.TabIndex = 30;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.Blue;
            textBox10.Enabled = false;
            textBox10.Location = new Point(361, 128);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(129, 1);
            textBox10.TabIndex = 28;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Blue;
            textBox8.Enabled = false;
            textBox8.Location = new Point(361, 74);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(129, 1);
            textBox8.TabIndex = 26;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Blue;
            textBox5.Enabled = false;
            textBox5.Location = new Point(171, 96);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(173, 1);
            textBox5.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Blue;
            textBox3.Enabled = false;
            textBox3.Location = new Point(7, 129);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 1);
            textBox3.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Blue;
            textBox1.Enabled = false;
            textBox1.Location = new Point(19, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 1);
            textBox1.TabIndex = 23;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.Blue;
            textBox11.Location = new Point(924, 198);
            textBox11.Margin = new Padding(4);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(129, 0);
            textBox11.TabIndex = 22;
            // 
            // txtdescripcion
            // 
            txtdescripcion.BackColor = Color.FromArgb(64, 64, 64);
            txtdescripcion.BorderStyle = BorderStyle.None;
            txtdescripcion.Location = new Point(498, 46);
            txtdescripcion.Margin = new Padding(4);
            txtdescripcion.Multiline = true;
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(354, 80);
            txtdescripcion.TabIndex = 21;
            txtdescripcion.KeyPress += txtdescripcion_KeyPress;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Blue;
            textBox9.Location = new Point(292, 142);
            textBox9.Margin = new Padding(4);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(129, 0);
            textBox9.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Blue;
            textBox6.Location = new Point(635, 189);
            textBox6.Margin = new Padding(4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(228, 0);
            textBox6.TabIndex = 18;
            // 
            // txtsaldoactual
            // 
            txtsaldoactual.BackColor = Color.FromArgb(64, 64, 64);
            txtsaldoactual.BorderStyle = BorderStyle.None;
            txtsaldoactual.Location = new Point(361, 51);
            txtsaldoactual.Margin = new Padding(4);
            txtsaldoactual.Name = "txtsaldoactual";
            txtsaldoactual.Size = new Size(129, 20);
            txtsaldoactual.TabIndex = 17;
            txtsaldoactual.KeyPress += txtsaldoactual_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Blue;
            textBox2.Location = new Point(7, 139);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 0);
            textBox2.TabIndex = 14;
            // 
            // txtnombrecuenta
            // 
            txtnombrecuenta.BackColor = Color.FromArgb(64, 64, 64);
            txtnombrecuenta.BorderStyle = BorderStyle.None;
            txtnombrecuenta.Location = new Point(7, 106);
            txtnombrecuenta.Margin = new Padding(4);
            txtnombrecuenta.Name = "txtnombrecuenta";
            txtnombrecuenta.Size = new Size(152, 20);
            txtnombrecuenta.TabIndex = 13;
            txtnombrecuenta.KeyPress += txtnombrecuenta_KeyPress;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Blue;
            textBox7.Location = new Point(19, 110);
            textBox7.Margin = new Padding(4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(129, 0);
            textBox7.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 23);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 19);
            label6.TabIndex = 11;
            label6.Text = "DESCRIPCION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 77);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 19);
            label5.TabIndex = 9;
            label5.Text = "MONEDA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 19);
            label4.TabIndex = 7;
            label4.Text = "SALDO ACTUAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 47);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 19);
            label3.TabIndex = 5;
            label3.Text = "TIPO DE CUENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 19);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE DE CUENTA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 24);
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
            txtid.Location = new Point(19, 47);
            txtid.Margin = new Padding(4);
            txtid.Name = "txtid";
            txtid.Size = new Size(129, 20);
            txtid.TabIndex = 0;
            // 
            // DGVDATOS
            // 
            DGVDATOS.AllowUserToAddRows = false;
            DGVDATOS.AllowUserToDeleteRows = false;
            DGVDATOS.AllowUserToResizeColumns = false;
            DGVDATOS.AllowUserToResizeRows = false;
            DGVDATOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDATOS.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, DIRECCION, INFO, SALDO_AC, FEC, SALDO_PEN });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGVDATOS.DefaultCellStyle = dataGridViewCellStyle1;
            DGVDATOS.Location = new Point(46, 308);
            DGVDATOS.Name = "DGVDATOS";
            DGVDATOS.ReadOnly = true;
            DGVDATOS.RowHeadersVisible = false;
            DGVDATOS.Size = new Size(766, 201);
            DGVDATOS.TabIndex = 3;
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
            NAME.HeaderText = "NOMBRE DE CUENTA";
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            NAME.Width = 187;
            // 
            // DIRECCION
            // 
            DIRECCION.HeaderText = "TIPO DE CUENTA";
            DIRECCION.Name = "DIRECCION";
            DIRECCION.ReadOnly = true;
            // 
            // INFO
            // 
            INFO.HeaderText = "SALDO ACTUAL";
            INFO.Name = "INFO";
            INFO.ReadOnly = true;
            INFO.Width = 90;
            // 
            // SALDO_AC
            // 
            SALDO_AC.HeaderText = "MONEDA";
            SALDO_AC.Name = "SALDO_AC";
            SALDO_AC.ReadOnly = true;
            SALDO_AC.Width = 90;
            // 
            // FEC
            // 
            FEC.HeaderText = "FECHA CREACION";
            FEC.Name = "FEC";
            FEC.ReadOnly = true;
            // 
            // SALDO_PEN
            // 
            SALDO_PEN.HeaderText = "DESCRIPCION";
            SALDO_PEN.Name = "SALDO_PEN";
            SALDO_PEN.ReadOnly = true;
            SALDO_PEN.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnbuscar);
            groupBox1.Controls.Add(txtbuscar);
            groupBox1.Controls.Add(textBox4);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(298, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 86);
            groupBox1.TabIndex = 19;
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
            // textBox4
            // 
            textBox4.BackColor = Color.Blue;
            textBox4.Enabled = false;
            textBox4.Location = new Point(117, 73);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(101, 1);
            textBox4.TabIndex = 17;
            // 
            // FrmCuentasContables
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
            Name = "FrmCuentasContables";
            Text = "FrmCuentasContables";
            Load += FrmCuentasContables_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            GBtxts.ResumeLayout(false);
            GBtxts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDATOS).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox txtdescripcion;
        private TextBox textBox9;
        private TextBox textBox6;
        private TextBox txtsaldoactual;
        private TextBox textBox2;
        private TextBox txtnombrecuenta;
        private TextBox textBox7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtid;
        private TextBox textBox1;
        private TextBox textBox8;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox13;
        private TextBox textBox10;
        private DataGridView DGVDATOS;
        private GroupBox groupBox1;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private TextBox textBox4;
        private ComboBox cmbmoneda;
        private ComboBox cmbtipocuenta;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn DIRECCION;
        private DataGridViewTextBoxColumn INFO;
        private DataGridViewTextBoxColumn SALDO_AC;
        private DataGridViewTextBoxColumn FEC;
        private DataGridViewTextBoxColumn SALDO_PEN;
    }
}