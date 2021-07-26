using System;
using System.Collections.Generic;

namespace GetAllSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Hello World!";
            var result = GetAllSubstrings(str);
            Console.WriteLine(string.Join("\n", result));
        }

        private static IList<string> GetAllSubstrings(string inputStr)
        {
            var output = new List<string>();
            for (int i = 1; i < inputStr.Length; i++) {
                for (int start = 0; start <= inputStr.Length - i; start++) {
                    string substr = inputStr.Substring(start, i);
                    output.Add(substr);
                }
            }

            return output;
        }
    }
}