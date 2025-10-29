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
            ((System.ComponentModel.ISupportInitialize)dgvservicio).BeginInit();
            SuspendLayout();
            // 
            // dgvservicio
            // 
            dgvservicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvservicio.Location = new Point(561, 140);
            dgvservicio.Name = "dgvservicio";
            dgvservicio.RowHeadersWidth = 51;
            dgvservicio.Size = new Size(397, 228);
            dgvservicio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 178);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Buscar";
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(228, 238);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(87, 20);
            Descripcion.TabIndex = 2;
            Descripcion.Text = "Descripcion";
            // 
            // cbmbuscar
            // 
            cbmbuscar.FormattingEnabled = true;
            cbmbuscar.Location = new Point(334, 175);
            cbmbuscar.Name = "cbmbuscar";
            cbmbuscar.Size = new Size(185, 28);
            cbmbuscar.TabIndex = 6;
            cbmbuscar.SelectedIndexChanged += cbmbuscar_SelectedIndexChanged;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(334, 231);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(185, 27);
            txtdescripcion.TabIndex = 7;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(197, 377);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(94, 29);
            btnlimpiar.TabIndex = 8;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(333, 377);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 29);
            btnbuscar.TabIndex = 9;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(467, 377);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(94, 29);
            btnsalir.TabIndex = 10;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // ConsultaServicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(970, 545);
            Controls.Add(btnsalir);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiar);
            Controls.Add(txtdescripcion);
            Controls.Add(cbmbuscar);
            Controls.Add(Descripcion);
            Controls.Add(label1);
            Controls.Add(dgvservicio);
            Name = "ConsultaServicio";
            Text = "ConsultaServicio";
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
    }
}