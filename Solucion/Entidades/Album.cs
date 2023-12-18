using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumesFinal.Entidades
{
    public class Album
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public DateTime Publicacion { get; set; }
        public int Genero { get; set; }
        public int Discografica { get; set; }
        public string Productor { get; set; }
        public string Duracion { get; set; }
        public bool Vinilo { get; set; }
        public bool Cd { get; set; }
        public bool Casete { get; set; }
        public bool Digital { get; set; }
        public bool Streaming { get; set; }

        public override string ToString()
        {
            return Nombre; 
        }
    }
}
