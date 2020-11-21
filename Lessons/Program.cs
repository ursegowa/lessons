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
            Console.WriteLine("Введи трёхзначное число: ");
            var input = Console.ReadLine();
            var number = 0;
            Int32.TryParse(input, out number);
            Console.WriteLine(number);
            var hundreds = number / 100;
            var decades = (number / 10) % 10;
            var units = number % 10;
            Console.WriteLine("{0}{1}{2}", units, decades, hundreds);
            Console.ReadKey();
        }
    }
}
