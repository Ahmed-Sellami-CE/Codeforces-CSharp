/* 
 * Author 	: Ahmed Sellami
 * Problem-Name : A. Translation
 * Problem-Link : https://codeforces.com/problemset/problem/41/A
*/

using System;

namespace CodeForces {
    internal class Program {
        static void Main(string[] args) {
            string word1 = Console.ReadLine(),
                word2= Console.ReadLine();
            bool res=true;
            if (word1.Length != word2.Length)
                res = false;
            else {
                for(int i = 0; i < word1.Length; i++) {
                    if (word1[i] != word2[word2.Length - i - 1]) {
                        res = false;
                        break;
                    }
                }
            }
            Console.WriteLine(res?"YES":"NO");
        }
    }
}
