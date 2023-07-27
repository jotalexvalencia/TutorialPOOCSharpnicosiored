using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // uso de new en métodos
            // nos permite poner código propio a métodos no virtuales
            // pero perdemos polimorfismo

            CProductoImportado miProducto = new CProductoImportado("Motocicleta", 45000, 0.15);

            miProducto.CalculaPrecio();
            miProducto.MuestraVenta();

            Console.WriteLine("-----");

            CProducto p1 = new CProducto("Television", 10500);
            p1.CalculaPrecio();
            p1.MuestraVenta();

            Console.WriteLine("-----");
            CProducto p3 = new CProductoImportado("Bicicleta", 2200, 0.2);
            p3.CalculaPrecio();
            p3.MuestraVenta();
        }
    }
}
