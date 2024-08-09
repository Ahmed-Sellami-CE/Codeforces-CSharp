/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Triangular numbers
 * Problem-Link : https://codeforces.com/problemset/problem/47/A
*/

using System;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsSquare(8*p+1)?"YES":"NO");
        }
        static private bool IsSquare(int x) {
            for(int i = 1; i <= x / 2; i++) {
                if (i * i == x)
                    return true;
            }
            return false;
        }
    }
}
