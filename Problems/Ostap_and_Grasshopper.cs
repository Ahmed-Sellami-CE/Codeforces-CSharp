/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Ostap and Grasshopper
 * Problem-Link : https://codeforces.com/problemset/problem/735/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string input1 = Console.ReadLine(),
                input2 = Console.ReadLine();
            Match match = Regex.Match(input1,@"(\d+)\s(\d+)");
            int n = Convert.ToInt32(match.Groups[1].Value),
                k = Convert.ToInt32(match.Groups[2].Value),
                gIndex=input2.IndexOf('G'),tIndex=input2.IndexOf('T');
            if (gIndex < tIndex) {
                while (gIndex<n && gIndex < tIndex && (input2[gIndex] == 'G' || input2[gIndex] == '.'))
                    gIndex += k;
            } else {
                while (gIndex >= 0 && gIndex > tIndex && (input2[gIndex] == 'G' || input2[gIndex] == '.'))
                    gIndex -= k;
            }
            Console.WriteLine(gIndex<0 || gIndex>=n || input2[gIndex]!='T'?"NO":"YES");
        }
    }
}
