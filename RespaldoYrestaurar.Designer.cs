namespace INICIO
{
    partial class RespaldoYrestaurar
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
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            btnrestau = new Button();
            btnrestaurar = new Button();
            btnayuda = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnrestau);
            groupBox1.Controls.Add(btnrestaurar);
            groupBox1.Location = new Point(221, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Respaldo y restauracion";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(176, 224);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnrestau
            // 
            btnrestau.BackColor = Color.SteelBlue;
            btnrestau.FlatAppearance.BorderColor = Color.SteelBlue;
            btnrestau.FlatAppearance.BorderSize = 0;
            btnrestau.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            btnrestau.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnrestau.FlatStyle = FlatStyle.Flat;
            btnrestau.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnrestau.Location = new Point(45, 134);
            btnrestau.Name = "btnrestau";
            btnrestau.Size = new Size(124, 29);
            btnrestau.TabIndex = 7;
            btnrestau.Text = "Restaurar";
            btnrestau.UseVisualStyleBackColor = false;
            btnrestau.Click += btnrestau_Click;
            // 
            // btnrestaurar
            // 
            btnrestaurar.BackColor = Color.SteelBlue;
            btnrestaurar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnrestaurar.FlatAppearance.BorderSize = 0;
            btnrestaurar.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            btnrestaurar.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnrestaurar.FlatStyle = FlatStyle.Flat;
            btnrestaurar.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnrestaurar.Location = new Point(45, 54);
            btnrestaurar.Name = "btnrestaurar";
            btnrestaurar.Size = new Size(124, 29);
            btnrestaurar.TabIndex = 6;
            btnrestaurar.Text = "Respaldo";
            btnrestaurar.UseVisualStyleBackColor = false;
            btnrestaurar.Click += btnrestaurar_Click;
            // 
            // btnayuda
            // 
            btnayuda.FlatAppearance.BorderSize = 0;
            btnayuda.FlatAppearance.MouseOverBackColor = Color.Red;
            btnayuda.FlatStyle = FlatStyle.Flat;
            btnayuda.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnayuda.ForeColor = Color.White;
            btnayuda.Location = new Point(379, 375);
            btnayuda.Margin = new Padding(3, 2, 3, 2);
            btnayuda.Name = "btnayuda";
            btnayuda.Size = new Size(117, 30);
            btnayuda.TabIndex = 36;
            btnayuda.Text = "Ayuda";
            btnayuda.UseVisualStyleBackColor = true;
            btnayuda.Click += btnayuda_Click;
            // 
            // RespaldoYrestaurar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(940, 545);
            Controls.Add(btnayuda);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RespaldoYrestaurar";
            Text = "RespaldoYrestaurar";
            Load += RespaldoYrestaurar_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnrestau;
        private Button btnrestaurar;
        private Button btnSalir;
        private Button btnayuda;
    }
}