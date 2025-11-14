namespace INICIO
{
    partial class ConsultaInventario
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
            cmbbuscar = new ComboBox();
            dgvinventario = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnsalir = new Button();
            cmbtabla = new ComboBox();
            label1 = new Label();
            cmbdescripcion = new ComboBox();
            btnExportar = new Button();
            btnpdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvinventario).BeginInit();
            SuspendLayout();
            // 
            // cmbbuscar
            // 
            cmbbuscar.FormattingEnabled = true;
            cmbbuscar.Location = new Point(368, 70);
            cmbbuscar.Margin = new Padding(3, 2, 3, 2);
            cmbbuscar.Name = "cmbbuscar";
            cmbbuscar.Size = new Size(133, 23);
            cmbbuscar.TabIndex = 0;
            cmbbuscar.SelectedIndexChanged += cmbbuscar_SelectedIndexChanged;
            // 
            // dgvinventario
            // 
            dgvinventario.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvinventario.BorderStyle = BorderStyle.None;
            dgvinventario.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvinventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinventario.Location = new Point(151, 123);
            dgvinventario.Margin = new Padding(3, 2, 3, 2);
            dgvinventario.Name = "dgvinventario";
            dgvinventario.RowHeadersWidth = 51;
            dgvinventario.Size = new Size(572, 251);
            dgvinventario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(301, 74);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 4;
            label2.Text = "Buscar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(552, 74);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 5;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(353, 14);
            label4.Name = "label4";
            label4.Size = new Size(155, 17);
            label4.TabIndex = 6;
            label4.Text = "CONSULTA INVENTARIO";
            // 
            // btnsalir
            // 
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(382, 451);
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
            cmbtabla.Location = new Point(131, 70);
            cmbtabla.Margin = new Padding(3, 2, 3, 2);
            cmbtabla.Name = "cmbtabla";
            cmbtabla.Size = new Size(133, 23);
            cmbtabla.TabIndex = 11;
            cmbtabla.SelectedIndexChanged += cmbtabla_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 70);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 12;
            label1.Text = "Tabla";
            // 
            // cmbdescripcion
            // 
            cmbdescripcion.FormattingEnabled = true;
            cmbdescripcion.Location = new Point(639, 74);
            cmbdescripcion.Margin = new Padding(3, 2, 3, 2);
            cmbdescripcion.Name = "cmbdescripcion";
            cmbdescripcion.Size = new Size(133, 23);
            cmbdescripcion.TabIndex = 13;
            cmbdescripcion.SelectedIndexChanged += cmbdescripcion_SelectedIndexChanged;
            // 
            // btnExportar
            // 
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(264, 401);
            btnExportar.Margin = new Padding(3, 2, 3, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(111, 22);
            btnExportar.TabIndex = 14;
            btnExportar.Text = "Exportar a Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnpdf
            // 
            btnpdf.FlatAppearance.BorderSize = 0;
            btnpdf.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnpdf.FlatStyle = FlatStyle.Flat;
            btnpdf.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnpdf.ForeColor = Color.White;
            btnpdf.Location = new Point(476, 401);
            btnpdf.Margin = new Padding(3, 2, 3, 2);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(106, 22);
            btnpdf.TabIndex = 16;
            btnpdf.Text = "Exportar a PDF";
            btnpdf.UseVisualStyleBackColor = true;
            btnpdf.Click += btnpdf_Click;
            // 
            // ConsultaInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(887, 525);
            Controls.Add(btnpdf);
            Controls.Add(btnExportar);
            Controls.Add(cmbdescripcion);
            Controls.Add(label1);
            Controls.Add(cmbtabla);
            Controls.Add(btnsalir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvinventario);
            Controls.Add(cmbbuscar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ConsultaInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaInventario";
            Load += ConsultaInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvinventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbbuscar;
        private DataGridView dgvinventario;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnsalir;
        private ComboBox cmbtabla;
        private Label label1;
        private ComboBox cmbdescripcion;
        private Button btnExportar;
        private Button btnpdf;
    }
}