using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Casting

            // Podemos hacer casting de una clse en la cadena de herencia
            // CProductoImportado es un CProducto

            CProducto p1 = new CProductoImportado("Tele", 2500, 0.15);

            p1.CalculaPrecio();
            Console.WriteLine(p1);// se ejecuta el método toString()

            // No puede invocar lo que no es comun
            //p1.Mensaje();

            ((CProductoImportado)p1).Mensaje();

            Console.WriteLine("-----");
            // CProducto es un object

            object p2 = new CProducto("Radio", 300);

            ((CProducto)p2).CalculaPrecio();
            Console.WriteLine(((CProducto)p2));

            Console.WriteLine("-----");

            // Object no es un CProducto
            // CProducto p3 = new object();

            Console.WriteLine("----- Detecta -----");
            CProducto p4 = new CProducto("Balon", 250.50);

            Detecta(p1);
            Detecta((CProducto)p2);
            Detecta(p4);

            Console.WriteLine("-----");
            // Casting numericos

            int a = 57;
            float b = 5.67f;
            double c = 123.456;
            byte x = 5;

            // De un tipo menor a uno mayor no hace falta poner explicitamente el casting
            a = x;
            Console.WriteLine(a);

            double y = b;
            Console.WriteLine(y);

            // de un tipo mayor a uno menor
            //b = c;
            b = (float)c;
            Console.WriteLine(b);


        } 

        public static void Detecta(CProducto pProducto)
        {
            if(pProducto is CProducto)
            {
                Console.WriteLine("== Es CProducto");
                pProducto.CalculaPrecio();
                Console.WriteLine(pProducto);
            }
            if(pProducto is CProductoImportado)
            {
                Console.WriteLine("== Es CProductoImportado");
                pProducto.CalculaPrecio();
                ((CProductoImportado)pProducto).Mensaje();
                Console.WriteLine(pProducto);
            }
        }
    }
}
