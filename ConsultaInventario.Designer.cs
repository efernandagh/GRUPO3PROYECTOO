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
            txtdescripcion = new TextBox();
            btnlimpiar = new Button();
            btnbuscar = new Button();
            btnsalir = new Button();
            cmbtabla = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvinventario).BeginInit();
            SuspendLayout();
            // 
            // cmbbuscar
            // 
            cmbbuscar.FormattingEnabled = true;
            cmbbuscar.Location = new Point(203, 169);
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
            dgvinventario.Location = new Point(427, 105);
            dgvinventario.Margin = new Padding(3, 2, 3, 2);
            dgvinventario.Name = "dgvinventario";
            dgvinventario.RowHeadersWidth = 51;
            dgvinventario.Size = new Size(368, 175);
            dgvinventario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(122, 172);
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
            label3.Location = new Point(122, 238);
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
            label4.Location = new Point(540, 67);
            label4.Name = "label4";
            label4.Size = new Size(155, 17);
            label4.TabIndex = 6;
            label4.Text = "CONSULTA INVENTARIO";
            label4.Click += label4_Click;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(203, 238);
            txtdescripcion.Margin = new Padding(3, 2, 3, 2);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(133, 23);
            txtdescripcion.TabIndex = 7;
            // 
            // btnlimpiar
            // 
            btnlimpiar.FlatAppearance.BorderSize = 0;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.Location = new Point(79, 325);
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
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(203, 325);
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
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(337, 325);
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
            cmbtabla.Location = new Point(203, 115);
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
            label1.Location = new Point(122, 123);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 12;
            label1.Text = "Tabla";
            // 
            // ConsultaInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(872, 463);
            Controls.Add(label1);
            Controls.Add(cmbtabla);
            Controls.Add(btnsalir);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiar);
            Controls.Add(txtdescripcion);
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
            Load += ConsultaInventario_Load_1;
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
        private TextBox txtdescripcion;
        private Button btnlimpiar;
        private Button btnbuscar;
        private Button btnsalir;
        private ComboBox cmbtabla;
        private Label label1;
    }
}