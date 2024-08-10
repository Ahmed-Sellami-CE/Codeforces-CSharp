/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Die Roll
 * Problem-Link : https://codeforces.com/problemset/problem/9/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string input1 = Console.ReadLine();
            Match match = Regex.Match(input1, @"(\d+)\s(\d+)");
            int Y = Convert.ToInt32(match.Groups[1].Value),
                W = Convert.ToInt32(match.Groups[2].Value),
                chance = 7-(Y>=W?Y:W);
            switch (chance) {
                case 1:
                    Console.WriteLine("1/6");break;
                case 2:
                    Console.WriteLine("1/3");break;
                case 3:
                    Console.WriteLine("1/2");break;
                case 4:
                    Console.WriteLine("2/3");break;
                case 5:
                    Console.WriteLine("5/6");break;
                case 6:
                    Console.WriteLine("1/1");break;
                default:
                    Console.WriteLine("0/1");break;
            }
        }
    }
}
