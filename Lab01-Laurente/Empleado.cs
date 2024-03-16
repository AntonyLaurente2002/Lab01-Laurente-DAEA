using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Laurente
{
    public class Empleado : Persona
    {
        public double Sueldo { get; set; }

        public double CalcularImpuesto(double impuesto)
        {
            return Sueldo * impuesto / 100;
        }

    }
}

