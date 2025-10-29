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
            ((System.ComponentModel.ISupportInitialize)dgvinventario).BeginInit();
            SuspendLayout();
            // 
            // cmbbuscar
            // 
            cmbbuscar.FormattingEnabled = true;
            cmbbuscar.Location = new Point(246, 199);
            cmbbuscar.Name = "cmbbuscar";
            cmbbuscar.Size = new Size(151, 28);
            cmbbuscar.TabIndex = 0;
            // 
            // dgvinventario
            // 
            dgvinventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinventario.Location = new Point(498, 154);
            dgvinventario.Name = "dgvinventario";
            dgvinventario.RowHeadersWidth = 51;
            dgvinventario.Size = new Size(402, 233);
            dgvinventario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 202);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "Buscar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 290);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(619, 103);
            label4.Name = "label4";
            label4.Size = new Size(169, 20);
            label4.TabIndex = 6;
            label4.Text = "CONSULTA INVENTARIO";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(246, 290);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(151, 27);
            txtdescripcion.TabIndex = 7;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(90, 433);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(94, 29);
            btnlimpiar.TabIndex = 8;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(232, 433);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 29);
            btnbuscar.TabIndex = 9;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(385, 433);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(94, 29);
            btnsalir.TabIndex = 10;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // ConsultaInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(960, 617);
            Controls.Add(btnsalir);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiar);
            Controls.Add(txtdescripcion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvinventario);
            Controls.Add(cmbbuscar);
            Name = "ConsultaInventario";
            Text = "ConsultaInventario";
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
    }
}