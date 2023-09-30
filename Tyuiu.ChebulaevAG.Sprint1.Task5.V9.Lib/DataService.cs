using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChebulaevAG.Sprint1.Task5.V9.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            if (f < 0 || f >= 360)
            {
                throw new ArgumentException("Угол должен быть в диапазоне от 0 до 360 градусов (не включительно).");
            }

            int h = (int)(f / 30.0);

            return h;
        }
    }
}
