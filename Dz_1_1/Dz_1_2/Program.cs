using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            ChangeOfRegister(str);
            Console.ReadLine();
        }

        static void ChangeOfRegister(string str)
        {
            str = str.ToUpper();
            Console.WriteLine(str);
        }
    }
}
