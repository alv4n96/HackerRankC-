using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Easy
{
    internal class SubarrayDivision
    {
        public static void Run()
        {
            //-----------------hackerrank
            List<int> s = new List<int>() { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 };
            //List<int> s = new List<int>() { 3 };
            int d = 18, m = 7;


            int res = Solve(s, d, m);
            Console.WriteLine(res);

        }

        private static int Solve(List<int> s, int d, int m)
        {
            
            int sumChoc= 0, counter=0, checker=0;


            if(s.Count == 1)
            {
                if (d == s[0]) counter++;
            } 
            else
            {
                for (int i = 0; i < s.Count; i++)
                {
                    for (int j = 0; j < m; j++) if(i+j < s.Count)
                        {
                            sumChoc += s[i + j];
                            checker++;
                        }
                        else break;
                    if (d == sumChoc && checker == m)counter++;
                    checker = 0;
                    sumChoc = 0;
                }
            }
            return counter;
        }
    }
}
