using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUnidad3.Modelo.campeonato
{
    class Cancha
    {
        //Propidedadsee de la clase
        private int _id;
        private string tipo;//Soccer, Futbol 7
        private string _nombre;
        private string _ubicacion;
        
        //Metodos Getter's y Setter's
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Ubicacion { get; set; }

    }
}
