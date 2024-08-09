/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Word
 * Problem-Link : https://codeforces.com/problemset/problem/59/A
*/

using System;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string str = Console.ReadLine();
            Console.WriteLine(IsLowerMajor(str) ? str.ToLower(): str.ToUpper());
        }

        static private bool IsLowerMajor(string str) {
            int lowers = 0, uppers = 0;
            foreach(char c in str){
                uppers += (c >= 65 && c <= 90) ? 1 : 0;
                lowers += (c >= 97 && c <= 122) ? 1 : 0;
            }
            return lowers >= uppers;
        }
    }
}
