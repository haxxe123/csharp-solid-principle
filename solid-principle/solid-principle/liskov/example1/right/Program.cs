using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.liskov.example1.right
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            Calculator sum = new SumCalculator(numbers); // Calculator can replace SumCalculator LISKOV ok
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
            Console.WriteLine();
            Calculator evenSum = new EvenNumbersSumCalculator(numbers); // Calculator can replace EvenNumbersSumCalculator LISKOV ok
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

            // Results:
            // The sum of all the numbers: 40
            // The sum of all the even numbers: 18
        }
    }
}
