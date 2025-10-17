namespace INICIO
{
    partial class usuarios
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
            cmbrol = new ComboBox();
            txtidusuario = new TextBox();
            label1 = new Label();
            btncancelar = new Button();
            btneliminar = new Button();
            btnGuardar = new Button();
            txtUsuario = new Label();
            txtFecha = new Label();
            txtRol = new Label();
            txtClave = new Label();
            txtCorreo = new Label();
            txtApellido = new Label();
            txtNombre = new Label();
            dtpfecha = new DateTimePicker();
            txtnombreusuario = new TextBox();
            txtapellidousuarios = new TextBox();
            txtclaveusuario = new TextBox();
            txtcorreousuario = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(cmbrol);
            panel1.Controls.Add(txtidusuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btncancelar);
            panel1.Controls.Add(btneliminar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtFecha);
            panel1.Controls.Add(txtRol);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(dtpfecha);
            panel1.Controls.Add(txtnombreusuario);
            panel1.Controls.Add(txtapellidousuarios);
            panel1.Controls.Add(txtclaveusuario);
            panel1.Controls.Add(txtcorreousuario);
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(413, 129);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 406);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // cmbrol
            // 
            cmbrol.BackColor = SystemColors.ActiveBorder;
            cmbrol.FormattingEnabled = true;
            cmbrol.Location = new Point(161, 211);
            cmbrol.Name = "cmbrol";
            cmbrol.Size = new Size(125, 25);
            cmbrol.TabIndex = 17;
            // 
            // txtidusuario
            // 
            txtidusuario.BackColor = SystemColors.ActiveBorder;
            txtidusuario.Location = new Point(161, 33);
            txtidusuario.Margin = new Padding(3, 2, 3, 2);
            txtidusuario.Name = "txtidusuario";
            txtidusuario.Size = new Size(125, 25);
            txtidusuario.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 15;
            label1.Text = "Id usuario";
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.CornflowerBlue;
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(251, 327);
            btncancelar.Margin = new Padding(3, 2, 3, 2);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(82, 22);
            btncancelar.TabIndex = 14;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.CornflowerBlue;
            btneliminar.FlatAppearance.BorderSize = 0;
            btneliminar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(138, 327);
            btneliminar.Margin = new Padding(3, 2, 3, 2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(82, 22);
            btneliminar.TabIndex = 13;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(13, 327);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.AutoSize = true;
            txtUsuario.Location = new Point(13, 0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(55, 17);
            txtUsuario.TabIndex = 12;
            txtUsuario.Text = "Usuario";
            // 
            // txtFecha
            // 
            txtFecha.AutoSize = true;
            txtFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            txtFecha.ForeColor = Color.White;
            txtFecha.Location = new Point(28, 248);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(40, 17);
            txtFecha.TabIndex = 11;
            txtFecha.Text = "Fecha";
            // 
            // txtRol
            // 
            txtRol.AutoSize = true;
            txtRol.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            txtRol.ForeColor = Color.White;
            txtRol.Location = new Point(28, 214);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(26, 17);
            txtRol.TabIndex = 10;
            txtRol.Text = "Rol";
            // 
            // txtClave
            // 
            txtClave.AutoSize = true;
            txtClave.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            txtClave.ForeColor = Color.White;
            txtClave.Location = new Point(28, 182);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(38, 17);
            txtClave.TabIndex = 9;
            txtClave.Text = "Clave";
            // 
            // txtCorreo
            // 
            txtCorreo.AutoSize = true;
            txtCorreo.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(28, 149);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(46, 17);
            txtCorreo.TabIndex = 8;
            txtCorreo.Text = "Correo";
            // 
            // txtApellido
            // 
            txtApellido.AutoSize = true;
            txtApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(28, 111);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(52, 17);
            txtApellido.TabIndex = 7;
            txtApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(28, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(54, 17);
            txtNombre.TabIndex = 6;
            txtNombre.Text = "Nombre";
            // 
            // dtpfecha
            // 
            dtpfecha.Format = DateTimePickerFormat.Short;
            dtpfecha.Location = new Point(161, 248);
            dtpfecha.Margin = new Padding(3, 2, 3, 2);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(95, 25);
            dtpfecha.TabIndex = 5;
            // 
            // txtnombreusuario
            // 
            txtnombreusuario.BackColor = SystemColors.ActiveBorder;
            txtnombreusuario.Location = new Point(161, 67);
            txtnombreusuario.Margin = new Padding(3, 2, 3, 2);
            txtnombreusuario.Name = "txtnombreusuario";
            txtnombreusuario.Size = new Size(125, 25);
            txtnombreusuario.TabIndex = 0;
            txtnombreusuario.TextChanged += txtnombreusuario_TextChanged;
            // 
            // txtapellidousuarios
            // 
            txtapellidousuarios.BackColor = SystemColors.ActiveBorder;
            txtapellidousuarios.Location = new Point(161, 103);
            txtapellidousuarios.Margin = new Padding(3, 2, 3, 2);
            txtapellidousuarios.Name = "txtapellidousuarios";
            txtapellidousuarios.Size = new Size(125, 25);
            txtapellidousuarios.TabIndex = 3;
            // 
            // txtclaveusuario
            // 
            txtclaveusuario.BackColor = SystemColors.ActiveBorder;
            txtclaveusuario.Location = new Point(161, 174);
            txtclaveusuario.Margin = new Padding(3, 2, 3, 2);
            txtclaveusuario.Name = "txtclaveusuario";
            txtclaveusuario.Size = new Size(125, 25);
            txtclaveusuario.TabIndex = 2;
            // 
            // txtcorreousuario
            // 
            txtcorreousuario.BackColor = SystemColors.ActiveBorder;
            txtcorreousuario.Location = new Point(161, 141);
            txtcorreousuario.Margin = new Padding(3, 2, 3, 2);
            txtcorreousuario.Name = "txtcorreousuario";
            txtcorreousuario.Size = new Size(125, 25);
            txtcorreousuario.TabIndex = 4;
            // 
            // usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1300, 650);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "usuarios";
            Load += usuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGuardar;
        private Label txtUsuario;
        private Label txtFecha;
        private Label txtRol;
        private Label txtClave;
        private Label txtCorreo;
        private Label txtApellido;
        private Label txtNombre;
        private DateTimePicker dtpfecha;
        private TextBox txtnombreusuario;
        private TextBox txtapellidousuarios;
        private TextBox txtclaveusuario;
        private TextBox txtcorreousuario;
        private Button btncancelar;
        private Button btneliminar;
        private Label label1;
        private TextBox txtidusuario;
        private ComboBox cmbrol;
    }
}