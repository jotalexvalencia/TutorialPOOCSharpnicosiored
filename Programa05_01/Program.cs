using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // ejemplo de agregación

            // creamos al propietario

            CPropietario Juan= new CPropietario("Juan");

            // Creamos la propiedad

            CEdificio edif1 = new CEdificio("Av. 1 num 56", 10, 3);

            // Vemo info del propietario
            Juan.MostrarPropiedad();


            // le colocamos la propiedad
            Juan.AdicionaPropiedad(edif1);
            Juan.MostrarPropiedad();

            // Eliminamos a Juan
            Juan = null;
            GC.Collect();
           // Juan.MostrarPropiedad();

            Console.WriteLine("-----");

            // verificamos que el edif exista indep de juan
            edif1.Muestra();
        }
    }
}
