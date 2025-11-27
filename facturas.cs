using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    public partial class facturas : Form
    {
        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;

        public facturas()
        {
            InitializeComponent();
        }

        private void facturas_Load(object sender, EventArgs e)
        {
            txtidfactura.Enabled = false;
            GenerarNuevoId();

            // 🔹 Cargar contratos
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT ID_CONTRATO FROM CONTRATOS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cboidcontrato.Items.Clear();

                    while (reader.Read())
                    {
                        cboidcontrato.Items.Add(reader["ID_CONTRATO"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar contratos: " + ex.Message);
            }

            // 🔹 Cargar métodos de pago
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Tarjeta");
            cmbMetodoPago.Items.Add("Transferencia");
            cmbMetodoPago.Items.Add("Depósito");

            dtpFecha.Format = DateTimePickerFormat.Custom;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtidfactura.Clear();
            cboidcontrato.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            txtMontoTotal.Clear();
            cmbMetodoPago.SelectedIndex = -1;

            MessageBox.Show("Todos los campos han sido limpiados", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema de facturas?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // ✅ Validaciones
            if (cboidcontrato.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtMontoTotal.Text) ||
                cmbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Por favor, completa todos los campos.", "Advertencia");
                return;
            }

            if (!decimal.TryParse(txtMontoTotal.Text, out decimal montoDecimal))
            {
                MessageBox.Show("⚠️ El monto debe ser un número válido.", "Advertencia");
                return;
            }

            int idGenerado = 0;

            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                try
                {
                    // 🔹 Generar el nuevo ID manualmente
                    string getNextIdQuery = "SELECT ISNULL(MAX(ID_FACTURA), 0) + 1 FROM FACTURAS";
                    SqlCommand getIdCmd = new SqlCommand(getNextIdQuery, conn);
                    idGenerado = Convert.ToInt32(getIdCmd.ExecuteScalar());

                    // 🔹 Insertar nueva factura
                    string query = @"INSERT INTO FACTURAS (ID_FACTURA, ID_CONTRATO, FECHA_FACTURA, MONTO_TOTAL, METODO_PAGO)
                                     VALUES (@idfactura, @idcontrato, @fecha, @monto, @metodo)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idfactura", idGenerado);
                    cmd.Parameters.AddWithValue("@idcontrato", Convert.ToInt32(cboidcontrato.SelectedItem));
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@monto", montoDecimal);
                    cmd.Parameters.AddWithValue("@metodo", cmbMetodoPago.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    // 🔹 Mostrar mensaje de éxito
                    MessageBox.Show($"✅ Factura guardada correctamente.\n🧾 ID generado: {idGenerado}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 🔹 Preguntar si desea registrar pago
                    DialogResult result = MessageBox.Show(
                        "¿Desea registrar un pago para esta factura?",
                        "Factura Guardada",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Aquí podrías abrir el formulario de pagos
                        // new pagos(idGenerado).ShowDialog();
                    }

                    // 🔹 Actualizar el campo ID en pantalla
                    txtidfactura.Text = idGenerado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al guardar: " + ex.Message);
                }
            }

            // 🔹 Mostrar resumen amigable
            string mensaje = "═══════════════════════════════\n";
            mensaje += "   FACTURA GUARDADA EXITOSAMENTE\n";
            mensaje += "═══════════════════════════════\n\n";
            mensaje += "📋 Contrato: " + cboidcontrato.SelectedItem.ToString() + "\n\n";
            mensaje += "📅 Fecha: " + dtpFecha.Value.ToString("dddd, dd 'de' MMMM 'de' yyyy") + "\n\n";
            mensaje += "💰 Monto Total: L. " + montoDecimal.ToString("N2") + "\n\n";
            mensaje += "💳 Método de Pago: " + cmbMetodoPago.SelectedItem.ToString() + "\n";
            mensaje += "═══════════════════════════════";

            MessageBox.Show(mensaje, "✓ Factura Registrada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 🔹 Preguntar si desea crear otra factura
            DialogResult respuesta = MessageBox.Show(
                "¿Desea crear otra factura?",
                "Nueva Factura",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                btnLimpiar_Click(sender, e);
                GenerarNuevoId();
            }
            else
            {
                this.Close();
            }
        }

        // ✅ Función para generar el siguiente ID automáticamente
        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string consulta = "SELECT ISNULL(MAX(ID_FACTURA), 0) + 1 FROM FACTURAS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidfactura.Text = resultado?.ToString() ?? "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtidfactura.Text = "1";
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = @"C:\Users\Belen\Downloads\MANUAL FACTURACION.pdf",
                UseShellExecute = true // esto indica que abra con la app predeterminada
            };
            System.Diagnostics.Process.Start(psi);
        }

    }
}

