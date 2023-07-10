using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Propietario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
               
        public void MostrarPropietario() {
            Console.WriteLine(String.Format("Propietario: {0} {1}",Nombre,Apellido));
        }
    }
}
