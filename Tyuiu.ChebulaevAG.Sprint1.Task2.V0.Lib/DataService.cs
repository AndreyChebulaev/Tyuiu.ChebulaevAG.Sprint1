using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChebulaevAG.Sprint1.Task2.V0.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
        }
    }
}
