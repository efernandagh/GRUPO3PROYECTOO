namespace INICIO
{
    partial class ConsultaProyectos
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
            label1 = new Label();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            cbobuscar = new ComboBox();
            label7 = new Label();
            dtvproyectos = new DataGridView();
            btnsalir = new Button();
            btnlimpiar = new Button();
            label2 = new Label();
            cbotabla = new ComboBox();
            label3 = new Label();
            cbDescripcion = new ComboBox();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvproyectos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(659, 76);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 29;
            label1.Text = "Descripcion";
            // 
            // btnbuscar
            // 
            btnbuscar.FlatAppearance.BorderSize = 0;
            btnbuscar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(206, 569);
            btnbuscar.Margin = new Padding(3, 4, 3, 4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(86, 31);
            btnbuscar.TabIndex = 28;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(659, 590);
            txtbuscar.Margin = new Padding(3, 4, 3, 4);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(189, 27);
            txtbuscar.TabIndex = 27;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // cbobuscar
            // 
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(424, 74);
            cbobuscar.Margin = new Padding(3, 4, 3, 4);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(189, 28);
            cbobuscar.TabIndex = 26;
            cbobuscar.SelectedIndexChanged += cbobuscar_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(366, 76);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 25;
            label7.Text = "Buscar";
            // 
            // dtvproyectos
            // 
            dtvproyectos.BackgroundColor = Color.FromArgb(192, 192, 255);
            dtvproyectos.BorderStyle = BorderStyle.None;
            dtvproyectos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtvproyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvproyectos.Location = new Point(95, 134);
            dtvproyectos.Margin = new Padding(3, 4, 3, 4);
            dtvproyectos.Name = "dtvproyectos";
            dtvproyectos.RowHeadersWidth = 51;
            dtvproyectos.Size = new Size(843, 362);
            dtvproyectos.TabIndex = 24;
            dtvproyectos.CellContentClick += dtvproyectos_CellContentClick;
            // 
            // btnsalir
            // 
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(494, 523);
            btnsalir.Margin = new Padding(3, 4, 3, 4);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(86, 31);
            btnsalir.TabIndex = 23;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click_1;
            // 
            // btnlimpiar
            // 
            btnlimpiar.FlatAppearance.BorderSize = 0;
            btnlimpiar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.Location = new Point(114, 569);
            btnlimpiar.Margin = new Padding(3, 4, 3, 4);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(86, 31);
            btnlimpiar.TabIndex = 22;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(408, 22);
            label2.Name = "label2";
            label2.Size = new Size(219, 23);
            label2.TabIndex = 21;
            label2.Text = "CONSULTA DE PROYECTOS";
            // 
            // cbotabla
            // 
            cbotabla.FormattingEnabled = true;
            cbotabla.Location = new Point(146, 76);
            cbotabla.Margin = new Padding(3, 4, 3, 4);
            cbotabla.Name = "cbotabla";
            cbotabla.Size = new Size(189, 28);
            cbotabla.TabIndex = 31;
            cbotabla.SelectedIndexChanged += cbotabla_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(95, 78);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 30;
            label3.Text = "Tabla";
            // 
            // cbDescripcion
            // 
            cbDescripcion.FormattingEnabled = true;
            cbDescripcion.Location = new Point(749, 73);
            cbDescripcion.Name = "cbDescripcion";
            cbDescripcion.Size = new Size(189, 28);
            cbDescripcion.TabIndex = 32;
            cbDescripcion.SelectedIndexChanged += cbDescripcion_SelectedIndexChanged;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(171, 514);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 29);
            btnExportar.TabIndex = 33;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // ConsultaProyectos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1023, 570);
            Controls.Add(btnExportar);
            Controls.Add(cbDescripcion);
            Controls.Add(cbotabla);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Controls.Add(cbobuscar);
            Controls.Add(label7);
            Controls.Add(dtvproyectos);
            Controls.Add(btnsalir);
            Controls.Add(btnlimpiar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultaProyectos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaProyectos";
            Load += ConsultaProyectos_Load;
            ((System.ComponentModel.ISupportInitialize)dtvproyectos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private ComboBox cbobuscar;
        private Label label7;
        private DataGridView dtvproyectos;
        private Button btnsalir;
        private Button btnlimpiar;
        private Label label2;
        private ComboBox cbotabla;
        private Label label3;
        private ComboBox cbDescripcion;
        private Button btnExportar;
    }
}