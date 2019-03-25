using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUnidad3.Modelo.campeonato
{
    class Jornada
    {
        private int _id;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private Boolean _isconcluida;

        public int ID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Boolean IsConcluida { get; set; }
    }
}

