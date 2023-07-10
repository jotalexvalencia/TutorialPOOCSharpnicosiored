using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composición
{
    public class Habitacion
    {
        public string NombreHabitacion { get; set; }
        public bool TieneBano { get; set; }

        public Habitacion(string nombreHabitacion, bool tieneBano)
        {
            NombreHabitacion = nombreHabitacion;
            TieneBano = tieneBano;
        } 

    }
}
