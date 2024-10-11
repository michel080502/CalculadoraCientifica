using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCientifica
{
    internal class Potencia
    {
        public double oper_potencia(double num1, double num2)
        {
            double res = 0;
            res = Math.Pow(num1,num2);
            return res;
        }
    }
}
