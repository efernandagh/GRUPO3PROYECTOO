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
            ((System.ComponentModel.ISupportInitialize)dgvservicio).BeginInit();
            SuspendLayout();
            // 
            // dgvservicio
            // 
            dgvservicio.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvservicio.BorderStyle = BorderStyle.None;
            dgvservicio.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvservicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvservicio.Location = new Point(187, 143);
            dgvservicio.Name = "dgvservicio";
            dgvservicio.RowHeadersWidth = 51;
            dgvservicio.Size = new Size(600, 319);
            dgvservicio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(353, 72);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "Buscar";
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            Descripcion.ForeColor = Color.White;
            Descripcion.Location = new Point(634, 72);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(93, 23);
            Descripcion.TabIndex = 2;
            Descripcion.Text = "Descripcion";
            // 
            // cbmbuscar
            // 
            cbmbuscar.FormattingEnabled = true;
            cbmbuscar.Location = new Point(428, 74);
            cbmbuscar.Name = "cbmbuscar";
            cbmbuscar.Size = new Size(185, 28);
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
            btnsalir.Location = new Point(428, 480);
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
            cmbtabla.Location = new Point(121, 72);
            cmbtabla.Name = "cmbtabla";
            cmbtabla.Size = new Size(185, 28);
            cmbtabla.TabIndex = 11;
            cmbtabla.SelectedIndexChanged += cmbbuscar_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 12;
            label2.Text = "Tabla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(373, 18);
            label3.Name = "label3";
            label3.Size = new Size(206, 28);
            label3.TabIndex = 13;
            label3.Text = "Consulta de Servicios";
            label3.Click += label3_Click;
            // 
            // cmbdescripcion
            // 
            cmbdescripcion.FormattingEnabled = true;
            cmbdescripcion.Location = new Point(733, 70);
            cmbdescripcion.Name = "cmbdescripcion";
            cmbdescripcion.Size = new Size(151, 28);
            cmbdescripcion.TabIndex = 14;
            // 
            // ConsultaServicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(970, 545);
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
    }
}