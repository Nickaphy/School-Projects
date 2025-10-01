/*
 * Writer : Nicklas Christoffersen
 * Date: 19/09/2025
 * Description: A program that takes 2 numbers as inputs and outputs the sum of the two numbers.
 */

namespace DifferenceCalc
{
    class Program
    {
        static void Main()
        {
            var result = 0;
            Console.Write("Whole number: ");
            var number1 = Int32.Parse(Console.ReadLine());
            Console.Write("Whole number: ");
            var number2 = Int32.Parse(Console.ReadLine());

            for (var number_count = number1; number_count <= number2; number_count++)
            {
                result = result + number_count;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The sum of the numbers between {number1} and {number2} is {result}");
        }
    }
}