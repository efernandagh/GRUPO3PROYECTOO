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
            ((System.ComponentModel.ISupportInitialize)dtvpagos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(700, 49);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 4;
            label2.Text = "Salida de pagos";
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(194, 220);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 11;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(365, 220);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 12;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // dtvpagos
            // 
            dtvpagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvpagos.Location = new Point(497, 95);
            dtvpagos.Name = "dtvpagos";
            dtvpagos.Size = new Size(425, 202);
            dtvpagos.TabIndex = 13;
            dtvpagos.CellContentClick += dtvpagos_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(183, 89);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 16;
            label7.Text = "Buscar";
            // 
            // cbobuscar
            // 
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(262, 89);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(166, 23);
            cbobuscar.TabIndex = 17;
            cbobuscar.SelectedIndexChanged += cbobuscar_SelectedIndexChanged;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(262, 144);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(166, 23);
            txtbuscar.TabIndex = 18;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(275, 220);
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
            label1.Location = new Point(170, 144);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 20;
            label1.Text = "Descripcion";
            // 
            // Salidapagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(895, 450);
            Controls.Add(label1);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Controls.Add(cbobuscar);
            Controls.Add(label7);
            Controls.Add(dtvpagos);
            Controls.Add(btnsalir);
            Controls.Add(btnlimpiar);
            Controls.Add(label2);
            Name = "Salidapagos";
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
    }
}