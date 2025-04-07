using Controller.Cartelera;
using Model.Cartelera;

namespace Cartelera
{
    public partial class Form1 : Form
    {
        ControllerCartelera Cat = new ControllerCartelera();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgDatos.DataSource = null;
            dgDatos.DataSource = Cat.ObtenerCartelera();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Cat.EliminarCartelera(Convert.ToInt32(txbeliminar.Text)))

                MessageBox.Show("Pelicula eliminada con exito...");

            else
                MessageBox.Show("La pelicula fallo su eliminacion...");

        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Cat.AgregarCartelera(new ModelCartelera(txbNombre.Text, txbGenero.Text, Convert.ToInt32(txbAñoestreno.Text), txbPersonajePrincipal.Text)))
            {
                MessageBox.Show("Pelicula agregada con exito...");
            }
            else
            {
                MessageBox.Show("La pelicula fallo su insercion...");
            }   
        }
    }
}
