using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Vista
{
    class Asiento
    {
        private int _numero;
        private bool _estaDisponible;

        public int Numero {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
             }
        public bool EstaDisponible {

            get
            {
                return _estaDisponible;
            }
            set
            {
                _estaDisponible = value;
            }
                }
    }

}
