/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Nearly Lucky Number
 * Problem-Link : https://codeforces.com/problemset/problem/110/A
*/

using System;
namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            long x = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(IsLucky(Luckys(x)) ?"YES":"NO");
        }
        private static int Luckys(long x) {
            int result = 0;
            while (x != 0) {
                result += (x % 10 == 4 || x % 10 == 7) ?1:0;
                x /= 10;
            }
            return result;
        }
        private static bool IsLucky(int x) {
            if (x == 0)
                return false;
            while (x != 0) {
                if (x % 10 != 4 && x % 10 != 7)
                    return false;
                x /= 10;
            }
            return true;
        }
    }
}
