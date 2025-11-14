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
            btnExportarPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvproyectos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(577, 57);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
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
            btnbuscar.Location = new Point(169, 475);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 23);
            btnbuscar.TabIndex = 28;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // cbobuscar
            // 
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(371, 56);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(166, 23);
            cbobuscar.TabIndex = 26;
            cbobuscar.SelectedIndexChanged += cbobuscar_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(320, 57);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 25;
            label7.Text = "Buscar";
            // 
            // dtvproyectos
            // 
            dtvproyectos.BackgroundColor = Color.FromArgb(192, 192, 255);
            dtvproyectos.BorderStyle = BorderStyle.None;
            dtvproyectos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtvproyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvproyectos.Location = new Point(83, 100);
            dtvproyectos.Name = "dtvproyectos";
            dtvproyectos.RowHeadersWidth = 51;
            dtvproyectos.Size = new Size(738, 272);
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
            btnsalir.Location = new Point(384, 436);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
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
            btnlimpiar.Location = new Point(88, 475);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
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
            label2.Location = new Point(357, 16);
            label2.Name = "label2";
            label2.Size = new Size(168, 17);
            label2.TabIndex = 21;
            label2.Text = "CONSULTA DE PROYECTOS";
            // 
            // cbotabla
            // 
            cbotabla.FormattingEnabled = true;
            cbotabla.Location = new Point(128, 57);
            cbotabla.Name = "cbotabla";
            cbotabla.Size = new Size(166, 23);
            cbotabla.TabIndex = 31;
            cbotabla.SelectedIndexChanged += cbotabla_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(83, 58);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 30;
            label3.Text = "Tabla";
            // 
            // cbDescripcion
            // 
            cbDescripcion.FormattingEnabled = true;
            cbDescripcion.Location = new Point(655, 55);
            cbDescripcion.Margin = new Padding(3, 2, 3, 2);
            cbDescripcion.Name = "cbDescripcion";
            cbDescripcion.Size = new Size(166, 23);
            cbDescripcion.TabIndex = 32;
            cbDescripcion.SelectedIndexChanged += cbDescripcion_SelectedIndexChanged;
            // 
            // btnExportar
            // 
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(234, 386);
            btnExportar.Margin = new Padding(3, 2, 3, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(117, 30);
            btnExportar.TabIndex = 33;
            btnExportar.Text = "Exportar a Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.FlatAppearance.BorderSize = 0;
            btnExportarPDF.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnExportarPDF.ForeColor = Color.White;
            btnExportarPDF.Location = new Point(501, 386);
            btnExportarPDF.Margin = new Padding(3, 2, 3, 2);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(117, 30);
            btnExportarPDF.TabIndex = 34;
            btnExportarPDF.Text = "Exportar a PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // ConsultaProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(895, 481);
            Controls.Add(btnExportarPDF);
            Controls.Add(btnExportar);
            Controls.Add(cbDescripcion);
            Controls.Add(cbotabla);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnbuscar);
            Controls.Add(cbobuscar);
            Controls.Add(label7);
            Controls.Add(dtvproyectos);
            Controls.Add(btnsalir);
            Controls.Add(btnlimpiar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnExportarPDF;
    }
}