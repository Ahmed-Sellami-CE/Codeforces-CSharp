/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Petya and Strings
 * Problem-Link : https://codeforces.com/problemset/problem/112/A
*/

using System;
namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string firstString = Console.ReadLine(),
                secondString=Console.ReadLine();
            char c1=' ', c2=' ';
            for(int i = 0; i < firstString.Length; i++) {
                c1 = (firstString[i] >= 65 && firstString[i] <= 90) ? (char)(firstString[i] + 32) : firstString[i];
                c2 = (secondString[i] >= 65 && secondString[i] <= 90) ? (char)(secondString[i] + 32) : secondString[i];
                if (c1 == c2)
                    continue;
                else if (c1 < c2) {
                    Console.WriteLine("-1");
                    break;
                } else {
                    Console.WriteLine("1");
                    break;
                }
            }
            if (c1 == c2)
                Console.WriteLine("0");
        }
    }
}
