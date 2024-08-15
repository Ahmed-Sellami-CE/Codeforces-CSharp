/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Night at the Museum
 * Problem-Link : https://codeforces.com/problemset/problem/731/A
*/

using System;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            char index = 'a';
            int result = 0;
            for(int i = 0; i < input.Length; i++) {
                result += input[i] - index >= 0 ? Math.Min(26 - input[i] + index, input[i] - index) : Math.Min(26 - index + input[i], index - input[i]);
                index = input[i];
            }
            Console.WriteLine(result);
        }
    }
}
