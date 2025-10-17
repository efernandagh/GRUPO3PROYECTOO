namespace INICIO
{
    partial class frmPagos
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
            cmbidfaactura = new ComboBox();
            btnGuardar = new Button();
            cboEstado = new ComboBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            txtPago = new TextBox();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            txtMonto = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(cmbidfaactura);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtPago);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(370, 129);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 305);
            panel1.TabIndex = 1;
            // 
            // cmbidfaactura
            // 
            cmbidfaactura.FormattingEnabled = true;
            cmbidfaactura.Location = new Point(162, 146);
            cmbidfaactura.Name = "cmbidfaactura";
            cmbidfaactura.Size = new Size(121, 23);
            cmbidfaactura.TabIndex = 17;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(366, 142);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 38);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "PAGADO", "PENDIENTE", "FALLIDO", "AUTORIZADO", "REFUNDIDO" });
            cboEstado.Location = new Point(135, 260);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 23);
            cboEstado.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.CornflowerBlue;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(366, 221);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 32);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.CornflowerBlue;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(366, 185);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 32);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtPago
            // 
            txtPago.Location = new Point(167, 106);
            txtPago.Margin = new Padding(3, 2, 3, 2);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(123, 23);
            txtPago.TabIndex = 11;
            txtPago.KeyPress += txtMonto_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 136);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 10;
            label6.Text = "ID FACTURA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 104);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 9;
            label5.Text = "ID PAGO:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PAGOS;
            pictureBox1.Location = new Point(3, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, -2);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "PAGOS";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(131, 174);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(186, 23);
            dtpFecha.TabIndex = 7;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(131, 213);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(123, 23);
            txtMonto.TabIndex = 5;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 260);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 3;
            label4.Text = "ESTADO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 215);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 2;
            label3.Text = "MONTO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 176);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 1;
            label2.Text = "FECHA:";
            // 
            // frmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1041, 513);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPagos";
            Text = "pagos";
            Load += frmPagos_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DateTimePicker dtpFecha;
        private TextBox txtMonto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtPago;
        private Label label6;
        private Label label5;
        private Button btnSalir;
        private Button btnLimpiar;
        private ComboBox cboEstado;
        private Button btnGuardar;
        private ComboBox cmbidfaactura;
    }
}