using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double promedio;
            if (nota1 == null && nota2 == null && nota3 ==null)
            {
               return 0;
            }

            double suma = 0;
            int cantidad = 0;
            if (nota1 >= 0 && nota1 <= 10) { suma += nota1.Value; cantidad++; }
            if (nota2 >= 0 && nota2 <= 10) { suma += nota2.Value; cantidad++; }
            if (nota3 >= 0 && nota3 <= 10) { suma += nota3.Value; cantidad++; }
            promedio = suma / cantidad;

            return promedio;
        }

    }
}
