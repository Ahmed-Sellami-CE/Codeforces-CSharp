/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Army
 * Problem-Link : https://codeforces.com/problemset/problem/38/A
*/

using System;
using System.Text.RegularExpressions;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string dis = Console.ReadLine();
            Match ab=Regex.Match(Console.ReadLine(),@"(\d+)\s(\d+)");
            int a = Convert.ToInt32(ab.Groups[1].Value),
                b = Convert.ToInt32(ab.Groups[2].Value),
                result = 0,i=0;
            int[] di = new int[n - 1];
            while(i<n-1) {
                di[i] = dis.Contains(' ')?Convert.ToInt32(dis.Substring(0, dis.IndexOf(' '))): Convert.ToInt32(dis);
                dis = dis.Substring(dis.IndexOf(' ') + 1);
                i++;
            }
            for (i = a-1; i < b-1; i++) 
                result += di[i];
            
            Console.WriteLine(result);
        }
    }
}
