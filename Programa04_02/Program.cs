using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona uno = new CPersona("Maria",27);
            uno.Muestra();
            Console.WriteLine("-----");

            CEmpleado dos = new CEmpleado("Juan", 30, "Contador", 10500.50);
            dos.EmpleadoMuestra();
            Console.WriteLine("-----");

            CEmpleado tres = new CEmpleado("Susana", 25, "Programadora", 150000.30);
            tres.EmpleadoMuestra();
            Console.WriteLine("-----");
            tres.ponerDatos("Susana", 23, "Programadora Senior", 180000.70);
            tres.EmpleadoMuestra();
        }
    }
}
