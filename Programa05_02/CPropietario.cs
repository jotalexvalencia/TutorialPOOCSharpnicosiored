using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_02
{
    class CPropietario
    {
        private string nombre;
        private CEdificio propiedad = null;

        public CPropietario(string pNombre)
        {
            nombre = pNombre;
            propiedad = new CEdificio("Av 2 número 32",7,4);            
        }

        public void MostrarPropiedad()
        {
            if (propiedad != null)
            {
                Console.WriteLine("{0} tiene", nombre);
                propiedad.Muestra();
            }
            else
                Console.WriteLine("{0} aún no tiene propiedades", nombre);
        }

        //// Cuidado con esro, rome el encapsulamiento
        //public CEdificio Propiedad
        //{
        //    get { return propiedad; }
        //    set { propiedad = value; }
        //}
    }
}
