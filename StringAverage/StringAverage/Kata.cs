using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class Kata
    {
        public static string StringAverage(string inputString)
        {
            var numberStrings = new Dictionary<string, int>()
            {
                {"zero",0},
                {"one",1},
                {"two",2},
                {"three",3},
                {"four",4},
                {"five",5},
                {"six",6},
                {"seven",7},
                {"eight",8},
                {"nine",9}
            };

            if (string.IsNullOrEmpty(inputString.Trim()))
                return "n/a";

            var numbers = new List<int>();
            foreach (var value in inputString.Split(' '))
                numbers.Add(numberStrings[value]);

            return numberStrings.FirstOrDefault(x => x.Value == (int)(numbers.Average())).Key;
        }

        static void Main(string[] args)
        {
        }
    }
}
