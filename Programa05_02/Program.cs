using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // cramos el propietario
            CPropietario Ana = new CPropietario("Ana");

            // Mostramos la propiedad
            Ana.MostrarPropiedad();
            Console.WriteLine("-----");

            // Esto Rompe con la encapsulación
            // Tratamos de acceder a la propiedad
            //CEdificio edif = Ana.Propiedad;

            //edif.Muestra();
            Console.WriteLine("-----");

            // Eliminamos el objeto CPropietario
            Ana = null;
            GC.Collect();

            //edif.Muestra();
        }
    }
}
