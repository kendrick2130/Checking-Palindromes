using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string you would like to reverse");
            string R = Console.ReadLine();             
            bool isPalindrome = ReverseChar(R);
            Console.WriteLine($"The outcome is {isPalindrome}.");        

        }
        public static bool ReverseChar(string backToFront)
        {
            // Write a method to check if a string is a palindrome
            
            string R = "";
            
            for (int i = 0; i < backToFront.Length; i++)
            {
                R = backToFront[i] + R;             

            }
            if( R == backToFront)
            {
                Console.WriteLine("The output is a Palindrome the output = {0}", R);
                return true;
            }
            else
            {
                Console.WriteLine("The output is not a Palindrome");
                return false;
            }
            
        }
    }
}
