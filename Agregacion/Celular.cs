using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Celular
    {
        public string NombreCelular { get; set; }        

        public double Precio { get; set; }

        private Propietario propietario;

        public void AgregarPropietario (Propietario pPropietario)
        {
            propietario = pPropietario;
        }

        public void MostrarCelular()
        {
            

            if(propietario != null)
            {
                Console.WriteLine(String.Format("Dueño : {0} {1} con Smartphone: {2} ${3}", propietario.Nombre, propietario.Apellido,NombreCelular,Precio));
            }
            else
            {
                Console.WriteLine("Celular sin dueño: {0} valor: {1}", NombreCelular, Precio);
            }
        }


    }
}
