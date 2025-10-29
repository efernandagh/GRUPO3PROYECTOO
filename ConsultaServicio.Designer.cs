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
            txtdescripcion = new TextBox();
            btnlimpiar = new Button();
            btnbuscar = new Button();
            btnsalir = new Button();
            cmbtabla = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvservicio).BeginInit();
            SuspendLayout();
            // 
            // dgvservicio
            // 
            dgvservicio.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvservicio.BorderStyle = BorderStyle.None;
            dgvservicio.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvservicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvservicio.Location = new Point(410, 80);
            dgvservicio.Margin = new Padding(3, 2, 3, 2);
            dgvservicio.Name = "dgvservicio";
            dgvservicio.RowHeadersWidth = 51;
            dgvservicio.Size = new Size(358, 171);
            dgvservicio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(83, 143);
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
            Descripcion.Location = new Point(70, 193);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(72, 17);
            Descripcion.TabIndex = 2;
            Descripcion.Text = "Descripcion";
            // 
            // cbmbuscar
            // 
            cbmbuscar.FormattingEnabled = true;
            cbmbuscar.Location = new Point(145, 140);
            cbmbuscar.Margin = new Padding(3, 2, 3, 2);
            cbmbuscar.Name = "cbmbuscar";
            cbmbuscar.Size = new Size(162, 23);
            cbmbuscar.TabIndex = 6;
            cbmbuscar.SelectedIndexChanged += cbmbuscar_SelectedIndexChanged;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(145, 185);
            txtdescripcion.Margin = new Padding(3, 2, 3, 2);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(162, 23);
            txtdescripcion.TabIndex = 7;
            // 
            // btnlimpiar
            // 
            btnlimpiar.FlatAppearance.BorderSize = 0;
            btnlimpiar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.Location = new Point(40, 267);
            btnlimpiar.Margin = new Padding(3, 2, 3, 2);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(82, 22);
            btnlimpiar.TabIndex = 8;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.FlatAppearance.BorderSize = 0;
            btnbuscar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(159, 267);
            btnbuscar.Margin = new Padding(3, 2, 3, 2);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(82, 22);
            btnbuscar.TabIndex = 9;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnsalir
            // 
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(277, 267);
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
            cmbtabla.Location = new Point(144, 95);
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
            label2.Location = new Point(83, 103);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 12;
            label2.Text = "Buscar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(497, 36);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 13;
            label3.Text = "Consulta de Servicios";
            label3.Click += label3_Click;
            // 
            // ConsultaServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(849, 409);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbtabla);
            Controls.Add(btnsalir);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiar);
            Controls.Add(txtdescripcion);
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
        private TextBox txtdescripcion;
        private Button btnlimpiar;
        private Button btnbuscar;
        private Button btnsalir;
        private ComboBox cmbtabla;
        private Label label2;
        private Label label3;
    }
}