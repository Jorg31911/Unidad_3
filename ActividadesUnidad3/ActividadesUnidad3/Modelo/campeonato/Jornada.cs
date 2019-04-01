using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUnidad3.Modelo.campeonato
{
    class Jornada
    {
        //Propiedades de la clase
        private int _id;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private bool _isConcluida;
        //Constructor default
        public Jornada()
        {
            _id = 1;
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0) //Valida el valor Id antes de establecerlo
                    _id = value;
            }
        }
        public DateTime FechaInicio
        {
            get
            {
                return _fechaInicio;
            }
            set
            {
                if (value > DateTime.Today)
                    _fechaInicio = value;
            }
        }
        public DateTime FechaFin
        {
            get
            {
                return _fechaFin;
            }
            set
            {
                if (_fechaFin > _fechaInicio && _fechaFin > DateTime.Today)
                    _fechaFin = value;
            }
        }
        public bool IsConcluida
        {
            get
            {
                return _isConcluida;
            }
            set
            {
                _isConcluida = value;
            }
        }
      //  public override string ToString()
        //{
            //return _id +"|" + _fechaInicio.ToString ("")        }
    }//end Jornada
}


