﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_05
{
    class CAnimal
    {
        protected string nombre;

        public string Nombre { get { return nombre; } set { nombre = value; } } 

        public virtual void Moverse() {
            Console.WriteLine("El animal se mueve");
        }
    }
}
