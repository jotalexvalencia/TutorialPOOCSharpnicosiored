using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto de la clase CPersona
            CPersona uno = new CPersona();
            uno.Nombre = "Maria";
            uno.Edad = 27;

            uno.Muestra();
            Console.WriteLine("-----");

            // Creamos un objeto de la clase CEmpleado
            CEmpleado dos = new CEmpleado();

            dos.Nombre = "Juan";
            dos.Edad = 30; 
            dos.Puesto = "Contador";
            dos.Salario = 10500.50;
            dos.EmpleadoMuestra();
            dos.Muestra();
            Console.WriteLine("-----");
            CEmpleado tres = new CEmpleado();
            tres.ponerDatos("Susana", 25, "Programadora", 150000.30);
            tres.EmpleadoMuestra();


        }
    }
}
