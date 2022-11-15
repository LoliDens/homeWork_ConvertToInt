using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_ConvertToInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = TryConvert();
            Console.WriteLine($"Введенное вами число - {number}");
            Console.ReadKey();
        }

        static int TryConvert() 
        {
            int result;
            string numberForConvert;

            Console.Write("Введите чило: ");
            numberForConvert = Console.ReadLine();

            while (int.TryParse(numberForConvert, out result) == false) 
            {
                Console.Write("Число введено неверно\nВведите число повторно:");
                numberForConvert = Console.ReadLine();
            }

            return result;
        }
    }
}
