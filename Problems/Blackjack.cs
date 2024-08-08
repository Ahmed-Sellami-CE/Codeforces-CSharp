/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Blackjack
 * Problem-Link : https://codeforces.com/problemset/problem/104/A
*/

using System;
namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(Cards(Convert.ToInt32(Console.ReadLine()) - 10));
        }
        private static int Cards(int x) {
            return (x<=0 || x>11)?0 : x == 10?15:4;
        }
    }
}
