using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Entidades;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoProductos
    {
        Conexion conexion;
        public AccesoProductos()
        {
            conexion = new Conexion("localhost", "root", "tienda1", 3306);
        }

        public List<Productos> ObtenerDatos(string valor)
        {
            var ListaDatosProducto = new List<Productos>();

            var dataTable = new DataTable();

            var consulta = string.Format("select * from producto where Nombre like '%{0}%'", valor);
            dataTable = conexion.ObtenerDatos(consulta);

            foreach (DataRow renglon in dataTable.Rows)
            {
                var DatosProducto = new Productos
                {
                    Id = Convert.ToInt32(renglon["idd"]),
                    Nombre = renglon["nombre"].ToString(),
                    Descripcion = renglon["descripcion"].ToString(),
                    Precio = double.Parse(renglon["precio"].ToString())
                };
                ListaDatosProducto.Add(DatosProducto);
            }
            return ListaDatosProducto;
        }


        public void GuardarProducto(Productos nuevosProductos)
        {
            string consulta = string.Format("insert into producto values(null, '{0}', '{1}', {2})",
                nuevosProductos.Nombre, nuevosProductos.Descripcion, nuevosProductos.Precio);
            conexion.EjecutarConsulta(consulta);
        }

        public void ActualizarProducto(Productos nuevosDatos)
        {
            string consulta = string.Format("update producto set Nombre = '{0}', Descripcion = '{1}', Precio = {2}",
                nuevosDatos.Nombre, nuevosDatos.Descripcion, nuevosDatos.Precio);
            conexion.EjecutarConsulta(consulta);
        }

        public void EliminarProducto(int IdUsuario)
        {
            string consulta = string.Format("delete from producto where IdProducto = {0}", IdUsuario);
            conexion.EjecutarConsulta(consulta);
        }
    }
}
