
namespace INICIO
{
    partial class proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proyecto));
            groupBox1 = new GroupBox();
            dtpfin = new DateTimePicker();
            dtpinicio = new DateTimePicker();
            cbUsuario = new ComboBox();
            button1 = new Button();
            btnCancelar = new Button();
            btnNuevo = new Button();
            btnLimpiar = new Button();
            Txtdescripcion = new TextBox();
            Txtestado = new TextBox();
            Txtnombrepro = new TextBox();
            Txtidproyecto = new TextBox();
            Label7 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            txtff = new TextBox();
            txtfi = new TextBox();
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
            groupBox1.Controls.Add(dtpfin);
            groupBox1.Controls.Add(dtpinicio);
            groupBox1.Controls.Add(cbUsuario);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(Txtdescripcion);
            groupBox1.Controls.Add(Txtestado);
            groupBox1.Controls.Add(Txtnombrepro);
            groupBox1.Controls.Add(Txtidproyecto);
            groupBox1.Controls.Add(Label7);
            groupBox1.Controls.Add(Label6);
            groupBox1.Controls.Add(Label5);
            groupBox1.Controls.Add(Label4);
            groupBox1.Controls.Add(Label3);
            groupBox1.Controls.Add(Label2);
            groupBox1.Controls.Add(Label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(259, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proyecto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpfin
            // 
            dtpfin.Format = DateTimePickerFormat.Short;
            dtpfin.Location = new Point(267, 193);
            dtpfin.Name = "dtpfin";
            dtpfin.Size = new Size(107, 23);
            dtpfin.TabIndex = 35;
            // 
            // dtpinicio
            // 
            dtpinicio.Format = DateTimePickerFormat.Short;
            dtpinicio.Location = new Point(267, 161);
            dtpinicio.Name = "dtpinicio";
            dtpinicio.Size = new Size(107, 23);
            dtpinicio.TabIndex = 4;
            // 
            // cbUsuario
            // 
            cbUsuario.FormattingEnabled = true;
            cbUsuario.Location = new Point(267, 86);
            cbUsuario.Margin = new Padding(3, 2, 3, 2);
            cbUsuario.Name = "cbUsuario";
            cbUsuario.Size = new Size(100, 23);
            cbUsuario.TabIndex = 34;
            // 
            // button1
            // 
            button1.ForeColor = Color.CadetBlue;
            button1.Location = new Point(181, 268);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 33;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.CadetBlue;
            btnCancelar.Location = new Point(372, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 23);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "SALIR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.ForeColor = Color.CadetBlue;
            btnNuevo.Location = new Point(86, 268);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 23);
            btnNuevo.TabIndex = 31;
            btnNuevo.Text = "+ NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.CadetBlue;
            btnLimpiar.Location = new Point(276, 268);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 23);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Txtdescripcion
            // 
            Txtdescripcion.BackColor = SystemColors.ActiveBorder;
            Txtdescripcion.Location = new Point(267, 120);
            Txtdescripcion.Name = "Txtdescripcion";
            Txtdescripcion.Size = new Size(100, 23);
            Txtdescripcion.TabIndex = 27;
            // 
            // Txtestado
            // 
            Txtestado.BackColor = SystemColors.ActiveBorder;
            Txtestado.Location = new Point(267, 232);
            Txtestado.Name = "Txtestado";
            Txtestado.Size = new Size(100, 23);
            Txtestado.TabIndex = 25;
            // 
            // Txtnombrepro
            // 
            Txtnombrepro.BackColor = SystemColors.ActiveBorder;
            Txtnombrepro.Location = new Point(267, 46);
            Txtnombrepro.Name = "Txtnombrepro";
            Txtnombrepro.Size = new Size(100, 23);
            Txtnombrepro.TabIndex = 24;
            // 
            // Txtidproyecto
            // 
            Txtidproyecto.BackColor = SystemColors.ActiveBorder;
            Txtidproyecto.Location = new Point(267, 14);
            Txtidproyecto.Name = "Txtidproyecto";
            Txtidproyecto.Size = new Size(100, 23);
            Txtidproyecto.TabIndex = 23;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(112, 197);
            Label7.Name = "Label7";
            Label7.Size = new Size(68, 17);
            Label7.TabIndex = 21;
            Label7.Text = "FECHA FIN";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(112, 161);
            Label6.Name = "Label6";
            Label6.Size = new Size(90, 17);
            Label6.TabIndex = 20;
            Label6.Text = "FECHA INICIO ";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(112, 122);
            Label5.Name = "Label5";
            Label5.Size = new Size(86, 17);
            Label5.TabIndex = 19;
            Label5.Text = "DESCRIPCION";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(112, 89);
            Label4.Name = "Label4";
            Label4.Size = new Size(61, 17);
            Label4.TabIndex = 18;
            Label4.Text = "USUARIO";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(111, 236);
            Label3.Name = "Label3";
            Label3.Size = new Size(54, 17);
            Label3.TabIndex = 17;
            Label3.Text = "ESTADO";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(112, 55);
            Label2.Name = "Label2";
            Label2.Size = new Size(127, 17);
            Label2.TabIndex = 16;
            Label2.Text = "NOMBRE PROYECTO";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(111, 22);
            Label1.Name = "Label1";
            Label1.Size = new Size(87, 17);
            Label1.TabIndex = 15;
            Label1.Text = "ID PROYECTO";
            // 
            // txtff
            // 
            txtff.BackColor = SystemColors.ActiveBorder;
            txtff.Location = new Point(276, 107);
            txtff.Name = "txtff";
            txtff.Size = new Size(100, 23);
            txtff.TabIndex = 29;
            // 
            // txtfi
            // 
            txtfi.BackColor = SystemColors.ActiveBorder;
            txtfi.Location = new Point(276, 145);
            txtfi.Name = "txtfi";
            txtfi.Size = new Size(100, 23);
            txtfi.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 41);
            panel1.TabIndex = 3;
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
            // proyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(965, 579);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(txtfi);
            Controls.Add(txtff);
            FormBorderStyle = FormBorderStyle.None;
            Name = "proyecto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "proyecto";
            Load += proyecto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private GroupBox groupBox1;
        internal TextBox txtfechafin;
        internal TextBox Txtfechainicio;
        internal TextBox Txtdescripcion;
        internal TextBox Txtestado;
        internal TextBox Txtnombrepro;
        internal TextBox Txtidproyecto;
        internal Label Label7;
        internal Label Label6;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        internal TextBox txtff;
        internal TextBox txtfi;
        private Button btnCancelar;
        private Button btnNuevo;
        private Button btnLimpiar;
        private Button button1;
        private ComboBox cbUsuario;
        private DateTimePicker dtpinicio;
        private DateTimePicker dtpfin;
    }
}