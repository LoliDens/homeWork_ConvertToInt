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
            int number = CreateAndConvertNumber();
            Console.WriteLine($"Введенное вами число - {number}");
            Console.ReadKey();
        }

        static int CreateAndConvertNumber() 
        {
            int result;
            
            Console.Write("Введите чило: ");
            string numberForConvert = Console.ReadLine();

            while (int.TryParse(numberForConvert, out result) == false) 
            {
                Console.Write("Число введено неверно\nВведите число повторно:");
                numberForConvert = Console.ReadLine();
            }

            return result;
        }
    }
}
