namespace INICIO
{
    partial class proveedores
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
            groupBox2 = new GroupBox();
            btncancelar = new Button();
            btnlimpiar = new Button();
            textBox4 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtidproveedor = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.CornflowerBlue;
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btncancelar);
            groupBox2.Controls.Add(btnlimpiar);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(372, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 288);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seccion de proveedores";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btncancelar
            // 
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Location = new Point(212, 235);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 9;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.FlatAppearance.BorderSize = 0;
            btnlimpiar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Location = new Point(117, 235);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 8;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(117, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(122, 25);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(29, 235);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 25);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 25);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 25);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 167);
            label4.Name = "label4";
            label4.Size = new Size(60, 17);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 132);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 2;
            label3.Text = "correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 88);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 52);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 0;
            label1.Text = "Proveedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 21);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 10;
            label5.Text = "Id proveedor";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(117, 18);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(122, 25);
            txtidproveedor.TabIndex = 11;
            // 
            // proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(945, 482);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "proveedores";
            Text = "proveedores";
            Load += proveedores_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button btncancelar;
        private Button btnlimpiar;
        private TextBox txtidproveedor;
        private Label label5;
    }
}