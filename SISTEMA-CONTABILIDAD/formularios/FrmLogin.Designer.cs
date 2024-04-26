namespace SISTEMA_CONTABILIDAD.formularios
{
    partial class FrmLogin
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
            label1 = new Label();
            txtusuario = new TextBox();
            btnentrar = new Button();
            txtcontra = new TextBox();
            label2 = new Label();
            btncancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(101, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // txtusuario
            // 
            txtusuario.BackColor = Color.FromArgb(64, 64, 64);
            txtusuario.BorderStyle = BorderStyle.None;
            txtusuario.Location = new Point(53, 35);
            txtusuario.Margin = new Padding(4, 4, 4, 4);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(167, 20);
            txtusuario.TabIndex = 1;
            // 
            // btnentrar
            // 
            btnentrar.Location = new Point(29, 140);
            btnentrar.Margin = new Padding(4, 4, 4, 4);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(75, 29);
            btnentrar.TabIndex = 2;
            btnentrar.Text = "ENTRAR";
            btnentrar.UseVisualStyleBackColor = true;
            btnentrar.Click += btnentrar_Click;
            // 
            // txtcontra
            // 
            txtcontra.BackColor = Color.FromArgb(64, 64, 64);
            txtcontra.BorderStyle = BorderStyle.None;
            txtcontra.Location = new Point(53, 95);
            txtcontra.Margin = new Padding(4, 4, 4, 4);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(167, 20);
            txtcontra.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(84, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 19);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(145, 140);
            btncancelar.Margin = new Padding(4, 4, 4, 4);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(101, 29);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(269, 182);
            Controls.Add(btncancelar);
            Controls.Add(txtcontra);
            Controls.Add(label2);
            Controls.Add(btnentrar);
            Controls.Add(txtusuario);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "FrmLogin";
            ShowIcon = false;
            Text = "INICIO DE SESION";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtusuario;
        private Button btnentrar;
        private TextBox txtcontra;
        private Label label2;
        private Button btncancelar;
    }
}