/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Anton and Danik
 * Problem-Link : https://codeforces.com/problemset/problem/734/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine()),As=0,Ds=0;
            string input = Console.ReadLine();
            for(int i = 0; i < n; i++) {
                As += input[i] == 'A' ? 1 : 0;
                Ds += input[i] == 'D' ? 1 : 0;
            }
            Console.WriteLine(As > Ds ? "Anton" : As < Ds ? "Danik" : "Friendship");
        }
    }
}
