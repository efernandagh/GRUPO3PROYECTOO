using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace INICIO
{
    public partial class frmPagos : Form
    {

        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;
        public frmPagos()
        {
            InitializeComponent();
            CargarFacturas();

            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    MessageBox.Show("✅ Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error de conexión: " + ex.Message);
            }
        }


        // ✅ Cargar al iniciar el formulario
        private void frmPagos_Load(object sender, EventArgs e)
        {
            txtPago.Enabled = false;
            GenerarNuevoId();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy";

            // 🔹 Cargar estados de pago
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Pendiente");
            cboEstado.Items.Add("Pagado");
            cboEstado.Items.Add("Cancelado");
            cboEstado.SelectedIndex = 0;

            // 🔹 Cargar facturas desde la base de datos
            CargarFacturas();
        }

        // ✅ Cargar los ID_FACTURA en el ComboBox
        private void CargarFacturas()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT ID_FACTURA FROM FACTURAS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbidfaactura.Items.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("⚠️ No hay facturas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    while (reader.Read())
                    {
                        cmbidfaactura.Items.Add(reader["ID_FACTURA"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar facturas: " + ex.Message, "Error");
            }
        }



        // ✅ Botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Formulario limpiado correctamente.", "Limpieza", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ✅ Método para limpiar todos los campos
        private void LimpiarCampos()
        {
            txtPago.Clear();
            txtMonto.Clear();
            dtpFecha.Value = DateTime.Now;
            cboEstado.SelectedIndex = 0;
            cmbidfaactura.SelectedIndex = -1;
            txtPago.Focus();
        }

        // ✅ Botón Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                this.Close();
        }

        // ✅ Validar entrada numérica en txtMonto
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, punto decimal y teclas de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && txtMonto.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // ✅ VALIDACIONES
                if (cmbidfaactura.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una factura.", "Advertencia");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMonto.Text))
                {
                    MessageBox.Show("Ingrese un monto válido.", "Advertencia");
                    return;
                }

                if (!decimal.TryParse(txtMonto.Text, out decimal monto))
                {
                    MessageBox.Show("El monto debe ser numérico.", "Error");
                    return;
                }

                if (cboEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un estado.", "Advertencia");
                    return;
                }

                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    // ✅ Generar nuevo ID_PAGO manualmente
                    long nuevoId = 0;
                    using (SqlCommand cmdId = new SqlCommand("SELECT ISNULL(MAX(ID_PAGO), 0) + 1 FROM PAGOS", conn))
                    {
                        nuevoId = Convert.ToInt64(cmdId.ExecuteScalar());
                    }

                    // ✅ Insertar el nuevo pago
                    string query = @"INSERT INTO PAGOS (ID_PAGO, ID_FACTURA, FECHA_PAGO, MONTO_PAGO, ESTADO_PAGO)
                             VALUES (@idpago, @idfactura, @fecha, @monto, @estado)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idpago", nuevoId);
                    cmd.Parameters.AddWithValue("@idfactura", Convert.ToInt64(cmbidfaactura.SelectedItem));
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@estado", cboEstado.SelectedItem.ToString());

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("✅ Pago guardado correctamente.", "Éxito");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No se insertó ningún registro.", "Aviso");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"❌ Error SQL: {ex.Message}", "Error SQL");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error general: {ex.Message}", "Error");
            }
        }

        private void frmPagos_Load_1(object sender, EventArgs e)
        {
            txtPago.Enabled=false;
            GenerarNuevoId();
        }
        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_PAGO), 0) + 1 FROM PAGOS";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }
        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {

                    string consulta = "SELECT ISNULL(MAX(ID_PAGO), 0) + 1 FROM PAGOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtPago.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtPago.Text = "1";
            }
        }
    }
}