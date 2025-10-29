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
            txtbuscar = new TextBox();
            cbobuscar = new ComboBox();
            label7 = new Label();
            dtvproyectos = new DataGridView();
            btnsalir = new Button();
            btnlimpiar = new Button();
            label2 = new Label();
            cbotabla = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtvproyectos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 194);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 29;
            label1.Text = "Descripcion";
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(230, 295);
            btnbuscar.Margin = new Padding(3, 4, 3, 4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(86, 31);
            btnbuscar.TabIndex = 28;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(215, 194);
            txtbuscar.Margin = new Padding(3, 4, 3, 4);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(189, 27);
            txtbuscar.TabIndex = 27;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // cbobuscar
            // 
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(215, 121);
            cbobuscar.Margin = new Padding(3, 4, 3, 4);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(189, 28);
            cbobuscar.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(125, 121);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 25;
            label7.Text = "Buscar";
            // 
            // dtvproyectos
            // 
            dtvproyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvproyectos.Location = new Point(484, 129);
            dtvproyectos.Margin = new Padding(3, 4, 3, 4);
            dtvproyectos.Name = "dtvproyectos";
            dtvproyectos.RowHeadersWidth = 51;
            dtvproyectos.Size = new Size(486, 269);
            dtvproyectos.TabIndex = 24;
            dtvproyectos.CellContentClick += dtvproyectos_CellContentClick;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(333, 295);
            btnsalir.Margin = new Padding(3, 4, 3, 4);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(86, 31);
            btnsalir.TabIndex = 23;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click_1;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(138, 295);
            btnlimpiar.Margin = new Padding(3, 4, 3, 4);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(86, 31);
            btnlimpiar.TabIndex = 22;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(619, 74);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 21;
            label2.Text = "CONSULTA DE PROYECTOS";
            // 
            // cbotabla
            // 
            cbotabla.FormattingEnabled = true;
            cbotabla.Location = new Point(215, 74);
            cbotabla.Margin = new Padding(3, 4, 3, 4);
            cbotabla.Name = "cbotabla";
            cbotabla.Size = new Size(189, 28);
            cbotabla.TabIndex = 31;
            cbotabla.SelectedIndexChanged += cbotabla_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 74);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 30;
            label3.Text = "Tabla";
            // 
            // ConsultaProyectos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1023, 600);
            Controls.Add(cbotabla);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Controls.Add(cbobuscar);
            Controls.Add(label7);
            Controls.Add(dtvproyectos);
            Controls.Add(btnsalir);
            Controls.Add(btnlimpiar);
            Controls.Add(label2);
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
        private TextBox txtbuscar;
        private ComboBox cbobuscar;
        private Label label7;
        private DataGridView dtvproyectos;
        private Button btnsalir;
        private Button btnlimpiar;
        private Label label2;
        private ComboBox cbotabla;
        private Label label3;
    }
}