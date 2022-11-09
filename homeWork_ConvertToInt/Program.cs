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
            string numberForConvert;
            int number;

            Console.Write("Введите чило: ");
            numberForConvert = Console.ReadLine();

            number = TryConvert(numberForConvert);
            Console.WriteLine($"Введенное вами число - {number}");
            Console.ReadKey();
        }

        static int TryConvert(string number) 
        {
            int result;

            while (int.TryParse(number, out result) == false) 
            {
                Console.Write("Число введено неверно\nВведите число повторно:");
                number = Console.ReadLine();
            }

            return result;
        }
    }
}
