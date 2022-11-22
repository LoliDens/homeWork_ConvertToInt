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
            int number = ReadNumber();
            Console.WriteLine($"Введенное вами число - {number}");
            Console.ReadKey();
        }

        static int ReadNumber() 
        {
            int result;                
            string numberForConvert = "";

            while (int.TryParse(numberForConvert, out result) == false) 
            {
                Console.Write("Ввдите число:");
                numberForConvert = Console.ReadLine();
            }

            return result;
        }
    }
}
