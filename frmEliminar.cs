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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlParameter sqlParameterIdproducto = null;


            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_EliminarProductos", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlParameterIdproducto = new SqlParameter("@IdProducto", SqlDbType.VarChar, 50);
                    sqlParameterIdproducto.Value = Convert.ToInt32(txtIdProducto.Text);

                    command.Parameters.Add(sqlParameterIdproducto);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Producto Eliminado Correctamente");
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
            txtIdProducto.Clear();
            txtIdProducto.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
