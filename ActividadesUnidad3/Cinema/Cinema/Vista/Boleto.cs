using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Vista
{
    class Boleto
    {
        private int _folio;
        private DateTime _fecha;
        private int _asiento;
        private double _costo;

        public int Folio
        {
            get
            {
                return _folio;
            }
            set
            {
                _folio = value;
            }
        }
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
        public int Asiento
        {
            get
            {
                return _asiento;
            }
            set
            {
                _asiento = value;
            }
        }
        public double Costo
        {
            get
            {
                return _costo;
            }
            set
            {
                _costo = value;
            }
        }
    }
}
