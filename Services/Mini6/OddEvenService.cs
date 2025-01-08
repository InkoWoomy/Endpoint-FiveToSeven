using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_FiveToSeven.Services.Mini6
{
    public class OddOrEvenService : IOddOrEvenService
    {
        public string OddOrEven (string num)
        {
            int convertedInput;

            if (int.TryParse(num, out convertedInput))
            {
                if (convertedInput % 2 == 0)
                {
                    return "Your input of '" + convertedInput + "' is an even number.";
                } else {
                    return "Your input of '" + convertedInput + "' is an odd number.";
                }
            } else {
                return "Your input of '" + num + "' is invalid. Please make sure you are inputting an integer.";
            }
        }
    }
}