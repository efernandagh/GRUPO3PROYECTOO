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
            cmbCliente = new ComboBox();
            cmbServicio = new ComboBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
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
            groupBox1.Location = new Point(309, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contratos";
            // 
            // txtestado
            // 
            txtestado.Location = new Point(193, 209);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(147, 25);
            txtestado.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 136);
            label6.Name = "label6";
            label6.Size = new Size(73, 17);
            label6.TabIndex = 30;
            label6.Text = "Fecha inicio";
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.CadetBlue;
            btnCancelar.Location = new Point(332, 265);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 23);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.ForeColor = Color.CadetBlue;
            btnNuevo.Location = new Point(46, 265);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 23);
            btnNuevo.TabIndex = 28;
            btnNuevo.Text = "+ NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.CadetBlue;
            btnLimpiar.Location = new Point(236, 265);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 23);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.CadetBlue;
            btnGuardar.Location = new Point(142, 265);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 23);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtpfin
            // 
            dtpfin.Format = DateTimePickerFormat.Short;
            dtpfin.Location = new Point(193, 170);
            dtpfin.Name = "dtpfin";
            dtpfin.Size = new Size(200, 25);
            dtpfin.TabIndex = 19;
            // 
            // dtpinicio
            // 
            dtpinicio.Format = DateTimePickerFormat.Short;
            dtpinicio.Location = new Point(193, 128);
            dtpinicio.Name = "dtpinicio";
            dtpinicio.Size = new Size(200, 25);
            dtpinicio.TabIndex = 18;
            // 
            // txtIdContrato
            // 
            txtIdContrato.Location = new Point(193, 30);
            txtIdContrato.Name = "txtIdContrato";
            txtIdContrato.Size = new Size(147, 25);
            txtIdContrato.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 212);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 15;
            label5.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 176);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 14;
            label4.Text = "FECHA FIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 106);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 13;
            label3.Text = "Id servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 62);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 12;
            label2.Text = "Id cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 30);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 11;
            label1.Text = "Id contrato";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 41);
            panel1.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 46);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(193, 66);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 25);
            cmbCliente.TabIndex = 33;
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(193, 97);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(121, 25);
            cmbServicio.TabIndex = 34;
            // 
            // contratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(879, 513);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}