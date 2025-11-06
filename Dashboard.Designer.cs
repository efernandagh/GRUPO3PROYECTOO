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
            panelEncabezado = new Panel();
            pictureBox1 = new PictureBox();
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
            label4 = new Label();
            lblContratos = new Label();
            pictureBox3 = new PictureBox();
            panelClientes = new Panel();
            label5 = new Label();
            lblClientes = new Label();
            pictureBox4 = new PictureBox();
            panelFacturas = new Panel();
            label6 = new Label();
            lblFacturas = new Label();
            pictureBox5 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            SuspendLayout();
            // 
            // panelEncabezado
            // 
            panelEncabezado.BackColor = Color.Blue;
            panelEncabezado.Controls.Add(pictureBox1);
            panelEncabezado.Controls.Add(lblHora);
            panelEncabezado.Controls.Add(label2);
            panelEncabezado.Controls.Add(label1);
            panelEncabezado.Controls.Add(lblTitulotaller);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(837, 81);
            panelEncabezado.TabIndex = 0;
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
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(688, 43);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(94, 25);
            lblHora.TabIndex = 3;
            lblHora.Text = "\"00:00:00\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(688, 20);
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
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
            // 
            // panelProyectos
            // 
            panelProyectos.BackColor = Color.FromArgb(192, 192, 255);
            panelProyectos.Controls.Add(label3);
            panelProyectos.Controls.Add(lblProyectos);
            panelProyectos.Controls.Add(pictureBox2);
            panelProyectos.Location = new Point(16, 96);
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
            panelContratos.Controls.Add(label4);
            panelContratos.Controls.Add(lblContratos);
            panelContratos.Controls.Add(pictureBox3);
            panelContratos.Location = new Point(222, 96);
            panelContratos.Name = "panelContratos";
            panelContratos.Size = new Size(200, 100);
            panelContratos.TabIndex = 2;
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
            // lblContratos
            // 
            lblContratos.AutoSize = true;
            lblContratos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContratos.Location = new Point(100, 38);
            lblContratos.Name = "lblContratos";
            lblContratos.Size = new Size(85, 17);
            lblContratos.TabIndex = 1;
            lblContratos.Text = "CONTRATOS";
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
            panelClientes.Controls.Add(label5);
            panelClientes.Controls.Add(lblClientes);
            panelClientes.Controls.Add(pictureBox4);
            panelClientes.Location = new Point(428, 96);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(200, 100);
            panelClientes.TabIndex = 3;
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
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientes.Location = new Point(97, 40);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(59, 15);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "CLIENTES";
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
            panelFacturas.Location = new Point(634, 96);
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
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(837, 449);
            Controls.Add(panelFacturas);
            Controls.Add(panelClientes);
            Controls.Add(panelContratos);
            Controls.Add(panelProyectos);
            Controls.Add(panelEncabezado);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
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
        private Label lblContratos;
        private Label lblClientes;
        private Label lblFacturas;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}