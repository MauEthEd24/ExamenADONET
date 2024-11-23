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
    public partial class frmCrear : Form
    {
        public frmCrear()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlParameter sqlParameterNombre = null;
            SqlParameter sqlParameterPrecio = null;
            SqlParameter sqlParameterStock = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_InsertarProductos", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlParameterNombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 50);
                    sqlParameterNombre.Value = txtNombre.Text.ToString();

                    sqlParameterPrecio = new SqlParameter("@Precio", SqlDbType.Decimal);
                    sqlParameterPrecio.Value = Convert.ToDecimal(txtPrecio.Text);

                    sqlParameterStock = new SqlParameter("@Stock", SqlDbType.Int);
                    sqlParameterStock.Value = Convert.ToInt32(txtStock.Text);

                   
                    command.Parameters.Add(sqlParameterNombre);
                    command.Parameters.Add(sqlParameterPrecio);
                    command.Parameters.Add(sqlParameterStock);


                    command.ExecuteNonQuery();

                    MessageBox.Show("Producto Grabado Correctamente");
                    Limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, comunicarse con el administrador...");
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Focus();
        }
    }
}
