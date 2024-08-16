/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. One-dimensional Japanese Crossword
 * Problem-Link : https://codeforces.com/problemset/problem/721/A
*/

using System;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine()),blocks=0,squares=0;
            string input = Console.ReadLine(),output="";
            bool black = false;
            
            for(int i=0; i < n; i++) {
                if (input[i] == 'B') {
                    blocks += black ? 0 : 1;
                    squares +=1;
                    black = true;
                } else {
                    black = false;
                    output += squares!=0?$"{squares} ":"";
                    squares = 0;
                }
            }
            output += black && input[n-1] == 'B' ?$"{squares} ":"";
            Console.WriteLine(blocks!=0?$"{blocks}\n{output}":"0");
        }
    }
}
