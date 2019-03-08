using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUnidad3.Modelo.campeonato
{
    class Jugador:Persona
    {
        private string _equipo;
        private int _numero;
        private string _posicion;
        //Enlace con la clase equipo
        private Equipo _equipe;
        //Metodos
        public int Numero { get; set; }
        public string Posicion { get; set; }
        public Equipo Equipe { get; set; }

    }
}
