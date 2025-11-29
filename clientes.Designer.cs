namespace INICIO
{
    partial class clientes
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
            btncancelar = new Button();
            btnlimpiar = new Button();
            label1 = new Label();
            txtcorreo = new TextBox();
            button1 = new Button();
            dtpfecharegistro = new DateTimePicker();
            txtdireccion = new TextBox();
            txttelefono = new TextBox();
            txtIdcliente = new TextBox();
            txtnombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnayuda = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(btnayuda);
            groupBox1.Controls.Add(btncancelar);
            groupBox1.Controls.Add(btnlimpiar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtcorreo);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtpfecharegistro);
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(txttelefono);
            groupBox1.Controls.Add(txtIdcliente);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(419, 177);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(432, 508);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "seccion de clientes";
            // 
            // btncancelar
            // 
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Location = new Point(288, 385);
            btncancelar.Margin = new Padding(3, 4, 3, 4);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(86, 31);
            btncancelar.TabIndex = 14;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.FlatAppearance.BorderSize = 0;
            btnlimpiar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Location = new Point(183, 385);
            btnlimpiar.Margin = new Padding(3, 4, 3, 4);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(86, 31);
            btnlimpiar.TabIndex = 13;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 204);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 12;
            label1.Text = "Correo";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(123, 197);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(145, 29);
            txtcorreo.TabIndex = 11;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(75, 385);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpfecharegistro
            // 
            dtpfecharegistro.Format = DateTimePickerFormat.Short;
            dtpfecharegistro.Location = new Point(145, 303);
            dtpfecharegistro.Margin = new Padding(3, 4, 3, 4);
            dtpfecharegistro.Name = "dtpfecharegistro";
            dtpfecharegistro.Size = new Size(123, 29);
            dtpfecharegistro.TabIndex = 10;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(123, 252);
            txtdireccion.Margin = new Padding(3, 4, 3, 4);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(145, 29);
            txtdireccion.TabIndex = 9;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(123, 145);
            txttelefono.Margin = new Padding(3, 4, 3, 4);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(145, 29);
            txttelefono.TabIndex = 8;
            // 
            // txtIdcliente
            // 
            txtIdcliente.Location = new Point(123, 55);
            txtIdcliente.Margin = new Padding(3, 4, 3, 4);
            txtIdcliente.Name = "txtIdcliente";
            txtIdcliente.Size = new Size(145, 29);
            txtIdcliente.TabIndex = 7;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(123, 104);
            txtnombre.Margin = new Padding(3, 4, 3, 4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(145, 29);
            txtnombre.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 311);
            label6.Name = "label6";
            label6.Size = new Size(133, 23);
            label6.TabIndex = 5;
            label6.Text = "Fecha de registro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 252);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 4;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 156);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 3;
            label4.Text = "telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 55);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 1;
            label2.Text = "ID CLIENTE";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 104);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 0;
            label3.Text = "Nombre";
            // 
            // btnayuda
            // 
            btnayuda.Location = new Point(328, 467);
            btnayuda.Name = "btnayuda";
            btnayuda.Size = new Size(94, 29);
            btnayuda.TabIndex = 15;
            btnayuda.Text = "Ayuda";
            btnayuda.UseVisualStyleBackColor = true;
            btnayuda.Click += btnayuda_Click;
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1027, 740);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "clientes";
            Text = "clientes";
            Load += clientes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpfecharegistro;
        private TextBox txtdireccion;
        private TextBox txttelefono;
        private TextBox txtIdcliente;
        private TextBox txtnombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtcorreo;
        private Button btncancelar;
        private Button btnlimpiar;
        private Button btnayuda;
    }
}