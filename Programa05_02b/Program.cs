using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_02b
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos la escuela
            CEscuela miEscuela = new CEscuela("Nicosiored");

            // creamos los objetos de aula, que existen adentro de escuela
            miEscuela.ColocoAulas();

            // mostramos el objeto compuesto
            Console.WriteLine(miEscuela);

            // si eliminamos la instancia no hay forma de tener las aulas
            miEscuela = null;
        }
    }
}
