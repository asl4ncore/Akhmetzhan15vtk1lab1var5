using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment1
    {
        /// <summary>
        /// Периметр треугольника : Если аргументы были вверны , вычисляет значение ,иначе выводит 0 ,
        /// так как условия треугольника не выполнены. 
        /// </summary>
        /// <param name="a">Первое значение</param>
        /// <param name="b">Второе значение</param>
        /// <param name="c">Третье значение</param>
        /// <returns></returns>
        public int TrianglePerimeter (int a,int b,int c)
        {
            if ((a > b + c) || (b > a + c) || (c > a + b))
            { return 0; }
            else
            { return a + b + c; }
        }

    }
}
