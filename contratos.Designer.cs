namespace INICIO
{
    partial class contratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contratos));
            groupBox1 = new GroupBox();
            cmbServicio = new ComboBox();
            cmbCliente = new ComboBox();
            txtestado = new TextBox();
            label6 = new Label();
            btnCancelar = new Button();
            btnNuevo = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            dtpfin = new DateTimePicker();
            dtpinicio = new DateTimePicker();
            txtIdContrato = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnayuda = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(btnayuda);
            groupBox1.Controls.Add(cmbServicio);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(txtestado);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(dtpfin);
            groupBox1.Controls.Add(dtpinicio);
            groupBox1.Controls.Add(txtIdContrato);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(272, 158);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(543, 474);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contratos";
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(221, 129);
            cmbServicio.Margin = new Padding(3, 4, 3, 4);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(138, 29);
            cmbServicio.TabIndex = 34;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(221, 88);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(138, 29);
            cmbCliente.TabIndex = 33;
            // 
            // txtestado
            // 
            txtestado.Location = new Point(221, 279);
            txtestado.Margin = new Padding(3, 4, 3, 4);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(167, 29);
            txtestado.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 181);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 30;
            label6.Text = "Fecha inicio";
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.CadetBlue;
            btnCancelar.Location = new Point(379, 353);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 31);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.ForeColor = Color.CadetBlue;
            btnNuevo.Location = new Point(53, 353);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 31);
            btnNuevo.TabIndex = 28;
            btnNuevo.Text = "+ NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.CadetBlue;
            btnLimpiar.Location = new Point(270, 353);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 31);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.CadetBlue;
            btnGuardar.Location = new Point(162, 353);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 31);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtpfin
            // 
            dtpfin.Format = DateTimePickerFormat.Short;
            dtpfin.Location = new Point(221, 227);
            dtpfin.Margin = new Padding(3, 4, 3, 4);
            dtpfin.Name = "dtpfin";
            dtpfin.Size = new Size(228, 29);
            dtpfin.TabIndex = 19;
            // 
            // dtpinicio
            // 
            dtpinicio.Format = DateTimePickerFormat.Short;
            dtpinicio.Location = new Point(221, 171);
            dtpinicio.Margin = new Padding(3, 4, 3, 4);
            dtpinicio.Name = "dtpinicio";
            dtpinicio.Size = new Size(228, 29);
            dtpinicio.TabIndex = 18;
            // 
            // txtIdContrato
            // 
            txtIdContrato.Location = new Point(221, 40);
            txtIdContrato.Margin = new Padding(3, 4, 3, 4);
            txtIdContrato.Name = "txtIdContrato";
            txtIdContrato.Size = new Size(167, 29);
            txtIdContrato.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 283);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 15;
            label5.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 235);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 14;
            label4.Text = "FECHA FIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 141);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 13;
            label3.Text = "Id servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 83);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 12;
            label2.Text = "Id cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 40);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 11;
            label1.Text = "Id contrato";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 55);
            panel1.TabIndex = 22;
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
            // btnayuda
            // 
            btnayuda.FlatAppearance.BorderSize = 0;
            btnayuda.FlatAppearance.MouseOverBackColor = Color.Red;
            btnayuda.FlatStyle = FlatStyle.Flat;
            btnayuda.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnayuda.ForeColor = Color.White;
            btnayuda.Location = new Point(379, 415);
            btnayuda.Name = "btnayuda";
            btnayuda.Size = new Size(134, 40);
            btnayuda.TabIndex = 37;
            btnayuda.Text = "Ayuda";
            btnayuda.UseVisualStyleBackColor = true;
            btnayuda.Click += btnayuda_Click;
            // 
            // contratos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1005, 684);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "contratos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contratos";
            Load += contratos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpfin;
        private DateTimePicker dtpinicio;
        private TextBox txtIdContrato;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnNuevo;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox txtestado;
        private Label label6;
        private ComboBox cmbCliente;
        private ComboBox cmbServicio;
        private Button btnayuda;
    }
}