using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_05
{
    class CPerro:CAnimal
    {
        public override void Moverse()
        {
            Console.WriteLine("El perro {0} camina", nombre);
        }
    }
}
