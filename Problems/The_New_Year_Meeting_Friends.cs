/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. The New Year: Meeting Friends
 * Problem-Link : https://codeforces.com/problemset/problem/723/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            Match match = Regex.Match(input,@"^(\d+)\s(\d+)\s(\d+)$");
            int x1 = Convert.ToInt32(match.Groups[1].Value),
                x2 = Convert.ToInt32(match.Groups[2].Value),
                x3 = Convert.ToInt32(match.Groups[3].Value),
                minimum = (x1>=x2 && x1<=x3)||(x1>=x3 && x1<=x2)?x1: (x2 >= x1 && x2 <= x3) || (x2 >= x3 && x2 <= x1)?x2:x3;
            Console.WriteLine(Math.Abs(x1-minimum)+Math.Abs(x2 - minimum)+Math.Abs(x3 - minimum));
        }
    }
}
