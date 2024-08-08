/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Chips
 * Problem-Link : https://codeforces.com/problemset/problem/92/A
*/

using System;
using System.Text.RegularExpressions;
namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n, m, index;
            Match match = Regex.Match(Console.ReadLine(), @"(\d+)\s(\d+)");
            n = Convert.ToInt32(match.Groups[1].Value);
            m = Convert.ToInt32(match.Groups[2].Value);
            index = 1;
            while (m>=index) {
                m -= index;
                index = index == n ? 1 : index + 1;
            }
            Console.WriteLine(m);
        }
    }
}
