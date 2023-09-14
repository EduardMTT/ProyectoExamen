using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using AccesoDatos;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaProductos
    {
        private AccesoProductos _AccesoDatosProductos;

        public LogicaProductos()
        {
            _AccesoDatosProductos = new AccesoProductos();
        }

        public List<Productos> ObtenerProducto(string valor)
        {
            return _AccesoDatosProductos.ObtenerDatos(valor);
        }

        public void EliminarProducto(int IdProducto)
        {
            _AccesoDatosProductos.EliminarProducto(IdProducto);
        }

        public void GuardarProducto(Productos datosProducto)
        {
            _AccesoDatosProductos.GuardarProducto(datosProducto);
        }

        public void ActualizarProducto(Productos datosProducto)
        {
            _AccesoDatosProductos.ActualizarProducto(datosProducto);
        }

        public Tuple<bool, string> ValidarDatosProducto(Productos nuevosDatos)
        {
            //Se declara una variable mensaje como una cadena vacía y una variable valida como true
            //para almacenar el mensaje de error y el estado de validación, respectivamente.
            string mensaje = "";
            bool esValido = true;

            if (nuevosDatos.Nombre == "")
            {
                mensaje = "El campo Nombre es requerido";
                esValido = false;
            }
            if (nuevosDatos.Descripcion == "")
            {
                mensaje = "El campo Descripcion es requerido";
                esValido = false;
            }
            if (nuevosDatos.Precio == 0)
            {
                mensaje = "El campo Precio es requerido";
                esValido = false;
            }

            var resultado = new Tuple<bool, string>(esValido, mensaje);
            return resultado;
        }
    }
}
