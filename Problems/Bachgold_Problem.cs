/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Bachgold Problem
 * Problem-Link : https://codeforces.com/problemset/problem/749/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine()),result=0,index=2;
            string primes = "";
            if (n != 1) {
                while (n != 0) {
                    if (IsPrime(index) && n-index!=1) {
                        n -= index;
                        result++;
                        primes += $"{index} ";
                    } else {
                        index++;
                    }
                }
                Console.WriteLine(result);
                Console.WriteLine(primes);
            }
        }

        static private bool IsPrime(int x) {
            if ((x != 2 && x % 2 == 0) || x == 1)
                return false;
            for(int i = 2; i < x / 2; i++) {
                if (x % i == 0)
                    return false;
            }
            return true;
        }


    }
}
