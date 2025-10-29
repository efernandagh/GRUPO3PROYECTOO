namespace INICIO
{
    partial class Salidapagos
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
            label2 = new Label();
            btnlimpiar = new Button();
            btnsalir = new Button();
            dtvpagos = new DataGridView();
            label7 = new Label();
            cbobuscar = new ComboBox();
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            label1 = new Label();
            cmbtabla = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtvpagos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(566, 55);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 4;
            label2.Text = "Salida de pagos";
            // 
            // btnlimpiar
            // 
            btnlimpiar.FlatAppearance.BorderSize = 0;
            btnlimpiar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.Location = new Point(92, 285);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 11;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnsalir
            // 
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(263, 285);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 12;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // dtvpagos
            // 
            dtvpagos.BackgroundColor = Color.FromArgb(192, 192, 255);
            dtvpagos.BorderStyle = BorderStyle.None;
            dtvpagos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtvpagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvpagos.Location = new Point(401, 98);
            dtvpagos.Name = "dtvpagos";
            dtvpagos.RowHeadersWidth = 51;
            dtvpagos.Size = new Size(425, 202);
            dtvpagos.TabIndex = 13;
            dtvpagos.CellContentClick += dtvpagos_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(81, 154);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 16;
            label7.Text = "Buscar";
            // 
            // cbobuscar
            // 
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(160, 154);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(166, 23);
            cbobuscar.TabIndex = 17;
            cbobuscar.SelectedIndexChanged += cbobuscar_SelectedIndexChanged;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(160, 224);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(166, 23);
            txtbuscar.TabIndex = 18;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // btnbuscar
            // 
            btnbuscar.FlatAppearance.BorderSize = 0;
            btnbuscar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(173, 285);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 23);
            btnbuscar.TabIndex = 19;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 209);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 20;
            label1.Text = "Descripcion";
            // 
            // cmbtabla
            // 
            cmbtabla.FormattingEnabled = true;
            cmbtabla.Location = new Point(160, 95);
            cmbtabla.Name = "cmbtabla";
            cmbtabla.Size = new Size(166, 23);
            cmbtabla.TabIndex = 21;
            cmbtabla.SelectedIndexChanged += cmbtabla_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(92, 98);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 22;
            label3.Text = "Tabla";
            // 
            // Salidapagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(895, 450);
            Controls.Add(label3);
            Controls.Add(cmbtabla);
            Controls.Add(label1);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Controls.Add(cbobuscar);
            Controls.Add(label7);
            Controls.Add(dtvpagos);
            Controls.Add(btnsalir);
            Controls.Add(btnlimpiar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salidapagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salidapagos";
            Load += Salidapagos_Load;
            ((System.ComponentModel.ISupportInitialize)dtvpagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnlimpiar;
        private Button btnsalir;
        private DataGridView dtvpagos;
        private Label label7;
        private ComboBox cbobuscar;
        private TextBox txtbuscar;
        private Button btnbuscar;
        private Label label1;
        private ComboBox cmbtabla;
        private Label label3;
    }
}