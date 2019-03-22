using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Vista
{
    class taquillero : Persona
    {
        private int _numeroEmpeado;
        private string _tipo;
        public taquillero() : base()
        {
            _numeroEmpeado = 100;
        }
        
        public int NumeroEmpleado {get; set;}
        public string Tipo { get; set; }
}
}
