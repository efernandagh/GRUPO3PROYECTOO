using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO
{

    public partial class Salidapagos : Form
    {
        public Salidapagos()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {



        }





        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cmbtabla.SelectedIndex = 0;
            cmbdescrip.SelectedIndex = 0;
            dtvpagos.DataSource = null; ;
        }

        private void Salidapagos_Load(object sender, EventArgs e)
        {
            cmbtabla.Items.AddRange(new string[] { "FACTURAS", "PAGOS" });
            cmbtabla.SelectedIndex = 0;
            CargarColumnas("FACTURAS");
            CargarValoresDescripcion("FACTURAS", cbobuscar.SelectedItem.ToString());
            CargarDatos();
        }
        private void CargarDescripcion()
        {
            cmbdescrip.Items.Clear();

            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string campo = cbobuscar.SelectedItem.ToString();
                string query = $"SELECT DISTINCT {campo} FROM PAGOS";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbdescrip.Items.Add(dr[0].ToString());
                }
            }

            if (cmbdescrip.Items.Count > 0)
                cmbdescrip.SelectedIndex = 0;
        }
        private void CargarDatos()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string tabla = cmbtabla.Text;
                    string columna = cbobuscar.Text;
                    string valor = cmbdescrip.Text;

                    string query = $"SELECT * FROM {tabla}";

                    if (!string.IsNullOrEmpty(valor))
                    {
                        if (columna.Contains("FECHA"))
                        {
                            query += $" WHERE CONVERT(date, {columna}) = '{valor}'";
                        }
                        else
                        {
                            query += $" WHERE {columna} LIKE '%{valor}%'";
                        }
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvpagos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void InicializarCombos()
        {
            try
            {
                cmbtabla.Items.Clear();
                cmbtabla.Items.Add("PAGOS");
                cmbtabla.Items.Add("FACTURAS");

                if (cmbtabla.Items.Count > 0)
                {
                    cmbtabla.SelectedIndex = 0;
                    CargarColumnas(cmbtabla.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar combos: " + ex.Message);
            }
        }
        // ✅ Cargar valores únicos de la columna seleccionada en el ComboBox descripción
        private void CargarValoresDescripcion(string tabla, string columna)
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"SELECT DISTINCT {columna} FROM {tabla} WHERE {columna} IS NOT NULL";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbdescrip.Items.Clear();

                    while (reader.Read())
                    {
                        object val = reader[columna];

                        if (val is DateTime)
                            cmbdescrip.Items.Add(Convert.ToDateTime(val).ToString("yyyy-MM-dd"));
                        else
                            cmbdescrip.Items.Add(val.ToString());
                    }

                    if (cmbdescrip.Items.Count > 0)
                        cmbdescrip.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar valores: " + ex.Message);
            }
        }

        private void CargarColumnas(string tabla)
        {
            cbobuscar.Items.Clear();

            switch (tabla)
            {
                case "PAGOS":
                    cbobuscar.Items.AddRange(new string[]
                    {
                "ID_PAGO",
                "ID_FACTURA",
                "FECHA_PAGO",
                "MONTO_PAGO",
                "ESTADO_PAGO"
                    });
                    break;

                case "FACTURAS":
                    cbobuscar.Items.AddRange(new string[]
                    {
                "ID_FACTURA",
                "ID_CONTRATO",
                "FECHA_FACTURA",
                "MONTO_TOTAL",
                "METODO_PAGO"
                    });
                    break;
            }

            if (cbobuscar.Items.Count > 0)
                cbobuscar.SelectedIndex = 0;
        }


        private void btnsalir_Click(object sender, EventArgs e)
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

        // 🔹 Cargar todos los registros
        private void CargarPagos()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT * FROM Pagos";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvpagos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pagos: " + ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

          
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }



        private void dtvpagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarValoresDescripcion(cmbtabla.Text, cbobuscar.Text);
        }


        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbtabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarColumnas(cmbtabla.Text);
            CargarValoresDescripcion(cmbtabla.Text, cbobuscar.Text);
            CargarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbdescrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }

}
