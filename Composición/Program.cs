using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composición
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Casa casa = new Casa("MZ 7 CS 5A");
            casa.AgregarHabitaciones();
            casa.MostrarCasa();

            casa = null;



        }
    }
}
