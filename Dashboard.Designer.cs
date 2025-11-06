namespace INICIO
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelEncabezado = new Panel();
            btnminimizar = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            btnvolver = new Button();
            lblHora = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTitulotaller = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            panelProyectos = new Panel();
            label3 = new Label();
            lblProyectos = new Label();
            pictureBox2 = new PictureBox();
            panelContratos = new Panel();
            btncontratos = new Button();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panelClientes = new Panel();
            btnclientes = new Button();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            panelFacturas = new Panel();
            label6 = new Label();
            lblFacturas = new Label();
            pictureBox5 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grafica).BeginInit();
            SuspendLayout();
            // 
            // panelEncabezado
            // 
            panelEncabezado.BackColor = Color.SteelBlue;
            panelEncabezado.Controls.Add(btnminimizar);
            panelEncabezado.Controls.Add(button4);
            panelEncabezado.Controls.Add(pictureBox1);
            panelEncabezado.Controls.Add(btnvolver);
            panelEncabezado.Controls.Add(lblHora);
            panelEncabezado.Controls.Add(label2);
            panelEncabezado.Controls.Add(label1);
            panelEncabezado.Controls.Add(lblTitulotaller);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1213, 81);
            panelEncabezado.TabIndex = 0;
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
            btnminimizar.Location = new Point(1146, 9);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(26, 25);
            btnminimizar.TabIndex = 25;
            btnminimizar.Text = "\r\n";
            btnminimizar.UseVisualStyleBackColor = false;
            btnminimizar.Click += btnminimizar_Click;
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
            button4.Location = new Point(1178, 9);
            button4.Name = "button4";
            button4.Size = new Size(26, 25);
            button4.TabIndex = 24;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cmisur_logo;
            pictureBox1.Location = new Point(19, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnvolver
            // 
            btnvolver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnvolver.BackColor = Color.SteelBlue;
            btnvolver.BackgroundImage = (Image)resources.GetObject("btnvolver.BackgroundImage");
            btnvolver.FlatAppearance.BorderSize = 0;
            btnvolver.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnvolver.FlatStyle = FlatStyle.Flat;
            btnvolver.Location = new Point(1116, 7);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(26, 25);
            btnvolver.TabIndex = 23;
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnvolver_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(933, 42);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(94, 25);
            lblHora.TabIndex = 3;
            lblHora.Text = "\"00:00:00\"";
            lblHora.Click += lblHora_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(933, 19);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "PANEL PRINCIPAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 1;
            label1.Text = "C-MISUR";
            // 
            // lblTitulotaller
            // 
            lblTitulotaller.AutoSize = true;
            lblTitulotaller.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulotaller.ForeColor = Color.White;
            lblTitulotaller.Location = new Point(75, 9);
            lblTitulotaller.Name = "lblTitulotaller";
            lblTitulotaller.Size = new Size(284, 25);
            lblTitulotaller.TabIndex = 0;
            lblTitulotaller.Text = "TALLER MECANICO INDUSTRIAL ";
            // 
            // panelProyectos
            // 
            panelProyectos.BackColor = Color.FromArgb(192, 192, 255);
            panelProyectos.Controls.Add(label3);
            panelProyectos.Controls.Add(lblProyectos);
            panelProyectos.Controls.Add(pictureBox2);
            panelProyectos.Location = new Point(240, 115);
            panelProyectos.Name = "panelProyectos";
            panelProyectos.Size = new Size(200, 100);
            panelProyectos.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 60);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 2;
            label3.Text = "5";
            // 
            // lblProyectos
            // 
            lblProyectos.AutoSize = true;
            lblProyectos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProyectos.Location = new Point(96, 37);
            lblProyectos.Name = "lblProyectos";
            lblProyectos.Size = new Size(82, 17);
            lblProyectos.TabIndex = 1;
            lblProyectos.Text = "PROYECTOS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.INVENTARIO;
            pictureBox2.Location = new Point(3, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelContratos
            // 
            panelContratos.BackColor = Color.FromArgb(192, 255, 192);
            panelContratos.Controls.Add(btncontratos);
            panelContratos.Controls.Add(label4);
            panelContratos.Controls.Add(pictureBox3);
            panelContratos.Location = new Point(446, 115);
            panelContratos.Name = "panelContratos";
            panelContratos.Size = new Size(200, 100);
            panelContratos.TabIndex = 2;
            // 
            // btncontratos
            // 
            btncontratos.BackColor = Color.FromArgb(192, 255, 192);
            btncontratos.FlatAppearance.BorderSize = 0;
            btncontratos.FlatStyle = FlatStyle.Flat;
            btncontratos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncontratos.Location = new Point(96, 31);
            btncontratos.Name = "btncontratos";
            btncontratos.Size = new Size(86, 23);
            btncontratos.TabIndex = 5;
            btncontratos.Text = "CONTRATOS";
            btncontratos.UseVisualStyleBackColor = false;
            btncontratos.Click += btncontratos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(128, 60);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 2;
            label4.Text = "5";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CONTRATO;
            pictureBox3.Location = new Point(13, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panelClientes
            // 
            panelClientes.BackColor = Color.FromArgb(255, 255, 128);
            panelClientes.Controls.Add(btnclientes);
            panelClientes.Controls.Add(label5);
            panelClientes.Controls.Add(pictureBox4);
            panelClientes.Location = new Point(652, 115);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(200, 100);
            panelClientes.TabIndex = 3;
            // 
            // btnclientes
            // 
            btnclientes.BackColor = Color.FromArgb(255, 255, 128);
            btnclientes.FlatAppearance.BorderSize = 0;
            btnclientes.FlatStyle = FlatStyle.Flat;
            btnclientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclientes.Location = new Point(89, 31);
            btnclientes.Name = "btnclientes";
            btnclientes.Size = new Size(86, 23);
            btnclientes.TabIndex = 6;
            btnclientes.Text = "CLIENTES";
            btnclientes.UseVisualStyleBackColor = false;
            btnclientes.Click += btnclientes_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(116, 60);
            label5.Name = "label5";
            label5.Size = new Size(23, 25);
            label5.TabIndex = 2;
            label5.Text = "5";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.CLIENTE;
            pictureBox4.Location = new Point(13, 19);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panelFacturas
            // 
            panelFacturas.BackColor = Color.FromArgb(255, 192, 128);
            panelFacturas.Controls.Add(label6);
            panelFacturas.Controls.Add(lblFacturas);
            panelFacturas.Controls.Add(pictureBox5);
            panelFacturas.Location = new Point(858, 115);
            panelFacturas.Name = "panelFacturas";
            panelFacturas.Size = new Size(200, 100);
            panelFacturas.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(96, 60);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 2;
            label6.Text = "4,750.00";
            // 
            // lblFacturas
            // 
            lblFacturas.AutoSize = true;
            lblFacturas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFacturas.Location = new Point(105, 40);
            lblFacturas.Name = "lblFacturas";
            lblFacturas.Size = new Size(72, 17);
            lblFacturas.TabIndex = 1;
            lblFacturas.Text = "FACTURAS";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.FACTURAS;
            pictureBox5.Location = new Point(13, 19);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(77, 65);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // grafica
            // 
            chartArea1.Name = "ChartArea1";
            grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            grafica.Legends.Add(legend1);
            grafica.Location = new Point(215, 251);
            grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            grafica.Series.Add(series1);
            grafica.Size = new Size(507, 300);
            grafica.TabIndex = 5;
            grafica.Text = "chart1";
            grafica.Click += grafica_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1213, 591);
            Controls.Add(grafica);
            Controls.Add(panelFacturas);
            Controls.Add(panelClientes);
            Controls.Add(panelContratos);
            Controls.Add(panelProyectos);
            Controls.Add(panelEncabezado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load_1;
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelProyectos.ResumeLayout(false);
            panelProyectos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContratos.ResumeLayout(false);
            panelContratos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelFacturas.ResumeLayout(false);
            panelFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)grafica).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEncabezado;
        private Label lblTitulotaller;
        private Label label1;
        private System.Windows.Forms.Timer timerHora;
        private Label lblHora;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panelProyectos;
        private Panel panelContratos;
        private Panel panelClientes;
        private Panel panelFacturas;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblProyectos;
        private Label lblFacturas;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btncontratos;
        private Button btnclientes;
        private Button btnminimizar;
        private Button button4;
        private Button btnvolver;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
    }
}