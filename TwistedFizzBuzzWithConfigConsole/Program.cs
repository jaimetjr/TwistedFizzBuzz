using TwistedFizzBuzzLibrary;

namespace TwistedFizzBuzzWithConfigConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var twistedFizzBuzz = new TwistedFizzBuzz();

            var words = twistedFizzBuzz.OutputFizzBuzz(new TwistedFizBuzzConfig
            {
                FirstNumber = -20,
                LastNumber = 127,
                TokenANumber = 5,
                TokenA = "Fizz",
                TokenBNumber = 9,
                TokenB = "Buzz",
                UsesBar = true
            });

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}