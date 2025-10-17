namespace INICIO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnguardar = new Button();
            txtnombre = new TextBox();
            txtcontra = new TextBox();
            button2 = new Button();
            barratitulo = new Panel();
            pictureBox4 = new PictureBox();
            btnrestaurar = new Button();
            btnminimizar = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(622, 16);
            label1.Name = "label1";
            label1.Size = new Size(154, 22);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            label2.Location = new Point(553, 268);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            label5.Location = new Point(529, 325);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 4;
            label5.Text = "Contraseña";
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.SteelBlue;
            btnguardar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnguardar.FlatAppearance.BorderSize = 0;
            btnguardar.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            btnguardar.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnguardar.Location = new Point(657, 401);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(124, 29);
            btnguardar.TabIndex = 5;
            btnguardar.Text = "Ingresar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += button1_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(647, 265);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(134, 23);
            txtnombre.TabIndex = 6;
            txtnombre.TextChanged += txtnombre_TextChanged;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(647, 322);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(134, 23);
            txtcontra.TabIndex = 9;
            txtcontra.UseSystemPasswordChar = true;
            txtcontra.TextChanged += txtcontra_TextChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.SteelBlue;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderColor = Color.LightSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1252, 12);
            button2.Name = "button2";
            button2.Size = new Size(27, 25);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // barratitulo
            // 
            barratitulo.BackColor = Color.SteelBlue;
            barratitulo.Controls.Add(pictureBox4);
            barratitulo.Controls.Add(btnrestaurar);
            barratitulo.Controls.Add(btnminimizar);
            barratitulo.Controls.Add(button1);
            barratitulo.Controls.Add(button2);
            barratitulo.Controls.Add(label1);
            barratitulo.Dock = DockStyle.Top;
            barratitulo.Location = new Point(0, 0);
            barratitulo.Name = "barratitulo";
            barratitulo.Size = new Size(1300, 69);
            barratitulo.TabIndex = 13;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-20, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(118, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // btnrestaurar
            // 
            btnrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnrestaurar.BackColor = Color.SteelBlue;
            btnrestaurar.BackgroundImage = (Image)resources.GetObject("btnrestaurar.BackgroundImage");
            btnrestaurar.FlatAppearance.BorderColor = Color.LightSkyBlue;
            btnrestaurar.FlatAppearance.BorderSize = 0;
            btnrestaurar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnrestaurar.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnrestaurar.FlatStyle = FlatStyle.Flat;
            btnrestaurar.Location = new Point(1215, 12);
            btnrestaurar.Name = "btnrestaurar";
            btnrestaurar.Size = new Size(22, 23);
            btnrestaurar.TabIndex = 18;
            btnrestaurar.UseVisualStyleBackColor = false;
            btnrestaurar.Visible = false;
            btnrestaurar.Click += btnrestaurar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnminimizar.BackColor = Color.SteelBlue;
            btnminimizar.BackgroundImage = (Image)resources.GetObject("btnminimizar.BackgroundImage");
            btnminimizar.FlatAppearance.BorderColor = Color.LightSkyBlue;
            btnminimizar.FlatAppearance.BorderSize = 0;
            btnminimizar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnminimizar.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnminimizar.FlatStyle = FlatStyle.Flat;
            btnminimizar.Location = new Point(1183, 13);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(26, 25);
            btnminimizar.TabIndex = 17;
            btnminimizar.Text = "\r\n";
            btnminimizar.UseVisualStyleBackColor = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.SteelBlue;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderColor = Color.LightSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1215, 12);
            button1.Name = "button1";
            button1.Size = new Size(22, 24);
            button1.TabIndex = 16;
            button1.Text = "\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(662, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 73);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 592);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 58);
            panel2.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1300, 650);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(barratitulo);
            Controls.Add(btnguardar);
            Controls.Add(txtcontra);
            Controls.Add(txtnombre);
            Controls.Add(label5);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            barratitulo.ResumeLayout(false);
            barratitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Button btnguardar;
        private TextBox txtnombre;
        private TextBox txtcontra;
        private Button button2;
        private Panel barratitulo;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnrestaurar;
        private Button btnminimizar;
        private Panel panel2;
        private PictureBox pictureBox4;
    }
}
