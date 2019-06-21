using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace ArrayLeftRotation.ArrayLeftRotate.CoinMatch
{
    class Solution
    {
        
        // Complete the getWays function below.
        //Idea is: if you need 8 cents, you either have 5 cent in your solution or you don't
        static long getWays(long n, long m,long[] c)
        {
            if (n == 0)
            {
                return 1;
            }
           if (n < 0)
            {
                return 0;
            }
           if (m <= 0 && n >0)
            {
                return 0;
            }
            return getWays(n - c[m - 1], m, c) + getWays(n, m - 1, c);

        }

        static void Main(string[] args)
        {
     //       TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            long[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt64(cTemp))
            ;
            // Print the number of ways of making change for 'n' units using coins having the values given by 'c'

            long ways = getWays(n, m,c);
            Console.WriteLine(ways.ToString());

       //     textWriter.Flush();
       //     textWriter.Close();
        }
    }


}
