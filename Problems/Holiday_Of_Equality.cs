/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Holiday Of Equality
 * Problem-Link : https://codeforces.com/problemset/problem/758/A
*/

using System;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine()), index = 0;            string input = Console.ReadLine();
            long[] burlers = new long[n];
            long max = 0, result = 0;
            while(index<n) {
                burlers[index] = input.Contains(' ') ? Convert.ToInt64(input.Substring(0, input.IndexOf(' '))) : Convert.ToInt64(input);
                input = input.Substring(input.IndexOf(' ')+1);
                max = max < burlers[index] ? burlers[index] : max;
                index++;
            }
            for(int i = 0; i < n; i++) {
                result += max - burlers[i];
            }
            Console.WriteLine(result);
        }
    }
}
