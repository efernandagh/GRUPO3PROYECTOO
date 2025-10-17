namespace INICIO
{
    partial class servicios
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
            txtidservicio = new TextBox();
            txtnombreser = new ComboBox();
            btneditar = new Button();
            btneliminar = new Button();
            btnguardar = new Button();
            txtdesc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(txtidservicio);
            groupBox1.Controls.Add(txtnombreser);
            groupBox1.Controls.Add(btneditar);
            groupBox1.Controls.Add(btneliminar);
            groupBox1.Controls.Add(btnguardar);
            groupBox1.Controls.Add(txtdesc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(288, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 335);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seccion de servicios";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtidservicio
            // 
            txtidservicio.Location = new Point(187, 97);
            txtidservicio.Name = "txtidservicio";
            txtidservicio.Size = new Size(169, 25);
            txtidservicio.TabIndex = 34;
            // 
            // txtnombreser
            // 
            txtnombreser.FormattingEnabled = true;
            txtnombreser.Items.AddRange(new object[] { "Mantenimiento Industrial ", "Diseño de soluciones mecánicas personalizadas", "Reparación de maquinaria agrícola ", "Servicios técnicos especializados" });
            txtnombreser.Location = new Point(180, 145);
            txtnombreser.Margin = new Padding(3, 2, 3, 2);
            txtnombreser.Name = "txtnombreser";
            txtnombreser.Size = new Size(299, 25);
            txtnombreser.TabIndex = 33;
            txtnombreser.SelectedIndexChanged += txtnombredelservicio_SelectedIndexChanged;
            // 
            // btneditar
            // 
            btneditar.FlatAppearance.BorderSize = 0;
            btneditar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btneditar.ForeColor = Color.White;
            btneditar.Location = new Point(331, 293);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(75, 23);
            btneditar.TabIndex = 32;
            btneditar.Text = "Limpiar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btneliminar
            // 
            btneliminar.FlatAppearance.BorderSize = 0;
            btneliminar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(219, 293);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 23);
            btneliminar.TabIndex = 31;
            btneliminar.Text = "Salir";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += button2_Click;
            // 
            // btnguardar
            // 
            btnguardar.FlatAppearance.BorderSize = 0;
            btnguardar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnguardar.ForeColor = Color.White;
            btnguardar.Location = new Point(112, 293);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 30;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += button1_Click;
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(187, 205);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(169, 25);
            txtdesc.TabIndex = 28;
            txtdesc.TextChanged += txtdesc_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(68, 100);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 26;
            label4.Text = "Id servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(68, 213);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 25;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 148);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 24;
            label2.Text = "Nombre del servicio";
            // 
            // servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(903, 511);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "servicios";
            Text = "servicios";
            Load += servicios_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btneditar;
        private Button btneliminar;
        private Button btnguardar;
        private NumericUpDown txtprecio;
        private TextBox txtdesc;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox txtnombredelservicio;
        private ComboBox txtnombreser;
        private TextBox txtidservicio;
    }
}