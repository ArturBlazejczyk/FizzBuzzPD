using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzzPD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie \"Fizz Buzz\"!");
            Console.WriteLine("Proszę o podanie liczby: ");

            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new ArgumentOutOfRangeException();

            var fizzBuzz = new FizzBuzz();

            Console.WriteLine(fizzBuzz.GetFizzBuzzResult(input));

        }
    }
}