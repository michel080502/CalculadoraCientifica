using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Divi
    {
        public double oper_divi(double num1, double num2)
        {
            double res = 0;
            if (num2 == 0)
            { MessageBox.Show("NO SE PUEDE DIVIR ENTRE CERO"); }
            else
            {
                res = num1 / num2;

            }

            return res;
        }
    }
}
