using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class TestStrings
    {
        static void Main(string[] args)
        {   //Concatination of string
            string s1 = "Welcome to world";
            string s2 = " of Machine ";
            s1 += s2;
            Console.WriteLine(s1);
            //To write directory path we use @ sign in beginning 
            string s3 = @"C:\Projects\DotNet\induction-\C#\Assignment-4\Assignment-4\bin\Debug";
            Console.WriteLine(s3);
            //Use of substring
            string s4 = s1.Substring(8, 2);
            Console.WriteLine(s4);
            //Accessing character in reverse order
            for (int i = 0; i < s1.Length; i++)
            {
                Console.Write(s1[s1.Length - i - 1]);
            }
            Console.WriteLine();
            //Using String Builder
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            // Create a string composed of numbers 0 - 9 
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
            }
            System.Console.WriteLine(sb);           
            Console.ReadLine();
        }
    }
}
