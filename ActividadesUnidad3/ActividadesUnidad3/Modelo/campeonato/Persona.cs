using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUnidad3.Modelo.campeonato
{
    class Persona
    {
        //Propiedades del equipo
        private int _id;
        private string _nombre;
        private DateTime _fechaN;
        private string _apellidos;
        //Metodos Getter's y Setter's
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaN { get; set; }
        public string Apellidos { get; set; }
    }
}
