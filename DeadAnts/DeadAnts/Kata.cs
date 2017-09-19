using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeadAnts
{
    public class Kata
    {
        public static int FindOutDeadAntsCount(string ants)
        {
            int antsAlive = Regex.Matches(ants, "ant").Cast<Match>().Count();
            int antDeadHead = Regex.Matches(ants, "a").Cast<Match>().Count();
            int antDeadBody = Regex.Matches(ants, "n").Cast<Match>().Count();
            int antDeatFoot = Regex.Matches(ants, "t").Cast<Match>().Count();

            return new List<int>{antDeadHead,antDeadBody,antDeatFoot}.Min() - antsAlive;
        }
        static void Main(string[] args)
        {
        }
    }
}
