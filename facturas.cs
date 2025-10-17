using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    
                    string query = "SELECT ID_FACTURA FROM FACTURAS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cboidcontrato.Items.Clear();

                    while (reader.Read())
                    {
                        cboidcontrato.Items.Add(reader["ID_FACTURA"].ToString());
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtidfactura.Clear();
            // Limpiar ComboBox de Método de Pago
            cboidcontrato.SelectedIndex = -1;

            // Establecer fecha actual
            dtpFecha.Value = DateTime.Now;

            // Limpiar campo de monto
            txtMontoTotal.Clear();

            // Limpiar ComboBox de Método de Pago
            cmbMetodoPago.SelectedIndex = -1;

            // Mensaje de confirmación
            MessageBox.Show("Todos los campos han sido limpiados", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Preguntar si realmente quiere salir
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema de facturas?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario presiona "Sí", cerrar el formulario
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (cboidcontrato.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMontoTotal.Text) || cmbMetodoPago.SelectedIndex == -1)
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
                    

                    string query = @"INSERT INTO FACTURAS (ID_CONTRATO, FECHA_FACTURA, MONTO_TOTAL, METODO_PAGO)
                                     OUTPUT INSERTED.ID_FACTURA
                                     VALUES (@idcontrato, @fecha, @monto, @metodo)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idcontrato", Convert.ToInt32(cboidcontrato.SelectedItem));
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@monto", montoDecimal);
                    cmd.Parameters.AddWithValue("@metodo", cmbMetodoPago.SelectedItem.ToString());

                    // 🔹 Obtener el ID autogenerado
                    idGenerado = (int)cmd.ExecuteScalar();

                    MessageBox.Show($"✅ Factura guardada correctamente.\n🧾 ID generado: {idGenerado}",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 🔹 Preguntar si desea registrar pago
                    DialogResult result = MessageBox.Show("¿Desea registrar un pago para esta factura?",
                        "Factura Guardada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al guardar: " + ex.Message);
                }
            }






            // VALIDACIÓN 2: Verificar que se haya ingresado un monto
            if (string.IsNullOrWhiteSpace(txtMontoTotal.Text))
            {
                MessageBox.Show("Por favor ingrese el monto total",
                    "Campo Requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMontoTotal.Focus();
                return;
            }

            // VALIDACIÓN 3: Verificar que el monto sea un número válido
            decimal monto;
            if (!decimal.TryParse(txtMontoTotal.Text, out monto))
            {
                MessageBox.Show("El monto debe ser un número válido\nEjemplo: 1500.50",
                    "Formato Incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMontoTotal.Focus();
                txtMontoTotal.SelectAll();
                return;
            }

            // VALIDACIÓN 4: Verificar que el monto sea mayor a cero
            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a cero",
                    "Monto Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMontoTotal.Focus();
                txtMontoTotal.SelectAll();
                return;
            }

            // VALIDACIÓN 5: Verificar que se haya seleccionado un método de pago
            if (cmbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un método de pago",
                    "Campo Requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbMetodoPago.Focus();
                return;
            }

            // SI TODAS LAS VALIDACIONES PASARON, GUARDAR LA FACTURA

            // Crear el mensaje con los datos de la factura
            string mensaje = "═══════════════════════════════\n";
            mensaje += "   FACTURA GUARDADA EXITOSAMENTE\n";
            mensaje += "═══════════════════════════════\n\n";
            mensaje += "📋 Tipo de Contrato:\n    " + cboidcontrato.SelectedItem.ToString() + "\n\n";
            mensaje += "📅 Fecha:\n    " + dtpFecha.Value.ToString("dddd, dd 'de' MMMM 'de' yyyy") + "\n\n";
            mensaje += "💰 Monto Total:\n    L. " + monto.ToString("N2") + "\n\n";
            mensaje += "💳 Método de Pago:\n    " + cmbMetodoPago.SelectedItem.ToString() + "\n";
            mensaje += "═══════════════════════════════";

            // Mostrar mensaje de éxito
            MessageBox.Show(mensaje,
                "✓ Factura Registrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // AQUÍ PUEDES AGREGAR CÓDIGO PARA GUARDAR EN BASE DE DATOS
            // Por ejemplo:
            // GuardarEnBaseDeDatos(cmbContrato.SelectedItem.ToString(), dtpFecha.Value, monto, cmbMetodoPago.SelectedItem.ToString());

            // Preguntar si desea crear otra factura
            DialogResult respuesta = MessageBox.Show(
                "¿Desea crear otra factura?",
                "Nueva Factura",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // Limpiar los campos para una nueva factura
                btnLimpiar_Click(sender, e);
            }
            else
            {
                // Cerrar el formulario
                this.Close();
            }
        }

        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_FACTURA), 0) + 1 FROM FACTURAS";
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

                    string consulta = "SELECT ISNULL(MAX(ID_FACTURA), 0) + 1 FROM FACTURAS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidfactura.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtidfactura.Text = "1";
            }
        }

        private void cmbContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboidcontrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
          


        }
      
    }


}


