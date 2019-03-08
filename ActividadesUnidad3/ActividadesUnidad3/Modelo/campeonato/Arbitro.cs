using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUnidad3.Modelo.campeonato
{
    class Arbitro:Persona
    {
        //Atributos
        private int _aniosExperiencia;
        private bool tieneGafete;
        //Metodos Getter's y Setter's
        public int AniosExperiencia { get; set; }       
        public int TieneGafete { get; set; }

    }
}
