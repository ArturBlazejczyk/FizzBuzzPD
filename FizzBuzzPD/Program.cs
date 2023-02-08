using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzzPD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie \"Fizz Buzz\"!");
            GetNumber();    
        }

        private static void GetNumber()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Proszę o podanie liczby: ");

                    if (!int.TryParse(Console.ReadLine(), out int input))
                        throw new Exception();

                    var fizzBuzz = new FizzBuzz();

                    Console.WriteLine(fizzBuzz.GetFizzBuzzResult(input));
                }
                catch (Exception)
                {
                    Console.WriteLine("Podałeś nieprawidłową liczbę.");
                }
            }
        }
    }
}