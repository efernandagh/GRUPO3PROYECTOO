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
            btnsalir = new Button();
            dtvpagos = new DataGridView();
            label7 = new Label();
            cbobuscar = new ComboBox();
            label1 = new Label();
            cmbtabla = new ComboBox();
            label3 = new Label();
            cmbdescrip = new ComboBox();
            label4 = new Label();
            btnexcel = new Button();
            btnpdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvpagos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(470, 28);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 4;
            label2.Text = "Salida de pagos";
            label2.Click += label2_Click;
            // 
            // btnsalir
            // 
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(426, 482);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(86, 31);
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
            dtvpagos.Location = new Point(118, 232);
            dtvpagos.Margin = new Padding(3, 4, 3, 4);
            dtvpagos.Name = "dtvpagos";
            dtvpagos.RowHeadersWidth = 51;
            dtvpagos.Size = new Size(823, 339);
            dtvpagos.TabIndex = 13;
            dtvpagos.CellContentClick += dtvpagos_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(354, 137);
            label7.Name = "label7";
            label7.Size = new Size(58, 23);
            label7.TabIndex = 16;
            label7.Text = "Buscar";
            // 
            // cbobuscar
            // 
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(423, 136);
            cbobuscar.Margin = new Padding(3, 4, 3, 4);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(189, 28);
            cbobuscar.TabIndex = 17;
            cbobuscar.SelectedIndexChanged += cbobuscar_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(637, 139);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 20;
            label1.Text = "Descripcion";
            // 
            // cmbtabla
            // 
            cmbtabla.FormattingEnabled = true;
            cmbtabla.Location = new Point(146, 139);
            cmbtabla.Margin = new Padding(3, 4, 3, 4);
            cmbtabla.Name = "cmbtabla";
            cmbtabla.Size = new Size(189, 28);
            cmbtabla.TabIndex = 21;
            cmbtabla.SelectedIndexChanged += cmbtabla_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(95, 136);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 22;
            label3.Text = "Tabla";
            // 
            // cmbdescrip
            // 
            cmbdescrip.FormattingEnabled = true;
            cmbdescrip.Location = new Point(747, 136);
            cmbdescrip.Margin = new Padding(3, 4, 3, 4);
            cmbdescrip.Name = "cmbdescrip";
            cmbdescrip.Size = new Size(138, 28);
            cmbdescrip.TabIndex = 23;
            cmbdescrip.SelectedIndexChanged += cmbdescrip_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 593);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 24;
            label4.Text = "Exportar";
            // 
            // btnexcel
            // 
            btnexcel.Location = new Point(354, 627);
            btnexcel.Name = "btnexcel";
            btnexcel.Size = new Size(109, 38);
            btnexcel.TabIndex = 25;
            btnexcel.Text = "EXCEL";
            btnexcel.UseVisualStyleBackColor = true;
            btnexcel.Click += btnexcel_Click;
            // 
            // btnpdf
            // 
            btnpdf.Location = new Point(560, 627);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(103, 38);
            btnpdf.TabIndex = 26;
            btnpdf.Text = "PDF";
            btnpdf.UseVisualStyleBackColor = true;
            btnpdf.Click += btnpdf_Click;
            // 
            // Salidapagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1023, 802);
            Controls.Add(btnpdf);
            Controls.Add(btnexcel);
            Controls.Add(label4);
            Controls.Add(cmbdescrip);
            Controls.Add(label3);
            Controls.Add(cmbtabla);
            Controls.Add(label1);
            Controls.Add(cbobuscar);
            Controls.Add(label7);
            Controls.Add(dtvpagos);
            Controls.Add(btnsalir);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnsalir;
        private DataGridView dtvpagos;
        private Label label7;
        private ComboBox cbobuscar;
        private Label label1;
        private ComboBox cmbtabla;
        private Label label3;
        private ComboBox cmbdescrip;
        private Label label4;
        private Button btnexcel;
        private Button btnpdf;
    }
}