using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Vista
{
    class Pelicula
    {
        private int _id;
        private string _nombre;
        private string _director;
        private string _clasificaion;
        private string _resumen;
        public Pelicula()
        {
            _clasificaion = "A";
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Director { get; set; }
        public string Clasificaion { get; set; }
        public string Resumen { get; set; }
    }
}
