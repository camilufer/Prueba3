using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba3.Models
{
    public class Producto {

        private int idProducto;
        private int precio;
        private string nombre;
        private int idUser;

        public int IdProducto { get { return idProducto; } }
        public int Precio { get { return precio; } }
        public string Nombre { get { return nombre; } }
        public int IdUser { get { return idUser; } }

        public Producto()
        {
        }

        public Producto(int idProducto, int precio, string nombre, int idUser)
        {
            this.idProducto = idProducto;
            this.precio = precio;
            this.nombre = nombre;
            this.idUser = idUser;
        }
    }
}