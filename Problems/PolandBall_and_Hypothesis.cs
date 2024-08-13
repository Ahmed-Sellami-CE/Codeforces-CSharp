/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. PolandBall and Hypothesis
 * Problem-Link : https://codeforces.com/problemset/problem/755/A
*/

using System;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine()),m=1;
            while (IsPrime(n * m + 1))
                m++;
            Console.WriteLine(m);

        }
        private static bool IsPrime(int x) {
            if (x == 1 || (x!=2 && x % 2 == 0))
                return false;
            for(int i = 2; i < x / 2; i++) {
                if (x % i == 0)
                    return false; 
            }
            return true;
        }
    }
}
