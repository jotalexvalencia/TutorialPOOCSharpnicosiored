using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_02
{
    class CEdificio
    {
        private string direccion;
        private int CantDepartamentos;
        private int DepRentados;

        public CEdificio(string pDireccion, int pCantidad, int pRentados)
        {
            direccion = pDireccion;
            CantDepartamentos = pCantidad;
            DepRentados = pRentados;
        }

        public void Muestra()
        {
            Console.WriteLine("Edifico en {0} con {1} deptos, {2} rentados",direccion,CantDepartamentos,DepRentados);
        }
    }
}
