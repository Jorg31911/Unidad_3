using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUnidad3.Modelo
{
    class Estudiante
    {
        //Propiedades de la clase
        public string nombre;
        public byte edad;
        public char genero;
        public long numeroControl;
        //Metodos getter's y setter's de las propiedades
        public byte Edad { get; set; }
        public char Genero { get; set; }
        public string Nombre { get; set; }
        public int NumeroControl { get; set; }
        public void Estudiar(String texto)
        {
            return;
            //Metodo para estudiar.
        }//fin del metodo Estudiar
        public void HacerTarea(String tema)
        {
            return;
            //Metodo que hacer tarea
        }//Fin de metodo hacer tarea
    }
}
