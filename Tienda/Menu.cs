using Entidades;
using Logica;
namespace Tienda
{
    public partial class Menu : Form
    {
        private LogicaProductos _manejadorProductos;
        private bool guardando = true;
        private int ID = 0;
        public Menu()
        {
            InitializeComponent();
            _manejadorProductos = new LogicaProductos();

        }


        private void LlenarProducto(string valor)
        {
            DvProductos.DataSource = _manejadorProductos.ObtenerProducto(valor);
        }

        public void GuardarProducto()
        {

            Productos entidadesProducto = new Productos();

            entidadesProducto.Id = 0;
            entidadesProducto.Nombre = TxtNombre.Text;
            entidadesProducto.Descripcion = TxtDescripcion.Text;
            entidadesProducto.Precio = double.Parse(TxtPrecio.Text);

            var validar = _manejadorProductos.ValidarDatosProducto(entidadesProducto);

            if (validar.Item1)
            {
                _manejadorProductos.GuardarProducto(entidadesProducto);
                LlenarProducto("");
                LimpiarCuadro();
                ControlarBotones(true, false, false);
                ControlCuadros(false);
            }
            else
            {
                MessageBox.Show(validar.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void ControlarBotones(Boolean nuevo, Boolean guardar, Boolean eliminar)
        {
            BtnAgregar.Enabled = nuevo;
            BtnSobreescribir.Enabled = guardar;
            BtnEliminar.Enabled = eliminar;
        }

        private void ControlCuadros(Boolean estado)
        {
            TxtNombre.Enabled = estado;
            TxtDescripcion.Enabled = estado;
            TxtPrecio.Enabled = estado;
        }

        private void LimpiarCuadro()
        {
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            TxtPrecio.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (guardando)
            {
                GuardarProducto();
            }
            else
            {

            }

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ControlarBotones(true, true, false);
            ControlCuadros(true);
            LlenarProducto("");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlarBotones(true, true, false);
            ControlCuadros(true);
            TxtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlarBotones(false, false, true);
            ControlCuadros(true);
            LimpiarCuadro();
        }
    }
}