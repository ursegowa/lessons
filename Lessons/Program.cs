using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введи номер билета: ");
            var input = Console.ReadLine();
            var number = 0;
            Int32.TryParse(input, out number);

            if (number > 99999 && number < 1000000)
            {
                Console.WriteLine(number);
                var partOneNumber = number / 1000;
                var partTwoNumber = number % 1000;
                if (GetSumModuls(partOneNumber) == GetSumModuls(partTwoNumber))
                {
                    Console.WriteLine("Билетик счастливый!");
                }
                else
                {
                    Console.WriteLine("Билетик обычный.");
                }
            }
            else
            {
                Console.WriteLine("Введёное число не соответствует условиям!");
            }
            
            Console.ReadKey();
        }

        static int GetSumModuls(int number)
        {
            var hundreds = number / 100;
            var decades = (number / 10) % 10;
            var units = number % 10;

            return hundreds + decades + units;
        }
    }
}
