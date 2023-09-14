using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistedFizzBuzzLibrary
{
    public class TwistedFizzBuzz
    {
        public List<string> OutputFizzBuzz(TwistedFizBuzzConfig config)
        {
            List<string> result = new List<string>();

            for (int i = config.FirstNumber; i <= config.LastNumber; ++i)
            {
                if (i % config.TokenANumber == 0 && i % config.TokenBNumber == 0)
                    result.Add(config.TokenAB);
                else if (i % 3 == 0)
                    result.Add(config.TokenA);
                else if (i % 5 == 0)
                    result.Add(config.TokenB);
                else
                    result.Add(i.ToString());

                if (config.UsesBar)
                {
                    if (i % config.TokenBarNumber == 0)
                        result.Add(config.TokenBar);
                }

            }

            return result;
        }
    }
}
