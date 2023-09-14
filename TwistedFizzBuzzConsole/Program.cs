using TwistedFizzBuzzLibrary;

namespace TwistedFizzBuzzConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var twistedFizzBuzz = new TwistedFizzBuzz();

            var words = twistedFizzBuzz.OutputFizzBuzz(new TwistedFizBuzzConfig
            {
                FirstNumber = 1,
                LastNumber = 100
            });

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}