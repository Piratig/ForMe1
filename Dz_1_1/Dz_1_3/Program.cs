using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в метрах = ");
            int meter = int.Parse(Console.ReadLine());
            meter /= 1000;
            Console.WriteLine("{0} киллометров.", meter);
            Console.ReadLine();
        }
    }
}
