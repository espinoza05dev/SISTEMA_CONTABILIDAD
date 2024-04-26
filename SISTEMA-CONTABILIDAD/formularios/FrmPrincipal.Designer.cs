namespace SISTEMA_CONTABILIDAD.formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            P_PanelPrincipal = new Panel();
            P_Frm = new Panel();
            lblnombre_sistema = new Label();
            P_VistaIzquierda = new Panel();
            panel1 = new Panel();
            btncuentasporcobrar = new Button();
            btnpresupuestogasto = new Button();
            btnactivosfijos = new Button();
            btnclientes = new Button();
            btntransaccion = new Button();
            btncuentascontable = new Button();
            btnpagos = new Button();
            btnprestamo = new Button();
            P_Imagen = new Panel();
            PB_IMagen = new PictureBox();
            P_PanelPrincipal.SuspendLayout();
            P_Frm.SuspendLayout();
            P_VistaIzquierda.SuspendLayout();
            panel1.SuspendLayout();
            P_Imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_IMagen).BeginInit();
            SuspendLayout();
            // 
            // P_PanelPrincipal
            // 
            P_PanelPrincipal.Controls.Add(P_Frm);
            P_PanelPrincipal.Controls.Add(P_VistaIzquierda);
            P_PanelPrincipal.Dock = DockStyle.Fill;
            P_PanelPrincipal.Location = new Point(0, 0);
            P_PanelPrincipal.Name = "P_PanelPrincipal";
            P_PanelPrincipal.Size = new Size(1090, 615);
            P_PanelPrincipal.TabIndex = 0;
            // 
            // P_Frm
            // 
            P_Frm.BackColor = SystemColors.ActiveCaptionText;
            P_Frm.Controls.Add(lblnombre_sistema);
            P_Frm.Dock = DockStyle.Fill;
            P_Frm.ForeColor = SystemColors.ControlLight;
            P_Frm.Location = new Point(144, 0);
            P_Frm.Name = "P_Frm";
            P_Frm.Size = new Size(946, 615);
            P_Frm.TabIndex = 2;
            // 
            // lblnombre_sistema
            // 
            lblnombre_sistema.AutoSize = true;
            lblnombre_sistema.Font = new Font("Century Gothic", 45.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombre_sistema.Location = new Point(62, 190);
            lblnombre_sistema.Name = "lblnombre_sistema";
            lblnombre_sistema.Size = new Size(854, 144);
            lblnombre_sistema.TabIndex = 0;
            lblnombre_sistema.Text = "SISTEMA DE CONTABILIDAD  \r\n                    SAEG";
            // 
            // P_VistaIzquierda
            // 
            P_VistaIzquierda.BackColor = Color.Linen;
            P_VistaIzquierda.Controls.Add(panel1);
            P_VistaIzquierda.Controls.Add(P_Imagen);
            P_VistaIzquierda.Dock = DockStyle.Left;
            P_VistaIzquierda.Location = new Point(0, 0);
            P_VistaIzquierda.Name = "P_VistaIzquierda";
            P_VistaIzquierda.Size = new Size(144, 615);
            P_VistaIzquierda.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btncuentasporcobrar);
            panel1.Controls.Add(btnpresupuestogasto);
            panel1.Controls.Add(btnactivosfijos);
            panel1.Controls.Add(btnclientes);
            panel1.Controls.Add(btntransaccion);
            panel1.Controls.Add(btncuentascontable);
            panel1.Controls.Add(btnpagos);
            panel1.Controls.Add(btnprestamo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 528);
            panel1.TabIndex = 8;
            // 
            // btncuentasporcobrar
            // 
            btncuentasporcobrar.FlatAppearance.BorderSize = 0;
            btncuentasporcobrar.FlatStyle = FlatStyle.Flat;
            btncuentasporcobrar.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold);
            btncuentasporcobrar.Image = Properties.Resources.cuenta_por_cobrar;
            btncuentasporcobrar.ImageAlign = ContentAlignment.MiddleLeft;
            btncuentasporcobrar.Location = new Point(10, 475);
            btncuentasporcobrar.Name = "btncuentasporcobrar";
            btncuentasporcobrar.Size = new Size(124, 41);
            btncuentasporcobrar.TabIndex = 10;
            btncuentasporcobrar.Text = "CUENTAS POR COBRAR";
            btncuentasporcobrar.TextAlign = ContentAlignment.MiddleRight;
            btncuentasporcobrar.UseVisualStyleBackColor = true;
            btncuentasporcobrar.Click += btncuentasporcobrar_Click;
            // 
            // btnpresupuestogasto
            // 
            btnpresupuestogasto.FlatAppearance.BorderSize = 0;
            btnpresupuestogasto.FlatStyle = FlatStyle.Flat;
            btnpresupuestogasto.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold);
            btnpresupuestogasto.Image = (Image)resources.GetObject("btnpresupuestogasto.Image");
            btnpresupuestogasto.ImageAlign = ContentAlignment.MiddleLeft;
            btnpresupuestogasto.Location = new Point(10, 415);
            btnpresupuestogasto.Name = "btnpresupuestogasto";
            btnpresupuestogasto.Size = new Size(124, 41);
            btnpresupuestogasto.TabIndex = 9;
            btnpresupuestogasto.Text = "PRESUPUESTO GASTO";
            btnpresupuestogasto.TextAlign = ContentAlignment.MiddleRight;
            btnpresupuestogasto.UseVisualStyleBackColor = true;
            btnpresupuestogasto.Click += btnpresupuestogasto_Click;
            // 
            // btnactivosfijos
            // 
            btnactivosfijos.FlatAppearance.BorderSize = 0;
            btnactivosfijos.FlatStyle = FlatStyle.Flat;
            btnactivosfijos.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold);
            btnactivosfijos.Image = (Image)resources.GetObject("btnactivosfijos.Image");
            btnactivosfijos.ImageAlign = ContentAlignment.MiddleLeft;
            btnactivosfijos.Location = new Point(10, 348);
            btnactivosfijos.Name = "btnactivosfijos";
            btnactivosfijos.Size = new Size(124, 41);
            btnactivosfijos.TabIndex = 8;
            btnactivosfijos.Text = "ACTIVOS FIJOS";
            btnactivosfijos.TextAlign = ContentAlignment.MiddleRight;
            btnactivosfijos.UseVisualStyleBackColor = true;
            btnactivosfijos.Click += btnactivosfijos_Click;
            // 
            // btnclientes
            // 
            btnclientes.FlatAppearance.BorderSize = 0;
            btnclientes.FlatStyle = FlatStyle.Flat;
            btnclientes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclientes.Image = Properties.Resources.clientes;
            btnclientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnclientes.Location = new Point(10, 6);
            btnclientes.Name = "btnclientes";
            btnclientes.Size = new Size(125, 41);
            btnclientes.TabIndex = 1;
            btnclientes.Text = "CLIENTES";
            btnclientes.TextAlign = ContentAlignment.MiddleRight;
            btnclientes.UseVisualStyleBackColor = true;
            btnclientes.Click += btnclientes_Click;
            // 
            // btntransaccion
            // 
            btntransaccion.FlatAppearance.BorderSize = 0;
            btntransaccion.FlatStyle = FlatStyle.Flat;
            btntransaccion.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntransaccion.Image = Properties.Resources.transaccion;
            btntransaccion.ImageAlign = ContentAlignment.MiddleLeft;
            btntransaccion.Location = new Point(10, 276);
            btntransaccion.Name = "btntransaccion";
            btntransaccion.Size = new Size(124, 41);
            btntransaccion.TabIndex = 7;
            btntransaccion.Text = "TRANSACCION";
            btntransaccion.TextAlign = ContentAlignment.MiddleRight;
            btntransaccion.UseVisualStyleBackColor = true;
            btntransaccion.Click += btntransaccion_Click;
            // 
            // btncuentascontable
            // 
            btncuentascontable.FlatAppearance.BorderSize = 0;
            btncuentascontable.FlatStyle = FlatStyle.Flat;
            btncuentascontable.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncuentascontable.Image = Properties.Resources.cuenta_bancaria;
            btncuentascontable.ImageAlign = ContentAlignment.MiddleLeft;
            btncuentascontable.Location = new Point(10, 72);
            btncuentascontable.Name = "btncuentascontable";
            btncuentascontable.Size = new Size(124, 41);
            btncuentascontable.TabIndex = 2;
            btncuentascontable.Text = "CUENTAS CONTABLES";
            btncuentascontable.TextAlign = ContentAlignment.MiddleRight;
            btncuentascontable.UseVisualStyleBackColor = true;
            btncuentascontable.Click += btncuentascontable_Click;
            // 
            // btnpagos
            // 
            btnpagos.FlatAppearance.BorderSize = 0;
            btnpagos.FlatStyle = FlatStyle.Flat;
            btnpagos.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpagos.Image = Properties.Resources.pagos;
            btnpagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnpagos.Location = new Point(10, 135);
            btnpagos.Name = "btnpagos";
            btnpagos.Size = new Size(125, 41);
            btnpagos.TabIndex = 5;
            btnpagos.Text = "PAGOS";
            btnpagos.TextAlign = ContentAlignment.MiddleRight;
            btnpagos.UseVisualStyleBackColor = true;
            btnpagos.Click += btnpagos_Click;
            // 
            // btnprestamo
            // 
            btnprestamo.FlatAppearance.BorderSize = 0;
            btnprestamo.FlatStyle = FlatStyle.Flat;
            btnprestamo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnprestamo.Image = Properties.Resources.prestamo;
            btnprestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnprestamo.Location = new Point(10, 203);
            btnprestamo.Name = "btnprestamo";
            btnprestamo.Size = new Size(124, 41);
            btnprestamo.TabIndex = 6;
            btnprestamo.Text = "PRESTAMOS";
            btnprestamo.TextAlign = ContentAlignment.MiddleRight;
            btnprestamo.UseVisualStyleBackColor = true;
            btnprestamo.Click += btnprestamo_Click;
            // 
            // P_Imagen
            // 
            P_Imagen.BackColor = Color.DimGray;
            P_Imagen.Controls.Add(PB_IMagen);
            P_Imagen.Dock = DockStyle.Top;
            P_Imagen.Location = new Point(0, 0);
            P_Imagen.Name = "P_Imagen";
            P_Imagen.Size = new Size(144, 87);
            P_Imagen.TabIndex = 0;
            // 
            // PB_IMagen
            // 
            PB_IMagen.Image = Properties.Resources.saeg_logo;
            PB_IMagen.Location = new Point(23, 3);
            PB_IMagen.Name = "PB_IMagen";
            PB_IMagen.Size = new Size(100, 81);
            PB_IMagen.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_IMagen.TabIndex = 0;
            PB_IMagen.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 615);
            Controls.Add(P_PanelPrincipal);
            Name = "FrmPrincipal";
            ShowIcon = false;
            Text = "VENTANA PRINCIPAL USUARIO :";
            Load += FrmPrincipal_Load;
            P_PanelPrincipal.ResumeLayout(false);
            P_Frm.ResumeLayout(false);
            P_Frm.PerformLayout();
            P_VistaIzquierda.ResumeLayout(false);
            panel1.ResumeLayout(false);
            P_Imagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PB_IMagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel P_PanelPrincipal;
        private Panel P_Frm;
        private Panel P_VistaIzquierda;
        private Panel P_Imagen;
        private PictureBox PB_IMagen;
        private Button btnpagos;
        private Button btncuentascontable;
        private Button btnclientes;
        private Button btntransaccion;
        private Button btnprestamo;
        private Label lblnombre_sistema;
        private Panel panel1;
        private Button btnactivosfijos;
        private Button btncuentasporcobrar;
        private Button btnpresupuestogasto;
    }
}