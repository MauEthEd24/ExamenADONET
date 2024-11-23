using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenADONET
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}

/*
 IdProducto INT IDENTITY(1,1)
    Nombre NVARCHAR(100) 
    Precio DECIMAL(10,2)
    Stock INT NOT NULL
    FechaCreacion DATETIME 
	Estado int,
	FechaModificacion DATETIME	
 */