using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_03
{
    class CBecario:CPersona
    {
        private int horasBeca;

        public CBecario(string pNombre, int pEdad, int pHoras) : base(pNombre, pEdad)
        {
            horasBeca = pHoras;
        }

        public int HorasBeca
        {
            get { return horasBeca; }
            set { horasBeca = value; }
        }

        public void MuestraBecario()
        {
            Console.WriteLine("Cantida de horas: {0}", horasBeca);
        }
    }
}
