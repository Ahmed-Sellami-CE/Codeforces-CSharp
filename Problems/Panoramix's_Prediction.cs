/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Panoramix's Prediction
 * Problem-Link : https://codeforces.com/problemset/problem/80/A
*/

using System;
using System.Text.RegularExpressions;
namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n, m;
            Match match = Regex.Match(Console.ReadLine(),@"(\d+)\s(\d+)");
            n = Convert.ToInt32(match.Groups[1].Value);
            m = Convert.ToInt32(match.Groups[2].Value);
            n += 1;
            while (!Prime(n))
                n++;
            
            Console.WriteLine(n==m?"YES":"NO");
        }
        private static bool Prime(int x) {
            if (x <= 1)
                return false;
            for(int i = 2; i < x; i++) {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
    }
}
