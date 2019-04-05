using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUnidad3.Modelo.campeonato
{
    class Campeonato
    {
        private int _id;
        private string _nombre;
        private DateTime _fechainicio;
        private List<Jornada> _jornadas;

        public int ID {get;set;}
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public  List<Jornada>  Jornadas { get; set; }
        public override string ToString()
        {
            return ID + "|" + Nombre + "|" + FechaInicio.ToString("dd/MM/yyyy") + "|" + FechaFin.ToString("dd/MM/yyyy");
        }
    }
}
