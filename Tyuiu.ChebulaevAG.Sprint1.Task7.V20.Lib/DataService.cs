using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChebulaevAG.Sprint1.Task7.V20.Lib
{
    public class DataService : ISprint1Task7V20
    {
        public double Calculate(double x, double y)
        {
            double a = Math.Pow(Math.Cos(x + y), 2);
            double b = 1 + Math.Abs(x - (3 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2)));
            double result = (2 + a) / b + (x * y);
            return Math.Round(result, 3);
        }
    }
}
