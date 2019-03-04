using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUnidad3.Modelo
{
    class Estudiante
    {
        public byte edad { get; set; }
        public string genero { get; set; }
        public string nombre { get; set; }
        public long numeroControl { get; set; }
        public void Estudiar(String texto)
        {
            //Metodo para estudiar.
        }//fin del metodo Estudiar
        public void HacerTarea(String tema)
        {
            //Metodo que hacer tarea
        }//Fin de metodo hacer tarea
    }
}
