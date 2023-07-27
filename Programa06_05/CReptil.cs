using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_05
{
    class CReptil
    {
        private string nombre;

        public string Nombre { get {  return nombre; } set {  nombre = value; } }

        public void Moverse()
        {

            Console.WriteLine("El reptil {0} se arrastra", nombre);
        }
    }
}
