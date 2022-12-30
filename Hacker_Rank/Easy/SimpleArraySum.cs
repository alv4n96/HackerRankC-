using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Easy
{
    internal class SimpleArraySum
    {
        public static void Run()
        {
            //-----------------hackerrank
            List<int> ar = new List<int>() { 1, 2, 3, 4, 10, 11 };


            int res = simpleArraySumTest(ar);
            Console.WriteLine(res);

        }

        public static int simpleArraySumTest(List<int> ar)
        {
            int total = 0;
            foreach (int a in ar) total += a;
            return total;
        }
    }
}
