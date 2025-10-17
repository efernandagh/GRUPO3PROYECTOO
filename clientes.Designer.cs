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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
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
            groupBox1.Location = new Point(367, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 340);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "seccion de clientes";
            // 
            // btncancelar
            // 
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Location = new Point(252, 289);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
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
            btnlimpiar.Location = new Point(160, 289);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 13;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 153);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 12;
            label1.Text = "Correo";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(108, 148);
            txtcorreo.Margin = new Padding(3, 2, 3, 2);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(127, 25);
            txtcorreo.TabIndex = 11;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(66, 289);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpfecharegistro
            // 
            dtpfecharegistro.Format = DateTimePickerFormat.Short;
            dtpfecharegistro.Location = new Point(127, 227);
            dtpfecharegistro.Name = "dtpfecharegistro";
            dtpfecharegistro.Size = new Size(108, 25);
            dtpfecharegistro.TabIndex = 10;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(108, 189);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(127, 25);
            txtdireccion.TabIndex = 9;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(108, 109);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(127, 25);
            txttelefono.TabIndex = 8;
            // 
            // txtIdcliente
            // 
            txtIdcliente.Location = new Point(108, 41);
            txtIdcliente.Name = "txtIdcliente";
            txtIdcliente.Size = new Size(127, 25);
            txtIdcliente.TabIndex = 7;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(108, 78);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(127, 25);
            txtnombre.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 233);
            label6.Name = "label6";
            label6.Size = new Size(103, 17);
            label6.TabIndex = 5;
            label6.Text = "Fecha de registro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 189);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 4;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 117);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 3;
            label4.Text = "telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 41);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 1;
            label2.Text = "ID CLIENTE";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 78);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 0;
            label3.Text = "Nombre";
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(899, 555);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}