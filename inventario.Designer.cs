namespace INICIO
{
    partial class inventario
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
            Button1 = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btncancelar = new Button();
            btnlimpiar = new Button();
            cmbunidad = new ComboBox();
            txtidpro = new TextBox();
            txtestado = new TextBox();
            label7 = new Label();
            txtidinventario = new TextBox();
            txtcantidad = new TextBox();
            label6 = new Label();
            dtpfecha = new DateTimePicker();
            txtnombrepro = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnnuevo = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(79, 342);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 8;
            Button1.Text = "Guardar";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CornflowerBlue;
            label3.Location = new Point(33, 211);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 7;
            label3.Text = "Fecha Ingreso";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(btnnuevo);
            groupBox1.Controls.Add(btncancelar);
            groupBox1.Controls.Add(btnlimpiar);
            groupBox1.Controls.Add(cmbunidad);
            groupBox1.Controls.Add(txtidpro);
            groupBox1.Controls.Add(txtestado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtidinventario);
            groupBox1.Controls.Add(txtcantidad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpfecha);
            groupBox1.Controls.Add(txtnombrepro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(303, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 402);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventario";
            // 
            // btncancelar
            // 
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Location = new Point(280, 342);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 19;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.FlatAppearance.BorderSize = 0;
            btnlimpiar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Location = new Point(184, 342);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 18;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // cmbunidad
            // 
            cmbunidad.FormattingEnabled = true;
            cmbunidad.Location = new Point(172, 170);
            cmbunidad.Margin = new Padding(3, 2, 3, 2);
            cmbunidad.Name = "cmbunidad";
            cmbunidad.Size = new Size(137, 25);
            cmbunidad.TabIndex = 17;
            // 
            // txtidpro
            // 
            txtidpro.Location = new Point(172, 299);
            txtidpro.Margin = new Padding(3, 2, 3, 2);
            txtidpro.Name = "txtidpro";
            txtidpro.Size = new Size(137, 25);
            txtidpro.TabIndex = 16;
            // 
            // txtestado
            // 
            txtestado.Location = new Point(172, 253);
            txtestado.Margin = new Padding(3, 2, 3, 2);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(136, 25);
            txtestado.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 46);
            label7.Name = "label7";
            label7.Size = new Size(97, 17);
            label7.TabIndex = 14;
            label7.Text = "ID INVENTARIO";
            // 
            // txtidinventario
            // 
            txtidinventario.Location = new Point(172, 46);
            txtidinventario.Margin = new Padding(3, 2, 3, 2);
            txtidinventario.Name = "txtidinventario";
            txtidinventario.Size = new Size(136, 25);
            txtidinventario.TabIndex = 13;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(172, 127);
            txtcantidad.Margin = new Padding(3, 2, 3, 2);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(137, 25);
            txtcantidad.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 127);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 11;
            label6.Text = "Cantidad";
            // 
            // dtpfecha
            // 
            dtpfecha.Format = DateTimePickerFormat.Short;
            dtpfecha.Location = new Point(172, 211);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(239, 25);
            dtpfecha.TabIndex = 9;
            // 
            // txtnombrepro
            // 
            txtnombrepro.Location = new Point(172, 86);
            txtnombrepro.Name = "txtnombrepro";
            txtnombrepro.Size = new Size(136, 25);
            txtnombrepro.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 299);
            label5.Name = "label5";
            label5.Size = new Size(96, 17);
            label5.TabIndex = 4;
            label5.Text = "ID PROVEEDOR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 253);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 170);
            label2.Name = "label2";
            label2.Size = new Size(110, 17);
            label2.TabIndex = 1;
            label2.Text = "Unidad de medida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 86);
            label1.Name = "label1";
            label1.Size = new Size(108, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre Producto";
            // 
            // btnnuevo
            // 
            btnnuevo.FlatAppearance.BorderSize = 0;
            btnnuevo.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnnuevo.FlatStyle = FlatStyle.Flat;
            btnnuevo.Location = new Point(6, 342);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(75, 23);
            btnnuevo.TabIndex = 20;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(924, 541);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inventario";
            Text = "inventario";
            Load += inventario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal Button Button1;
        private Label label3;
        private GroupBox groupBox1;
        private DateTimePicker dtpfecha;
        private TextBox txtnombrepro;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox txtidinventario;
        private TextBox txtcantidad;
        private Label label6;
        private TextBox txtidpro;
        private TextBox txtestado;
        private ComboBox cmbunidad;
        internal Button btncancelar;
        internal Button btnlimpiar;
        internal Button btnnuevo;
    }
}