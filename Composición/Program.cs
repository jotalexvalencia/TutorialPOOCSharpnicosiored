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
            try
            {
                Casa casa = new Casa("MZ 7 CS 5A");
                casa.AgregarHabitaciones();
                casa.MostrarCasa();

                casa = null;

                casa.MostrarCasa();
            }
            //catch (Exception ex)
            //{
            //    //Console.WriteLine(ex);
            //    throw new System.NullReferenceException("La casa no existe");
            //}
            finally
            {
                Console.WriteLine("La casa no existe");
                Console.WriteLine("Fin del programa");
            }
        }
    }
}
