/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Reconnaissance
 * Problem-Link : https://codeforces.com/problemset/problem/32/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string input1 = Console.ReadLine();
            Match match = Regex.Match(input1, @"(\d+)\s(\d+)");
            int n = Convert.ToInt32(match.Groups[1].Value);
            long d = Convert.ToInt64(match.Groups[2].Value);
            string input = Console.ReadLine();
            long[] heights = new long[n];
            FillHeights(heights, input);
            int result = 0;
            for(int i = 0; i < n; i++) {
                for(int j = i + 1; j < n; j++) {
                    result += Math.Abs(heights[i] - heights[j]) <= d ? 2 : 0;
                }
            }
            Console.WriteLine($"{result}");
        }

        private static void FillHeights(long[] heights, string input) {
            for (int i = 0; i < heights.Length; i++) {
                heights[i] = input.Contains(' ') ? Convert.ToInt64(input.Substring(0, input.IndexOf(' '))) : Convert.ToInt64(input);
                input = input.Substring(input.IndexOf(' ') + 1);
            }
        }
    }
}
