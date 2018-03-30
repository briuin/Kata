using System;
using System.Collections.Generic;
using System.Linq;

namespace NextSmallerNumber
{
    public enum NextSmallerNumberError{
        CannotFound = -1
    }
    public class Kata
    {
        public static int GetNextSmallerNumber(int input)
        {
            if (IsSingleDigit(input)) return (int) NextSmallerNumberError.CannotFound;

            var inputString = input.ToString().Reverse().ToArray();
            if(IsTwoDigit(input))
            {
                return (inputString[0] < inputString[1]) ? ParseCharArrayToInt(inputString): (int) NextSmallerNumberError.CannotFound;
            }

            for (var index = 0; index < inputString.Length ; index++)
            {
                for (var subArrayElementLength = 2; subArrayElementLength < inputString.Length - index  ; subArrayElementLength++)
                {
                    var subArray = new ArraySegment<char>(inputString, index, subArrayElementLength);
                    if (inputString[index] == subArray.Max()) continue;

                    Swap(inputString, index, subArrayElementLength-index-1);
                    GenerateSubArrayMaxValue(subArrayElementLength, index, inputString);
                    return GenarateResult(inputString);
                }
            }

            return GenarateResult(inputString) == input? (int) NextSmallerNumberError.CannotFound : GenarateResult(inputString);
        }

        private static void GenerateSubArrayMaxValue(int subArrayElementLength, int index, char[] inputString)
        {
            for (var i = subArrayElementLength - index - 1; i >= 0; i--)
            {
                if (inputString[index] < inputString[i])
                {
                    Swap(inputString, index, i);
                }
            }
        }

        private static void Swap(char[] inputString, int i, int k)
        {
            var temp1 = inputString[i];
            inputString[i] = inputString[k];
            inputString[k] = temp1;
        }

        private static bool IsSingleDigit(int input)
        {
            return input < 10;
        }

        private static bool IsTwoDigit(int input)
        {
            return input >= 10 && input < 100;
        }

        private static int GenarateResult(char[] array)
        {
            return ParseCharArrayToInt(array.Reverse());
        }

        private static int ParseCharArrayToInt(IEnumerable<char> array)
        {
            return int.Parse(string.Join("", array));
        }
    }
}