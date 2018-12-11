using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    {
        /// <summary>
        /// Функция получает число и возвращает числа,
        /// которые разделяются на 13
        /// </summary>
        /// <param name="number">конечное число</param>
        /// <returns></returns>
        public IEnumerable<int> GetNumbersDivitedBy13(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 13 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
