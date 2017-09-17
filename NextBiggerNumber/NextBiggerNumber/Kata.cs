using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBiggerNumber
{
    public class Kata
    {
        private static void Swap(List<char> list, int index1, int index2)
        {
            var temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        private static int ConvertCharListToInt(List<char> list)
        {
            var result = 0;
            list.ForEach(n => result = result * 10 + (int)Char.GetNumericValue(n));

            return result;
        }

        public static void FindAndSwapLowerNumber(List<char> list)
        {
            for (int i = list.Count - 1; i >= 1; i--)
                for (int j = i - 1; j >= 0; j--)
                    if (list[i] > list[j])
                    {
                        Swap(list, i, j);
                        return;
                    }
        }

        public static int NextBiggerNumber(uint number)
        {
            var charListNumbers = number.ToString().ToList();
            FindAndSwapLowerNumber(charListNumbers);
            var result = ConvertCharListToInt(charListNumbers);
            return result == number ? -1 : result;
        }

        static void Main(string[] args)
        {
        }
    }
}
