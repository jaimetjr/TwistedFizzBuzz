using TwistedFizzBuzzLibrary;

namespace TwistedFizzBuzzTests
{
    public class TwistedFizzBuzzTests
    {
        [Fact]
        public void MultiplesOf3()
        {
            var twistedFizzBuzz = new TwistedFizzBuzz();

            var results = twistedFizzBuzz.OutputFizzBuzz(new TwistedFizBuzzConfig
            {
                FirstNumber = 1,
                LastNumber = 9
            });
            var multiples = results.Where(x => x == "Fizz").Count();
            Assert.Equal(3, multiples);
        }

        [Fact]
        public void MultiplesOf5()
        {
            var twistedFizzBuzz = new TwistedFizzBuzz();

            var results = twistedFizzBuzz.OutputFizzBuzz(new TwistedFizBuzzConfig
            {
                FirstNumber = 1,
                LastNumber = 5
            });
            var multiples = results.Where(x => x == "Buzz").Count();
            Assert.Equal(1, multiples);
        }

        [Fact]
        public void MultiplesOf35()
        {
            var twistedFizzBuzz = new TwistedFizzBuzz();

            var results = twistedFizzBuzz.OutputFizzBuzz(new TwistedFizBuzzConfig
            {
                FirstNumber = 1,
                LastNumber = 9
            });
            var multiples3 = results.Where(x => x == "Fizz").Count();
            Assert.Equal(3, multiples3);
            var multiples5 = results.Where(x => x == "Buzz").Count();
            Assert.Equal(1, multiples5);
        }
    }
}