using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int opcion;

            // sin polimoefismo, queda concreto a la clase
            //Console.WriteLine("Qué mascota quieres? 1-Gato, 2-Reptil");
            //valor = Console.ReadLine();
            //opcion = Convert.ToInt32(valor);

            //if( opcion == 1 )
            //{
            //    CGato migato = new CGato();
            //    migato.Nombre = "Fuzzy";
            //    migato.Moverse();
            //}
            //if( opcion == 2 )
            //{
            //    CReptil mireptil = new CReptil();
            //    mireptil.Nombre = "Lizardo";
            //    mireptil.Moverse();
            //}

            //Console.WriteLine("-----------");

            // con polimorfismo, el código se concentra en el concepto no en la clase
            Console.WriteLine("Qué mascota quieres? 1-perro, 2-pez, 3-ave");
            valor= Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            // Creamos la variable que tendrá polimorfismo
            CAnimal miMascota = new CAnimal();

            // Basado en la selección le damos el comportamiento seleccionado
            if(opcion == 1)
            {
                miMascota = new CPerro();
            }
            if (opcion == 2)
            {
                miMascota = new CPez();
            }
            if (opcion == 3)
            {
                miMascota = new CAve();
            }

            // ahora trabajamos en términos del conceptos Animal y no en terminos de clases especificas
            Console.WriteLine("Dame el nombre");
            miMascota.Nombre = Console.ReadLine();

            miMascota.Moverse();
        }
    }
}
