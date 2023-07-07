using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_02b
{
    class CEscuela
    {
        private string nombre;
        private CAulas[] aulas = new CAulas[3];

        public CEscuela(string pNombre)
        {
            nombre = pNombre;
            
        }

        public void ColocoAulas()
        {
            int n = 0;
            string dato = "";
            string nombre = "";
            int cantidad = 0;

            for (n = 0; n < aulas.Length; n++)
            {
                Console.WriteLine("Dame el nombre del aula");
                nombre = Console.ReadLine();

                Console.WriteLine("Dame la cantida de alumnos");
                dato = Console.ReadLine();
                cantidad = Convert.ToInt32(dato);

                aulas[n] = new CAulas(nombre, cantidad);
            }
        }

        public override string ToString()
        {
            string mensaje = "";
            int n = 0;

            mensaje = string.Format("Bienvenidos a la escuela {0}, la cual consta de:\r\n", nombre);
            for (n = 0; n < aulas.Length; n++)
            {
                mensaje += aulas[n].ToString() + "\r\n";
            }
            return mensaje;
        }
    }
}
