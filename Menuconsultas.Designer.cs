namespace INICIO
{
    partial class Menuconsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuconsultas));
            panel1 = new Panel();
            button4 = new Button();
            btnvolver = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnfacturacion = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnpro = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnvolver);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 69);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.SteelBlue;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderColor = Color.LightSkyBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button4.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(1177, 21);
            button4.Name = "button4";
            button4.Size = new Size(27, 25);
            button4.TabIndex = 20;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnvolver
            // 
            btnvolver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnvolver.BackColor = Color.SteelBlue;
            btnvolver.BackgroundImage = (Image)resources.GetObject("btnvolver.BackgroundImage");
            btnvolver.FlatAppearance.BorderSize = 0;
            btnvolver.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnvolver.FlatStyle = FlatStyle.Flat;
            btnvolver.Location = new Point(1147, 20);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(24, 27);
            btnvolver.TabIndex = 2;
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnvolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(546, 21);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Menú de consultas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnfacturacion);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnpro);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(172, 542);
            panel2.TabIndex = 1;
            // 
            // btnfacturacion
            // 
            btnfacturacion.BackColor = Color.SteelBlue;
            btnfacturacion.FlatAppearance.BorderSize = 0;
            btnfacturacion.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnfacturacion.FlatStyle = FlatStyle.Flat;
            btnfacturacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnfacturacion.ForeColor = Color.White;
            btnfacturacion.Location = new Point(22, 268);
            btnfacturacion.Name = "btnfacturacion";
            btnfacturacion.Size = new Size(90, 23);
            btnfacturacion.TabIndex = 24;
            btnfacturacion.Text = "Facturación";
            btnfacturacion.UseVisualStyleBackColor = false;
            btnfacturacion.Click += btnfacturacion_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(22, 206);
            button3.Name = "button3";
            button3.Size = new Size(90, 23);
            button3.TabIndex = 23;
            button3.Text = "Proyectos";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(22, 149);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 22;
            button2.Text = "Inventarios";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(22, 89);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 21;
            button1.Text = "Servicios";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnpro
            // 
            btnpro.BackColor = Color.SteelBlue;
            btnpro.FlatAppearance.BorderSize = 0;
            btnpro.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnpro.FlatStyle = FlatStyle.Flat;
            btnpro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpro.ForeColor = Color.White;
            btnpro.Location = new Point(22, 28);
            btnpro.Name = "btnpro";
            btnpro.Size = new Size(90, 23);
            btnpro.TabIndex = 20;
            btnpro.Text = "Proyectos";
            btnpro.UseVisualStyleBackColor = false;
            // 
            // Menuconsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1284, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menuconsultas";
            Text = "Menuconsultas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnpro;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnfacturacion;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnvolver;
        private Button button4;
    }
}