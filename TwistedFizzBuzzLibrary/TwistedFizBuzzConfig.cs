using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistedFizzBuzzLibrary
{
    public class TwistedFizBuzzConfig
    {
        public int FirstNumber { get; set; }
        public int LastNumber { get; set; }
        public int TokenANumber { get; set; } = 3;
        public string TokenA { get; set; } = "Fizz";
        public int TokenBNumber { get; set; } = 5;
        public string TokenB { get; set; } = "Buzz";
        public string TokenAB { get; set; } = "FizzBuzz";
        public bool UsesBar { get; set; } = false;
        public int TokenBarNumber { get; set; } = 27;
        public string TokenBar { get; set; } = "Bar";

    }
}
