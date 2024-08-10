/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Watermelon
 * Problem-Link : https://codeforces.com/problemset/problem/4/A
*/

using System;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            bool result = false;
            for(int i = 2; i <= n / 2 && !result; i+=2) {
                result = (n - i) % 2 == 0;
            }
            Console.WriteLine(result ?"YES":"NO");
        }
    }
}
