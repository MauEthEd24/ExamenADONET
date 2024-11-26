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

namespace ExamenADONET
{
    public partial class frmActualizar : Form
    {
        public frmActualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton BUSCAR
            SqlCommand command = null;
            List<Producto> productos = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {

                    command = new SqlCommand("USP_BuscarProductosPorID", conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdProducto", txtIdProducto.Text);


                    productos = new List<Producto>();


                    conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();



                    reader.Read();
                    txtNombre.Text = Convert.ToString(reader["Nombre"]);
                    txtPrecio.Text = Convert.ToString(reader["Precio"]);
                    txtStock.Text = Convert.ToString(reader["Stock"]);


                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error, comunicar al administrador");
            }
            finally
            {
                command = null;
                productos = null;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {

                MessageBox.Show("Debe ingresar la informacion completa del producto");
            }
            else
            {

                SqlCommand command = null;


                try
                {
                    using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                    {

                        command = new SqlCommand("USP_ActualizarProductos", conexion);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdProducto", txtIdProducto.Text);
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                        command.Parameters.AddWithValue("@Stock", txtStock.Text);
                        conexion.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Se actualizo exitosamente");
                        Limpiar();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, comunicar al administrador");
                }
                finally
                {
                    command = null;

                }
            }
        }
        private void Limpiar()
        {
            txtIdProducto.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtIdProducto.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
