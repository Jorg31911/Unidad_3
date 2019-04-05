using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActividadesUnidad3.Vista;

namespace ActividadesUnidad3
{
    static class Program
    {
        public static  Campeonato2  Campeonato = null;
        public static Jornada Jornada = null;
        public static Main main = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new Main();
            Campeonato = new Campeonato2();
            Jornada = new Jornada();
            Application.Run(new Main());
        }
    }
}
