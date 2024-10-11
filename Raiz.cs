using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCientifica
{
    internal class Raiz
    {
        public double oper_raiz(double num1)
        {
            double res = 0;
            if (num1 < 0)
            { MessageBox.Show("NO SE PUEDE OBTNER UNA RAIZ NEGATIVA"); }
            else
            {
                res = Math.Sqrt(num1);

            }
            return res;
        }
    }
}
