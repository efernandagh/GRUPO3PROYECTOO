namespace INICIO
{
    partial class Procesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Procesos));
            groupBox1 = new GroupBox();
            cbUsuario = new ComboBox();
            btnCancelar = new Button();
            btnNuevo = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            txtdescr = new TextBox();
            txtNomb = new TextBox();
            txtIdPro = new TextBox();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
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
            groupBox1.Controls.Add(cbUsuario);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtdescr);
            groupBox1.Controls.Add(txtNomb);
            groupBox1.Controls.Add(txtIdPro);
            groupBox1.Controls.Add(Label4);
            groupBox1.Controls.Add(Label3);
            groupBox1.Controls.Add(Label2);
            groupBox1.Controls.Add(Label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(288, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 268);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesos";
            // 
            // cbUsuario
            // 
            cbUsuario.FormattingEnabled = true;
            cbUsuario.Location = new Point(233, 136);
            cbUsuario.Margin = new Padding(3, 2, 3, 2);
            cbUsuario.Name = "cbUsuario";
            cbUsuario.Size = new Size(100, 27);
            cbUsuario.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.CadetBlue;
            btnCancelar.Location = new Point(305, 213);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "SALIR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.ForeColor = Color.CadetBlue;
            btnNuevo.Location = new Point(19, 213);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 23);
            btnNuevo.TabIndex = 24;
            btnNuevo.Text = "+ NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.CadetBlue;
            btnLimpiar.Location = new Point(210, 213);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 23);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.CadetBlue;
            btnGuardar.Location = new Point(116, 213);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 23);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtdescr
            // 
            txtdescr.Location = new Point(233, 96);
            txtdescr.Name = "txtdescr";
            txtdescr.Size = new Size(100, 26);
            txtdescr.TabIndex = 15;
            // 
            // txtNomb
            // 
            txtNomb.Location = new Point(233, 59);
            txtNomb.Name = "txtNomb";
            txtNomb.Size = new Size(100, 26);
            txtNomb.TabIndex = 14;
            // 
            // txtIdPro
            // 
            txtIdPro.BackColor = SystemColors.ControlLight;
            txtIdPro.Location = new Point(233, 23);
            txtIdPro.Name = "txtIdPro";
            txtIdPro.Size = new Size(100, 26);
            txtIdPro.TabIndex = 13;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(72, 142);
            Label4.Name = "Label4";
            Label4.Size = new Size(71, 19);
            Label4.TabIndex = 12;
            Label4.Text = "USUARIO:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(72, 104);
            Label3.Name = "Label3";
            Label3.Size = new Size(97, 19);
            Label3.TabIndex = 11;
            Label3.Text = "DESCRIPCIÓN";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(72, 55);
            Label2.Name = "Label2";
            Label2.Size = new Size(96, 38);
            Label2.TabIndex = 10;
            Label2.Text = "NOMBRE DEL \r\nPROCESO";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(72, 31);
            Label1.Name = "Label1";
            Label1.Size = new Size(88, 19);
            Label1.TabIndex = 9;
            Label1.Text = "ID PROCESO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 41);
            panel1.TabIndex = 21;
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
            // Procesos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(934, 571);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Procesos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "procesos";
            Load += procesos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        internal TextBox txtdescr;
        internal TextBox txtNomb;
        internal TextBox txtIdPro;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnCancelar;
        private Button btnNuevo;
        private Button btnLimpiar;
        private Button btnGuardar;
        private ComboBox cbUsuario;
    }
}