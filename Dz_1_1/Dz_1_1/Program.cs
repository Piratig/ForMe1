using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1_1
{
    class Program
    {             
        static void Nomber(int nomber)
        {
            char[] arrayNomber = nomber.ToString().ToCharArray();
            for (int i = 0; i < arrayNomber.Length; i++)
            { Console.WriteLine(arrayNomber[i]); }
        }

        static void Main(string[] args)
        {
            int nomber = 0;
            Console.Write("Введите пятизначное число = ");
            try
            {
                nomber = int.Parse(Console.ReadLine());                
            }
            catch
            {
                Console.WriteLine("---Неверный формат ввода!---");
            }

            if (nomber / 10000 >= 1)
            {
                if (nomber / 100000 < 1)
                { Nomber(nomber); }
                else
                { Console.WriteLine("---Число больше требуемого!---"); }
            }  
            else
            { Console.WriteLine("---Число меньше требуемого!---"); }
            Console.ReadLine();
        } 
    }
}
