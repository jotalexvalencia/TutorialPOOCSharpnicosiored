using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composición
{
    public class Casa
    {
        private string direccion;
        private List<Habitacion> habitaciones;      

        public Casa(string direccion)
        {
            this.direccion = direccion;
            habitaciones = new List<Habitacion>(); // Inicializar la lista

        }



        public void AgregarHabitaciones()
        {
            Console.WriteLine("Dame el número de habitaciones");
            int cantidadHabitaciones = Convert.ToInt32(Console.ReadLine());

            
                
                for (int i = 0; i < cantidadHabitaciones; i++)
                {
                    Console.WriteLine("Dame el nombre de la habitación No {0}", i + 1);
                    string habitacion = Console.ReadLine();
                    Console.WriteLine("Tiene baño [S/N]");
                    string banio = Console.ReadLine();
                    bool conBanio = banio =="S"?true:false;
                    habitaciones.Add(new Habitacion(habitacion, conBanio));
                }
                     
        }

        public void MostrarCasa()
        {

            try
            {
                Console.WriteLine("Casa en {0}", direccion);
                if (habitaciones.Count > 0)
                {
                    foreach (var habitacion in habitaciones)
                    {
                        Console.WriteLine("Habitación: {0} - Tiene baño: {1}", habitacion.NombreHabitacion, habitacion.TieneBano);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("La casa no existe ni sus habitaciones fue destuida anteriormente: " + ex.Message);
            }
        }

        ~Casa()
        {
            direccion = default(string);
            habitaciones.Clear();
        }

    }
}