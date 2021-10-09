using System;
using System.Collections;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a string");
            string s1 = Console.ReadLine();
            Console.WriteLine(" ");
            Stack st = new Stack();
            Queue q1 = new Queue();

            for (int i = 0; i < s1.Length; i++)
            {
                q1.Enqueue(s1.Substring(i, 1));
                if (i == s1.Length - 1)
                {
                    for (i = 0; i < s1.Length; i++)
                    {
                        char y = Convert.ToChar(q1.Dequeue());
                        Console.WriteLine(y);
                    }
                    Console.WriteLine(" ");
                }
            }
            for (int i = 0; i < s1.Length; i++)
            {
                st.Push(s1.Substring(i, 1));
                if (i == s1.Length - 1)
                {
                    for (i = 0; i < s1.Length; i++)
                    {
                        Char x = Convert.ToChar(st.Pop());
                        Console.WriteLine(x);
                    }
                }
            }
            string qu = Convert.ToString(q1);
            string sta = Convert.ToString(st);
            if (qu == sta)
            {
                Console.WriteLine("PALINDROME");
            }
            if (qu != sta)
            {
                Console.WriteLine("NOT A PALINDROME");
            }
        }
    }
}
