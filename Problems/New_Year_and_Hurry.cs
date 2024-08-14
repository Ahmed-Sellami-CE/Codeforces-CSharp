/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. New Year and Hurry
 * Problem-Link : https://codeforces.com/problemset/problem/750/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            Match match = Regex.Match(input,@"^(\d+)\s(\d+)$");
            int n = Convert.ToInt32(match.Groups[1].Value),
                k = Convert.ToInt32(match.Groups[2].Value),
                timeTaken=0,i=0;
            while (n!=0 && timeTaken + 5*i <= 240 - k) {
                timeTaken += 5 * i;
                i++;
            }
            Console.WriteLine(i-1>=n?n:i-1);

        }
    }
}
