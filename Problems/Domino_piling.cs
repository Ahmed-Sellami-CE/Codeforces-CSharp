/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Domino piling
 * Problem-Link : https://codeforces.com/problemset/problem/50/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            Match match = Regex.Match(Console.ReadLine(),@"(\d+)\s(\d+)");
            int M = Convert.ToInt32(match.Groups[1].Value),
                N = Convert.ToInt32(match.Groups[2].Value);
            Console.WriteLine((M*N)/2);
        }
    }
}
