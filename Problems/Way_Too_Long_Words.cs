/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Way Too Long Words
 * Problem-Link : https://codeforces.com/problemset/problem/71/A
*/

using System;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string word,result;
            result = "";
            for(int i = 0; i < n; i++) {
                word = Console.ReadLine();
                result+=word.Length > 10 ? $"{word[0]}{word.Length-2}{word[word.Length-1]}\n":$"{word}\n";
            }
            Console.WriteLine(result);
        }
    }
}
