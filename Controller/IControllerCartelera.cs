using Model.Cartelera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartelera.Controller
{
    interface IControllerCartelera
    {
        List<ModelCartelera> ObtenerCartelera();

        bool EliminarCartelera(int idpelicula);

        public bool AgregarCartelera(ModelCartelera nuevacartelera);


    }
}
