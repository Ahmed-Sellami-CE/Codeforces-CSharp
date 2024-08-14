/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Compote
 * Problem-Link : https://codeforces.com/problemset/problem/746/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int a = Convert.ToInt32(Console.ReadLine()),
                b = Convert.ToInt32(Console.ReadLine()),
                c = Convert.ToInt32(Console.ReadLine()),
                coefficient = (a<=b/2&&a<=c/4)?a:(b/2<=a&&b/2<=c/4)?b/2:(c/4<=a&&c/4<=b/2)?c/4:0;
            Console.WriteLine(7 * coefficient);
        }
    }
}
