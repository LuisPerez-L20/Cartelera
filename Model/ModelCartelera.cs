using Model.Cartelera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cartelera
{
    class ModelCartelera
    {
        public ModelCartelera(string? nombre, string? genero, int añoestreno, string? personajePrincipal)
        {
            Nombre = nombre;
            Genero = genero;
            Añoestreno = añoestreno;
            PersonajePrincipal = personajePrincipal;
        }
        public ModelCartelera()
        {
        }
        public int idpelicula { get; set; }
        public string? Nombre { get; set; }
        public string? Genero { get; set; }
        public int Añoestreno { get; set; }
        public string? PersonajePrincipal { get; set; }
       
        
    }
}
