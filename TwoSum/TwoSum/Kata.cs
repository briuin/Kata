using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    
    public class Kata
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var indexNums = nums.Select((num, index) => new { num, index });
            return indexNums.Where(x => indexNums.Where(y => x.index != y.index && x.num + y.num == target).Any()).Select(x => x.index).ToArray();
        }

        static void Main(string[] args)
        {
        }
    }
}
