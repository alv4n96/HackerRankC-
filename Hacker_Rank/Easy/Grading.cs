using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Easy
{
    internal class Grading
    {

        public static void Run()
        {
            //-----------------hackerrank

            //string case1 = "haveaniceday";
            List<int> case1 = new List<int>() {73, 67, 38, 33};

            var res = GradingStudents(case1);

            foreach (int r in res) Console.WriteLine(r);

            //Console.WriteLine(res);
        }

        private static List<int> GradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();

            foreach (int grade in grades)
                if (grade > 37 && (5 * ((grade - 1 ) / 5 + 1) - grade < 3))
                {
                    result.Add(5 * ((grade - 1) / 5 + 1));
                } 
                else
                {
                    result.Add(grade);
                }

            return result;

        }
    }
}
