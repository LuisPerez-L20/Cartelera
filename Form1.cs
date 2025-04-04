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
            if (Cat.EliminarCartelera(Convert.ToInt32(btnEliminar.Text)))
                MessageBox.Show("Pelicula eliminada con exito...");

            else
                MessageBox.Show("La pelicula fallo su eliminacion...");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ModelCartelera nuevapelicula = new ModelCartelera(txbNombre.Text, txbGenero.Text, Convert.ToInt32(txbAñoestreno.Text), txbPersonajePrincipal.Text);
 

            if (Cat.AgregarCartelera(nuevapelicula))
                MessageBox.Show("Pelicula agregada con exito...");
            else
                MessageBox.Show("La pelicula fallo su insercion...");
        }




    }
}
