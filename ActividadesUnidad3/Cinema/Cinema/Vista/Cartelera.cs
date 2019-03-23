using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Vista
{
    class Cartelera
    {
        private int _id;
        private DateTime _fecha;
        private string _horario;
        private string _tipo;
        private double _costo;

        public int id { 
        get
            {
                return _id;
            }
        set
            {
                _id = value;
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
        public string Horario
        {
            get
            {
                return _horario;
            }
            set
            {
                _horario = value;
            }
        }
        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
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
        public Cartelera()
        {
            _tipo = "3D";
        }
    }
    
}
