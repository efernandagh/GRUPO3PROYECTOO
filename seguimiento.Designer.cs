namespace INICIO
{
    partial class seguimiento
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
            groupBox1 = new GroupBox();
            txtNivel = new TextBox();
            txtSeguimiento = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnNuevo = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            dtpFecha = new DateTimePicker();
            cbContrato = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(txtNivel);
            groupBox1.Controls.Add(txtSeguimiento);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(cbContrato);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(326, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seccion de seguimiento";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(165, 172);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(173, 26);
            txtNivel.TabIndex = 24;
            // 
            // txtSeguimiento
            // 
            txtSeguimiento.Location = new Point(165, 28);
            txtSeguimiento.Name = "txtSeguimiento";
            txtSeguimiento.Size = new Size(173, 26);
            txtSeguimiento.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 30);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 22;
            label5.Text = "ID SEGUIMIENTO";
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.CadetBlue;
            btnCancelar.Location = new Point(306, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 23);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.ForeColor = Color.CadetBlue;
            btnNuevo.Location = new Point(20, 229);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 23);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "+ NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.CadetBlue;
            btnLimpiar.Location = new Point(211, 229);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 23);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.CadetBlue;
            btnGuardar.Location = new Point(116, 229);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(165, 130);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(173, 26);
            txtDescripcion.TabIndex = 16;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(165, 90);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 26);
            dtpFecha.TabIndex = 15;
            // 
            // cbContrato
            // 
            cbContrato.FormattingEnabled = true;
            cbContrato.Location = new Point(165, 58);
            cbContrato.Name = "cbContrato";
            cbContrato.Size = new Size(164, 27);
            cbContrato.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 160);
            label4.Name = "label4";
            label4.Size = new Size(109, 38);
            label4.TabIndex = 13;
            label4.Text = "NIVEL\r\nSATISFACTORIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 132);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 12;
            label3.Text = "DESCRIPCIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 85);
            label2.Name = "label2";
            label2.Size = new Size(98, 38);
            label2.TabIndex = 11;
            label2.Text = "FECHA DE\r\nSEGUIMIENTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 62);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 10;
            label1.Text = "ID CONTRATO";
            // 
            // seguimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(892, 556);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "seguimiento";
            Text = "seguimiento";
            Load += seguimiento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGuardar;
        private TextBox txtDescripcion;
        private DateTimePicker dtpFecha;
        private ComboBox cbContrato;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnNuevo;
        private TextBox txtSeguimiento;
        private Label label5;
        private TextBox txtNivel;
    }
}