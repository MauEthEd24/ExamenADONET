﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ExamenADONET
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlParameter sqlParameter = null;
            List<Producto> producto = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_BuscarProductos", conexion);
                    command.CommandType = CommandType.StoredProcedure;


                    sqlParameter = new SqlParameter("@Nombre", SqlDbType.VarChar, 50);
                    sqlParameter.Value = txtNombreProducto.Text;

                                       
                    command.Parameters.Add(sqlParameter);
                    

                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        producto.Add(new Producto
                        {
                            IdProducto = (int)reader["IdProducto"],
                            Nombre = (string)reader["Nombre"],
                            Precio = (decimal)reader["Precio"],
                            Stock = (int)reader["Stock"],
                        }
                       );
                    }

                    

                }
                //return producto;
                dgvProductos.DataSource = producto;
            }
            catch (Exception)
            {

                MessageBox.Show("Error, comunicarse con el administrador...");
            }
            finally
            {
                command = null;
                sqlParameter = null;
                producto = null;

            }
        }
    }
}