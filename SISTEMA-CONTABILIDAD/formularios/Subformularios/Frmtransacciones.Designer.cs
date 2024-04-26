namespace SISTEMA_CONTABILIDAD.formularios.Subformularios
{
    partial class Frmtransacciones
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
            groupBox1 = new GroupBox();
            textBox16 = new TextBox();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            textBox2 = new TextBox();
            DGVDATOS = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            DIRECCION = new DataGridViewTextBoxColumn();
            INFO = new DataGridViewTextBoxColumn();
            SALDO_AC = new DataGridViewTextBoxColumn();
            CLFI = new DataGridViewTextBoxColumn();
            CLFF = new DataGridViewTextBoxColumn();
            CLPM = new DataGridViewTextBoxColumn();
            GBtxts = new GroupBox();
            rdreffactura = new CheckBox();
            CBtipotransaccion = new ComboBox();
            groupBox2 = new GroupBox();
            rdcredito = new RadioButton();
            rddebito = new RadioButton();
            textBox12 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            textBox5 = new TextBox();
            txtdescripcion = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            txtmonto = new TextBox();
            textBox4 = new TextBox();
            textBox7 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtid = new TextBox();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDATOS).BeginInit();
            GBtxts.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Gray;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnnuevo, toolStripSeparator1, btnguardar, toolStripSeparator2, btneliminar, toolStripSeparator3, btnactualizar, toolStripSeparator4, btncancelar, toolStripSeparator5, btnsalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(899, 25);
            toolStrip1.TabIndex = 4;
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
            groupBox1.Controls.Add(txtbuscar);
            groupBox1.Controls.Add(textBox2);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(324, 201);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(281, 73);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "BUSCAR TRANSACCION POR ID:";
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
            txtbuscar.KeyPress += txtbuscar_KeyPress;
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
            DGVDATOS.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, DIRECCION, INFO, SALDO_AC, CLFI, CLFF, CLPM });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DGVDATOS.DefaultCellStyle = dataGridViewCellStyle4;
            DGVDATOS.Location = new Point(79, 282);
            DGVDATOS.Margin = new Padding(4);
            DGVDATOS.Name = "DGVDATOS";
            DGVDATOS.ReadOnly = true;
            DGVDATOS.RowHeadersVisible = false;
            DGVDATOS.Size = new Size(767, 199);
            DGVDATOS.TabIndex = 28;
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
            // NAME
            // 
            NAME.HeaderText = "FECHA";
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            NAME.Width = 90;
            // 
            // DIRECCION
            // 
            DIRECCION.HeaderText = "CUENTA DEBITO";
            DIRECCION.Name = "DIRECCION";
            DIRECCION.ReadOnly = true;
            DIRECCION.Width = 80;
            // 
            // INFO
            // 
            INFO.HeaderText = "CUENTA CREDITO";
            INFO.Name = "INFO";
            INFO.ReadOnly = true;
            INFO.Width = 80;
            // 
            // SALDO_AC
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SALDO_AC.DefaultCellStyle = dataGridViewCellStyle3;
            SALDO_AC.HeaderText = "MONTO";
            SALDO_AC.Name = "SALDO_AC";
            SALDO_AC.ReadOnly = true;
            SALDO_AC.Width = 90;
            // 
            // CLFI
            // 
            CLFI.HeaderText = "DESCRIPCION";
            CLFI.Name = "CLFI";
            CLFI.ReadOnly = true;
            CLFI.Width = 120;
            // 
            // CLFF
            // 
            CLFF.HeaderText = "TIPO TRANSACCION";
            CLFF.Name = "CLFF";
            CLFF.ReadOnly = true;
            CLFF.Width = 130;
            // 
            // CLPM
            // 
            CLPM.HeaderText = "REF FACTURA";
            CLPM.Name = "CLPM";
            CLPM.ReadOnly = true;
            // 
            // GBtxts
            // 
            GBtxts.Controls.Add(rdreffactura);
            GBtxts.Controls.Add(CBtipotransaccion);
            GBtxts.Controls.Add(groupBox2);
            GBtxts.Controls.Add(textBox12);
            GBtxts.Controls.Add(label7);
            GBtxts.Controls.Add(textBox8);
            GBtxts.Controls.Add(textBox5);
            GBtxts.Controls.Add(txtdescripcion);
            GBtxts.Controls.Add(label2);
            GBtxts.Controls.Add(textBox1);
            GBtxts.Controls.Add(textBox6);
            GBtxts.Controls.Add(txtmonto);
            GBtxts.Controls.Add(textBox4);
            GBtxts.Controls.Add(textBox7);
            GBtxts.Controls.Add(label4);
            GBtxts.Controls.Add(label1);
            GBtxts.Controls.Add(txtid);
            GBtxts.ForeColor = SystemColors.ButtonFace;
            GBtxts.Location = new Point(8, 29);
            GBtxts.Margin = new Padding(4);
            GBtxts.Name = "GBtxts";
            GBtxts.Padding = new Padding(4);
            GBtxts.Size = new Size(877, 164);
            GBtxts.TabIndex = 27;
            GBtxts.TabStop = false;
            GBtxts.Text = "INFORMACION DE TRANSACCIONES:";
            // 
            // rdreffactura
            // 
            rdreffactura.AutoSize = true;
            rdreffactura.Location = new Point(671, 120);
            rdreffactura.Name = "rdreffactura";
            rdreffactura.Size = new Size(192, 23);
            rdreffactura.TabIndex = 55;
            rdreffactura.Text = "REFERENCIA FACTURA";
            rdreffactura.UseVisualStyleBackColor = true;
            // 
            // CBtipotransaccion
            // 
            CBtipotransaccion.BackColor = Color.FromArgb(64, 64, 64);
            CBtipotransaccion.DropDownStyle = ComboBoxStyle.DropDownList;
            CBtipotransaccion.FlatStyle = FlatStyle.Popup;
            CBtipotransaccion.ForeColor = Color.FromArgb(224, 224, 224);
            CBtipotransaccion.FormattingEnabled = true;
            CBtipotransaccion.Items.AddRange(new object[] { "comercial", "financiera", "efectivo", "electrónica", "locales", "internacionales", "presencial", "en línea", "compra", "intercambio", "instantánea" });
            CBtipotransaccion.Location = new Point(671, 48);
            CBtipotransaccion.Name = "CBtipotransaccion";
            CBtipotransaccion.Size = new Size(183, 27);
            CBtipotransaccion.TabIndex = 54;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdcredito);
            groupBox2.Controls.Add(rddebito);
            groupBox2.ForeColor = SystemColors.ActiveBorder;
            groupBox2.Location = new Point(11, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(194, 53);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "TIPO DE CUENTA:";
            // 
            // rdcredito
            // 
            rdcredito.AutoSize = true;
            rdcredito.Location = new Point(98, 26);
            rdcredito.Name = "rdcredito";
            rdcredito.Size = new Size(91, 23);
            rdcredito.TabIndex = 1;
            rdcredito.Text = "CREDITO";
            rdcredito.UseVisualStyleBackColor = true;
            // 
            // rddebito
            // 
            rddebito.AutoSize = true;
            rddebito.Checked = true;
            rddebito.Location = new Point(13, 26);
            rddebito.Name = "rddebito";
            rddebito.Size = new Size(79, 23);
            rddebito.TabIndex = 0;
            rddebito.TabStop = true;
            rddebito.Text = "DEBITO";
            rddebito.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.Blue;
            textBox12.Enabled = false;
            textBox12.Location = new Point(672, 78);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(182, 1);
            textBox12.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(672, 29);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(182, 19);
            label7.TabIndex = 46;
            label7.Text = "TIPO DE TRANSACCION";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Blue;
            textBox8.Enabled = false;
            textBox8.Location = new Point(406, 146);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(231, 1);
            textBox8.TabIndex = 38;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Blue;
            textBox5.Enabled = false;
            textBox5.Location = new Point(217, 101);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 1);
            textBox5.TabIndex = 35;
            // 
            // txtdescripcion
            // 
            txtdescripcion.BackColor = Color.FromArgb(64, 64, 64);
            txtdescripcion.BorderStyle = BorderStyle.None;
            txtdescripcion.Location = new Point(406, 43);
            txtdescripcion.Margin = new Padding(4);
            txtdescripcion.Multiline = true;
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(231, 100);
            txtdescripcion.TabIndex = 37;
            txtdescripcion.KeyPress += txtdescripcion_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 36;
            label2.Text = "DESCRIPCION";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Blue;
            textBox1.Enabled = false;
            textBox1.Location = new Point(44, 70);
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
            txtmonto.Location = new Point(217, 74);
            txtmonto.Margin = new Padding(4);
            txtmonto.Multiline = true;
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(176, 25);
            txtmonto.TabIndex = 17;
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
            textBox7.Location = new Point(44, 77);
            textBox7.Margin = new Padding(4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(129, 0);
            textBox7.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 52);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 7;
            label4.Text = "MONTO ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 23);
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
            txtid.Location = new Point(44, 48);
            txtid.Margin = new Padding(4);
            txtid.Name = "txtid";
            txtid.Size = new Size(129, 20);
            txtid.TabIndex = 0;
            // 
            // Frmtransacciones
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(899, 495);
            Controls.Add(groupBox1);
            Controls.Add(DGVDATOS);
            Controls.Add(GBtxts);
            Controls.Add(toolStrip1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = Color.Maroon;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Frmtransacciones";
            Text = "Frmtransacciones";
            Load += Frmtransacciones_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDATOS).EndInit();
            GBtxts.ResumeLayout(false);
            GBtxts.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private TextBox textBox16;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private TextBox textBox2;
        private DataGridView DGVDATOS;
        private GroupBox GBtxts;
        private TextBox textBox12;
        private Label label7;
        private TextBox textBox8;
        private TextBox textBox5;
        private TextBox txtdescripcion;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox txtmonto;
        private TextBox textBox4;
        private TextBox textBox7;
        private Label label4;
        private Label label1;
        private TextBox txtid;
        private GroupBox groupBox2;
        private RadioButton rdcredito;
        private RadioButton rddebito;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn DIRECCION;
        private DataGridViewTextBoxColumn INFO;
        private DataGridViewTextBoxColumn SALDO_AC;
        private DataGridViewTextBoxColumn CLFI;
        private DataGridViewTextBoxColumn CLFF;
        private DataGridViewTextBoxColumn CLPM;
        private ComboBox CBtipotransaccion;
        private CheckBox rdreffactura;
    }
}