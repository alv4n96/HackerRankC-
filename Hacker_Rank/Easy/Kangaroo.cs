using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Easy
{
    internal class Kangaroo
    {
        public static void Run()
        {
            //-----------------hackerrank


            //foreach (int r in res) Console.WriteLine(r);

            var res = KangarooTest(0, 3, 4, 2);

            Console.WriteLine(res);
        }
        private static string KangarooTest(int x1, int v1, int x2, int v2)
        {
            string res = "";
            int counter = 0;
            //conditional
            if (v2<v1)
            {
                if (counter == 0)
                {
                    x1 += v1;
                    while (x1<x2)
                    {
                        x1 += v1;
                        x2 += v2;
                    }
                }
            }
            else
            {
                res = "v2 lebih besar";
            }


            return res;
        }
    }
}
