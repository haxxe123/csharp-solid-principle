using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.liskov.example1.wrong
{
    public class Program
    {
        public void Main()
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            SumCalculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
            Console.WriteLine();
            EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

            // Result:
            // The sum of all the numbers: 40
            // The sum of all the even numbers: 18

            SumCalculator anotherEvenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {anotherEvenSum.Calculate()}");

            // Result:  --> LISKOV Violated => we should be able to replace EvenNumbersSumCalculator by SumCalculator and have the same results !
            // The sum of all the ven numbers: 18
        }
    }
}
