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


namespace WriteInBallots
{
    public class Result
    {

        /*
         * Complete the 'writeIn' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING_ARRAY ballot as parameter.
         */

        public static string writeIn(List<string> ballot)
        {

            int count = 0;
            int max = 0;
            string output = "";
            ballot.Sort();
            Dictionary<string, int> d = new Dictionary<string, int>();
            List<string> names = new List<string>();
            foreach (string str in ballot)
            {
                if (d.ContainsKey(str))
                {
                    d[str] = d[str] + 1;
                }
                else
                    d.Add(str, 1);
            }
            int maxValueInDictionary = 0;
            foreach (var item in d)
            {
                string key = item.Key;
                int votes = item.Value;
                if (votes > maxValueInDictionary)
                {
                    maxValueInDictionary = votes;
                    output = key;
                }
                else if (votes == maxValueInDictionary && key.CompareTo(output) > 0)
                {
                    output = key;
                }
            }
            var items = from pair in d
                        orderby pair.Value descending
                        select pair;

            /*        names.Add(items.First().Key);
                    max = items.First().Value;
                    foreach (var item in items)
                    {
                        if (names.Contains(item.Key))
                        {

                        }
                        else
                        {
                            if (item.Value == max)
                            {
                                names.Add(item.Key);
                            }
                        }
                    }
                    names.Sort();
                    return names[names.Count - 1];
                }*/
            return output;
        }
    }


    class Solution
    {
        public static void Main(string[] args)
        {
            /*      TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                  int ballotCount = Convert.ToInt32(Console.ReadLine().Trim());

                  List<string> ballot = new List<string>();

                  for (int i = 0; i < ballotCount; i++)
                  {
                      string ballotItem = Console.ReadLine();
                      ballot.Add(ballotItem);
                  }*/
            List<string> ballot = new List<string>();
            string result = Result.writeIn(ballot);

          /*  textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}