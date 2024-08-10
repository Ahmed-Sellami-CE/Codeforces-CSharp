/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Reconnaissance 2
 * Problem-Link : https://codeforces.com/problemset/problem/34/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            int[] heights = new int[n];
            FillHeights(heights, input);
            int minimal = heights.Length > 1 ? Math.Abs(heights[0] - heights[1]):0,index1= heights.Length > 1 ? 1: 0, index2= heights.Length > 1 ? 2 : 0;
            for(int i = 0; i < n-1; i++) {
                    if (Math.Abs(heights[i] - heights[i+1]) < minimal) {
                        minimal = Math.Abs(heights[i] - heights[i+1]);
                        index1 = i + 1;
                        index2 = i + 2;
                    }
            }
            Console.WriteLine(Math.Abs(heights[n - 1] - heights[0])<minimal ?$"{n} 1": $"{index1} {index2}");
        }

        private static void FillHeights(int[] heights,string input) {
            for(int i = 0; i < heights.Length; i++) {
                heights[i] = input.Contains(' ') ? Convert.ToInt32(input.Substring(0, input.IndexOf(' '))) : Convert.ToInt32(input);
                input = input.Substring(input.IndexOf(' ')+1);
            }
        }
    }
}
