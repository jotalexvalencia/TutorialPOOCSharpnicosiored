using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_01
{
    class CEmpleado:CPersona
    {
        private string puesto;
        private double salario;

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public void ponerDatos(string pNombre, int pEdad, string pPuesto, double pSalario)
        {
            Nombre = pNombre; // ojo nos muestra la propieda de la base no el atributo;
            Edad = pEdad;

            puesto = pPuesto;
            salario = pSalario;
        }

        public void EmpleadoMuestra()
        {
            Muestra();
            Console.WriteLine("Trabajo de {0} con sueldo de ${1}", puesto, salario);
        }
    }
}
