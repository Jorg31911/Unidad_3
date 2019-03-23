using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Vista
{
    class Reservacion
    {
        private DateTime _fecha;
        private string _numeroTarjeta;

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }
        public string NumeroTarjeta
        {
            get
            {
                return _numeroTarjeta;
            }
            set
            {
                _numeroTarjeta = value;
            }
        }
    }
}
