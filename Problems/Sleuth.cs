/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Sleuth
 * Problem-Link : https://codeforces.com/problemset/problem/49/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            Match match = Regex.Match(Console.ReadLine(),@"^.*([a-zA-z]).*?");
            char c = Convert.ToChar(match.Groups[1].Value);
            Console.WriteLine(c == 'A' || c == 'a' || c == 'E' || c == 'e' || c == 'O' || c == 'o' || c == 'U' || c == 'u' || c == 'Y' || c == 'y' ?"YES":"NO");
        }
    }
}
