namespace INICIO
{
    partial class facturas
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
            panel1 = new Panel();
            cboidcontrato = new ComboBox();
            txtidfactura = new TextBox();
            label6 = new Label();
            btnGuardar = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            cmbMetodoPago = new ComboBox();
            pictureBox1 = new PictureBox();
            dtpFecha = new DateTimePicker();
            txtMontoTotal = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(cboidcontrato);
            panel1.Controls.Add(txtidfactura);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(cmbMetodoPago);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(txtMontoTotal);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(410, 116);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 341);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // cboidcontrato
            // 
            cboidcontrato.FormattingEnabled = true;
            cboidcontrato.Location = new Point(226, 85);
            cboidcontrato.Name = "cboidcontrato";
            cboidcontrato.Size = new Size(121, 23);
            cboidcontrato.TabIndex = 18;
            cboidcontrato.SelectedIndexChanged += cboidcontrato_SelectedIndexChanged;
            // 
            // txtidfactura
            // 
            txtidfactura.Location = new Point(226, 41);
            txtidfactura.Margin = new Padding(3, 2, 3, 2);
            txtidfactura.Name = "txtidfactura";
            txtidfactura.Size = new Size(124, 23);
            txtidfactura.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(50, 39);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 16;
            label6.Text = "ID FACTURA:";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(408, 280);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(408, 233);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(408, 191);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "EFECTIVO", "TARJETA DEBITO", "TARJETA CREDITO", "TRANSFERENCIA", "CHEQUES" });
            cmbMetodoPago.Location = new Point(229, 247);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(121, 23);
            cmbMetodoPago.TabIndex = 10;
            cmbMetodoPago.SelectedIndexChanged += cmbMetodoPago_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FACTURAS;
            pictureBox1.Location = new Point(420, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(230, 129);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(120, 23);
            dtpFecha.TabIndex = 8;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(226, 195);
            txtMontoTotal.Margin = new Padding(3, 2, 3, 2);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(124, 23);
            txtMontoTotal.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(50, 258);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 4;
            label5.Text = "METODO DE PAGO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 193);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 3;
            label4.Text = "MONTO TOTAL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 129);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 2;
            label3.Text = "FECHA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 83);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 1;
            label2.Text = "ID CONTRATO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(207, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "FACTURA";
            label1.Click += label1_Click;
            // 
            // facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1098, 546);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "facturas";
            Text = "facturas";
            Load += facturas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpFecha;
        private TextBox txtMontoTotal;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cmbMetodoPago;
        private Button btnGuardar;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtidfactura;
        private Label label6;
        private ComboBox cboidcontrato;
    }
}