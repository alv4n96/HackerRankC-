using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Easy
{
    internal class AppleAndOrange
    {

        public static void Run()
        {
            //-----------------hackerrank

            //string case1 = "haveaniceday";
            List<int> apple = new List<int>() { -2, 2, 1 };
            List<int> orange = new List<int>() { 5, -6 };

            //var res = countApplesAndOranges(1, 1, 1, 1, case1, case1);

            //foreach (int r in res) Console.WriteLine(r);

            CountApplesAndOranges(7, 11, 5, 15, apple, orange);

            //Console.WriteLine(res);
        }

        private static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int resApple = 0, resOrange = 0;

            for (int i = 0; i < apples.Count; i++)
                if (((apples[i] + a)>= s) && ((apples[i] + a)<= t)) resApple++;
            for (int i = 0; i < oranges.Count; i++)
                if (((b + oranges[i]) >= s) && ((b + oranges[i]) <= t)) resOrange++;

            Console.WriteLine(resApple);
            Console.WriteLine(resOrange);
        }

    }
}
