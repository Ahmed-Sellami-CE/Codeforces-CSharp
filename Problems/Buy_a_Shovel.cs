/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Buy a Shovel
 * Problem-Link : https://codeforces.com/problemset/problem/732/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            Match match = Regex.Match(input,@"(\d+)\s(\d+)");
            int shovel = Convert.ToInt32(match.Groups[1].Value),
                r = Convert.ToInt32(match.Groups[2].Value),
                shovels = 1;
            while ((shovel * shovels) % 10 != 0 && (shovel*shovels) % 10 != r) {
                shovels++;
            }
            Console.WriteLine(shovels);
        }
    }
}
