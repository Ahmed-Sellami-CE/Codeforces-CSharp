/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Taymyr is calling you
 * Problem-Link : https://codeforces.com/problemset/problem/764/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            Match match = Regex.Match(input,@"^(\d+)\s(\d+)\s(\d+)$");
            int n = Convert.ToInt32(match.Groups[1].Value),
                m = Convert.ToInt32(match.Groups[2].Value),
                z = Convert.ToInt32(match.Groups[3].Value);
            Console.WriteLine(z/(n*m/((n!=1&&m!=1)?Gcd(n>=m?n:m,n<=m?n:m):1)));
        }

        private static int Gcd(int n,int m) {
            if (n % m == 0)
                return m;
            return Gcd(m,n%m);
        }
    }
}
