using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado uno = new CEmpleado("Susana", 25, "Programadora", 150000.30);
            uno.EmpleadoMuestra();
            Console.WriteLine("-----");

            //uno.Edad = 35;

            uno.ponerDatos("Susana", 15, "Programadora Senior", 180000.70);
            uno.EmpleadoMuestra();
        }
    }
}
