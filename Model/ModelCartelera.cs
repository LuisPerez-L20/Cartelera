using Model.Cartelera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cartelera
{
    public class ModelCartelera
    {
        public int idpelicula { get; set; }
        public string? Nombre { get; set; }
        public string? Genero { get; set; }
        public DateTime Añoestreno { get; set; } 
        public string? PersonajePrincipal { get; set; }

   
        public ModelCartelera(int idpelicula, string? nombre, string? genero, DateTime añoestreno, string? personajePrincipal)
        {
            this.idpelicula = idpelicula;
            Nombre = nombre;
            Genero = genero;
            Añoestreno = añoestreno;
            PersonajePrincipal = personajePrincipal;
        }
    }

}
