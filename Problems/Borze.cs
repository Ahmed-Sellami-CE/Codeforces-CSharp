/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : B. Borze
 * Problem-Link : https://codeforces.com/problemset/problem/32/B
*/

using System;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine(),result="";
            int i = 0;
            while (i < input.Length) {
                if (input[i] == '.') {
                    result += "0";
                    i++;
                }else if (input[i] == '-' && i<input.Length-1) {
                    result += input[i + 1] == '.' ?"1":"2";
                    i += 2;
                }
            }
            Console.WriteLine(result);
        }
    }
}
