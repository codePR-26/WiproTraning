using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // find legth of a string
            string s1 = "Hello";
            Console.WriteLine($"answer of q1: {s1.Length}");

            // Convert string to uppercase Input: "welcome" Output: "WELCOME"
            string s2 = "Welcome";
            Console.WriteLine($"answer of q2: {s2.ToUpper()}");

            //Convert string to lowercase
            string s3 = "DOTNET";
            Console.WriteLine($"answer of q3: {s3.ToLower()}");

            //. Concatenate two strings
            string s4 = "Hello";
            string s5 = "C#";
            Console.WriteLine($"answer of q4: {s4 + " " + s5}");

            // Check if a string is null or empty
            string s6 = "";
            Console.WriteLine($"answer of q5: {string.IsNullOrEmpty(s6)}");

            //get first character of a string
            string s7 = "India";
            Console.WriteLine($"answer of q6: {s7[0]}");

            // Get last character of a string
            string s8 = "Programming";
            Console.WriteLine($"answer of q7: {s8[s8.Length - 1]}");

            // Compare two strings
            string s9 = "ABC";
            string s10 = "abc";
            Console.WriteLine($"answer of q8: {string.Compare(s9, s10, false)}");

            // Check if string contains a word 
            string s11 = "Welcome to C# programming";
            Console.WriteLine($"answer of q9: {s11.Contains("c#")}");

            //Trim spaces
            string s12 = "   Hello World!   ";
            Console.WriteLine($"answer of q10: {s12.Trim()}");



            //reverse a string
            string s13 = "CSharp";
            char[] arr = s13.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine($"answer of q11: {new string(arr)}");



            //count vowels in a string
            string s14 = "education";
            int vowel = 0;
            foreach (char c in s14.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    vowel++;
                }
            }
            Console.WriteLine($"answer of q12: {vowel}");


            // count consonants in a string
            string s15 = "Hello";
            int consonant = 0;
            foreach (char c in s15.ToLower())
            {
                if ("bcdfghjklmnpqrstvwxyz".Contains(c))
                {
                    consonant++;
                }
            }
            Console.WriteLine($"answer of q12: {consonant}");


            // palindrome check
            string s16 = "madam";
            string reversed = new string(s16.Reverse().ToArray());
            Console.WriteLine($"answer of q13: {s16 == reversed}");

            //count words in a string
            string s18 = "I love C Sharp";
            string[] words = s18.Split(' ');
            Console.WriteLine($"answer of q14: {words.Length}");




            //replace spaces with underscores
            string s17 = "Full Stack Developer";
            Console.WriteLine($"answer of q15: {s17.Replace(" ", "_")}");


            //index of first occurrence of a word
            string s19 = "  programming";
            Console.WriteLine($"answer of q16: {s19.Replace(" ", "").IndexOf("g")}");


            // remove all whitespace from a string
            string s20 = "C Sharp Language";
            Console.WriteLine($"answer of q17: {s20.Replace(" ", "")}");

            // Check if string starts with a substring Input: "www.google.com", "www"
            string s21 = "www.google.com";
            Console.WriteLine($"answer of q18: {s21.StartsWith("www")}");


        // Check if string ends with a substring Input: "file.txt", ".txt" Output: true 
            string s22 = "file.txt";
            Console.WriteLine($"answer of q19: {s22.EndsWith(".txt")}");


            // Frequency of each character in a string
            string s23 = "banana";
            var dict = new Dictionary<char, int>();
            foreach (char c in s23)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict[c] = 1;
                
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"answer of q21: {item.Key + ": " + item.Value}");
            }

            // Remove duplicate characters from a string
            
            string s24 = "programming";
            string result = "";
            foreach (char c in s24)
            {
                if (!result.Contains(c))
                    result += c;
            }
            Console.WriteLine($"answer of q20: {result}");





        }
    }
}
