using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular motorola = new Celular();
            motorola.NombreCelular = "Motorola G6 Play";
            motorola.Precio = 700000.50;

            Celular lg = new Celular();
            lg.NombreCelular = "LG g4";
            lg.Precio = 900000.50;            

            Propietario prop1 = new Propietario();
            prop1.Nombre = "Alex";
            prop1.Apellido = "Valencia";
            prop1 = null;
            lg.AgregarPropietario(prop1);
            
            GC.Collect();
            lg.MostrarCelular();

            

            
        }
    }
}
