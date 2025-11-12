namespace INICIO
{
    partial class ConsultaServicio
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
            dgvservicio = new DataGridView();
            label1 = new Label();
            Descripcion = new Label();
            cbmbuscar = new ComboBox();
            btnsalir = new Button();
            cmbtabla = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbdescripcion = new ComboBox();
            btnExportar = new Button();
            btnExportarPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvservicio).BeginInit();
            SuspendLayout();
            // 
            // dgvservicio
            // 
            dgvservicio.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvservicio.BorderStyle = BorderStyle.None;
            dgvservicio.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvservicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvservicio.Location = new Point(164, 107);
            dgvservicio.Margin = new Padding(3, 2, 3, 2);
            dgvservicio.Name = "dgvservicio";
            dgvservicio.RowHeadersWidth = 51;
            dgvservicio.Size = new Size(525, 239);
            dgvservicio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(309, 54);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 1;
            label1.Text = "Buscar";
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            Descripcion.ForeColor = Color.White;
            Descripcion.Location = new Point(555, 54);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(72, 17);
            Descripcion.TabIndex = 2;
            Descripcion.Text = "Descripcion";
            // 
            // cbmbuscar
            // 
            cbmbuscar.FormattingEnabled = true;
            cbmbuscar.Location = new Point(374, 56);
            cbmbuscar.Margin = new Padding(3, 2, 3, 2);
            cbmbuscar.Name = "cbmbuscar";
            cbmbuscar.Size = new Size(162, 23);
            cbmbuscar.TabIndex = 6;
            cbmbuscar.SelectedIndexChanged += cbmbuscar_SelectedIndexChanged;
            // 
            // btnsalir
            // 
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(374, 360);
            btnsalir.Margin = new Padding(3, 2, 3, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(82, 22);
            btnsalir.TabIndex = 10;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // cmbtabla
            // 
            cmbtabla.FormattingEnabled = true;
            cmbtabla.Location = new Point(106, 54);
            cmbtabla.Margin = new Padding(3, 2, 3, 2);
            cmbtabla.Name = "cmbtabla";
            cmbtabla.Size = new Size(162, 23);
            cmbtabla.TabIndex = 11;
            cmbtabla.SelectedIndexChanged += cmbbuscar_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 56);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 12;
            label2.Text = "Tabla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(326, 14);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 13;
            label3.Text = "Consulta de Servicios";
            label3.Click += label3_Click;
            // 
            // cmbdescripcion
            // 
            cmbdescripcion.FormattingEnabled = true;
            cmbdescripcion.Location = new Point(641, 52);
            cmbdescripcion.Margin = new Padding(3, 2, 3, 2);
            cmbdescripcion.Name = "cmbdescripcion";
            cmbdescripcion.Size = new Size(133, 23);
            cmbdescripcion.TabIndex = 14;
            cmbdescripcion.SelectedIndexChanged += cmbdescripcion_SelectedIndexChanged;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(194, 366);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Location = new Point(522, 368);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(75, 23);
            btnExportarPDF.TabIndex = 16;
            btnExportarPDF.Text = "pdf";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // ConsultaServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(849, 409);
            Controls.Add(btnExportarPDF);
            Controls.Add(btnExportar);
            Controls.Add(cmbdescripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbtabla);
            Controls.Add(btnsalir);
            Controls.Add(cbmbuscar);
            Controls.Add(Descripcion);
            Controls.Add(label1);
            Controls.Add(dgvservicio);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ConsultaServicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaServicio";
            Load += ConsultaServicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvservicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvservicio;
        private Label label1;
        private Label Descripcion;
        private ComboBox cbmbuscar;
        private Button btnsalir;
        private ComboBox cmbtabla;
        private Label label2;
        private Label label3;
        private ComboBox cmbdescripcion;
        private Button btnExportar;
        private Button btnExportarPDF;
    }
}