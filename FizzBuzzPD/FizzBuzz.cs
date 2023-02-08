using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzzPD
{
    class FizzBuzz
    {
        public string GetFizzBuzzResult(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";

            if (input % 3 == 0)
                return "Fizz";

            if (input % 5 == 0)
                return "Buzz";

            return $"{input} nie jest podzielna ani przez 3, ani przez 5.";
        }
    }
}
