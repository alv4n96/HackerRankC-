using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Medium
{
    internal class Encryption
    {
        public static void Run()
        {
            //-----------------hackerrank

            //string case1 = "haveaniceday";
            string case2 = "feedthedog";

            var res = EncryptionTest(case2);

            Console.WriteLine(res);
        }

        private static string EncryptionTest(string s)
        {
            string res = "";
            int row = (int)Math.Floor(Math.Sqrt(s.Length));
            int col = (int)Math.Ceiling(Math.Sqrt(s.Length));
            int firstCheck = 0, tempCounter = 0;

            for (int i = 0; i < col; i++)
            {
                if (col * row < s.Length) row = col;
                tempCounter = 0;
                firstCheck = 0;
                if (i != 0) res += " ";
                for (int j = 0; j < row; j++)
                {
                    if (firstCheck == 0)
                    {
                        res += s[i];
                        firstCheck++;
                    }
                    else
                    {
                        tempCounter += col;
                        if ((tempCounter + i) < s.Length) res += s[i + tempCounter];
                        else continue;
                    }
                }
            }


            return res;
        }
    }
}
