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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seguimiento));
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
            btnayuda = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(btnayuda);
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
            groupBox1.Location = new Point(284, 149);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(465, 428);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seccion de seguimiento";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(189, 229);
            txtNivel.Margin = new Padding(3, 4, 3, 4);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(197, 30);
            txtNivel.TabIndex = 24;
            // 
            // txtSeguimiento
            // 
            txtSeguimiento.Location = new Point(189, 37);
            txtSeguimiento.Margin = new Padding(3, 4, 3, 4);
            txtSeguimiento.Name = "txtSeguimiento";
            txtSeguimiento.Size = new Size(197, 30);
            txtSeguimiento.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 40);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.TabIndex = 22;
            label5.Text = "ID SEGUIMIENTO";
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.CadetBlue;
            btnCancelar.Location = new Point(350, 305);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 31);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.ForeColor = Color.CadetBlue;
            btnNuevo.Location = new Point(23, 305);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 31);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "+ NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.CadetBlue;
            btnLimpiar.Location = new Point(241, 305);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 31);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.CadetBlue;
            btnGuardar.Location = new Point(133, 305);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 31);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(189, 173);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(197, 30);
            txtDescripcion.TabIndex = 16;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(189, 120);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(228, 30);
            dtpFecha.TabIndex = 15;
            // 
            // cbContrato
            // 
            cbContrato.FormattingEnabled = true;
            cbContrato.Location = new Point(189, 77);
            cbContrato.Margin = new Padding(3, 4, 3, 4);
            cbContrato.Name = "cbContrato";
            cbContrato.Size = new Size(187, 31);
            cbContrato.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 213);
            label4.Name = "label4";
            label4.Size = new Size(131, 46);
            label4.TabIndex = 13;
            label4.Text = "NIVEL\r\nSATISFACTORIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 176);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 12;
            label3.Text = "DESCRIPCIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(117, 46);
            label2.TabIndex = 11;
            label2.Text = "FECHA DE\r\nSEGUIMIENTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 83);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 10;
            label1.Text = "ID CONTRATO";
            // 
            // btnayuda
            // 
            btnayuda.FlatAppearance.BorderSize = 0;
            btnayuda.FlatAppearance.MouseOverBackColor = Color.Red;
            btnayuda.FlatStyle = FlatStyle.Flat;
            btnayuda.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnayuda.ForeColor = Color.White;
            btnayuda.Location = new Point(319, 362);
            btnayuda.Name = "btnayuda";
            btnayuda.Size = new Size(134, 40);
            btnayuda.TabIndex = 37;
            btnayuda.Text = "Ayuda";
            btnayuda.UseVisualStyleBackColor = true;
            btnayuda.Click += btnayuda_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 55);
            panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 61);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // seguimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1019, 741);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "seguimiento";
            Text = "seguimiento";
            Load += seguimiento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button btnayuda;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}