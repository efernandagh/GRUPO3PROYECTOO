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
            label5 = new Label();
            btnpdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvinventario).BeginInit();
            SuspendLayout();
            // 
            // cmbbuscar
            // 
            cmbbuscar.FormattingEnabled = true;
            cmbbuscar.Location = new Point(421, 93);
            cmbbuscar.Name = "cmbbuscar";
            cmbbuscar.Size = new Size(151, 28);
            cmbbuscar.TabIndex = 0;
            cmbbuscar.SelectedIndexChanged += cmbbuscar_SelectedIndexChanged;
            // 
            // dgvinventario
            // 
            dgvinventario.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvinventario.BorderStyle = BorderStyle.None;
            dgvinventario.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvinventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinventario.Location = new Point(173, 164);
            dgvinventario.Name = "dgvinventario";
            dgvinventario.RowHeadersWidth = 51;
            dgvinventario.Size = new Size(654, 335);
            dgvinventario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(344, 99);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 4;
            label2.Text = "Buscar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(631, 99);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 5;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(403, 19);
            label4.Name = "label4";
            label4.Size = new Size(200, 23);
            label4.TabIndex = 6;
            label4.Text = "CONSULTA INVENTARIO";
            // 
            // btnsalir
            // 
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(421, 638);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(94, 29);
            btnsalir.TabIndex = 10;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // cmbtabla
            // 
            cmbtabla.FormattingEnabled = true;
            cmbtabla.Location = new Point(150, 93);
            cmbtabla.Name = "cmbtabla";
            cmbtabla.Size = new Size(151, 28);
            cmbtabla.TabIndex = 11;
            cmbtabla.SelectedIndexChanged += cmbtabla_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, 93);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 12;
            label1.Text = "Tabla";
            // 
            // cmbdescripcion
            // 
            cmbdescripcion.FormattingEnabled = true;
            cmbdescripcion.Location = new Point(730, 99);
            cmbdescripcion.Name = "cmbdescripcion";
            cmbdescripcion.Size = new Size(151, 28);
            cmbdescripcion.TabIndex = 13;
            cmbdescripcion.SelectedIndexChanged += cmbdescripcion_SelectedIndexChanged;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(344, 555);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 29);
            btnExportar.TabIndex = 14;
            btnExportar.Text = "Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(436, 523);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 15;
            label5.Text = "EXPORTAR";
            // 
            // btnpdf
            // 
            btnpdf.Location = new Point(500, 555);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(94, 29);
            btnpdf.TabIndex = 16;
            btnpdf.Text = "PDF";
            btnpdf.UseVisualStyleBackColor = true;
            btnpdf.Click += btnpdf_Click;
            // 
            // ConsultaInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1014, 700);
            Controls.Add(btnpdf);
            Controls.Add(label5);
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
        private Label label5;
        private Button btnpdf;
    }
}