﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPD
{
    class FizzBuzz
    {
        public string GetFizzBuzzResult(int input)
        {
            // 3. Jeżeli liczba użytkownika będzie podzielna przez 3 bez reszty, to powinien zostać zwrócony wynik „Fizz”
            if(input%3 == 0) 
            {
                return "Fizz";
            }
            // 4. Jeżeli liczba użytkownika będzie podzielna przez 5 bez reszty, to powinien zostać zwrócony wynik „Buzz”
            if(input%5 == 0) 
            {
                return ""
            }
            // 5. Jeżeli liczba użytkownika będzie podzielna przez 3 i przez 5 jednocześnie bez reszty, to powinien zostać zwrócony wynik „FizzBuzz”

            return "Udało się";
        }
    }
}
