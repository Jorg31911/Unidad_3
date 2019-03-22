using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Vista
{
    class Sala
    {
        private int _id;
        private string _nombre;
        private int _capacidad;
        private bool _estaLLena;
        
        //Una sala contiene 200 asientos
        private Asiento[] asientos = new Asiento[200];
   
        public Sala()
        {
            _nombre = "A";
            for(int i=0; i<=199;i++)
            {
                asientos[i] = new Asiento();
                asientos[1].Numero = i + 1;
            }
            
        }
        public int ID {get;set;}
        public string Nombre {get; set; }
        public int Capacidad { get; set; }
        public bool EstaLLena { get; set; }
    }
    }
}
