using System;
using System.Text;
using System.Collections.Generic;

namespace _30._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //30/12
            string palindrom = Console.ReadLine();

            if (Palfinalrom(palindrom, 0, palindrom.Length - 1) == true)
            {
                Console.WriteLine("Word is palinalrom!");
            }
            else
            {
                Console.WriteLine("Word is not palinalrom!");
            }

        }

        private static bool Palfinalrom(string palindrom, int start, int final)
        {
            
            if (palindrom.Length / 2 == final && palindrom.Length != 2)
            {
                return true;
            }

            //exception
            if (palindrom.Length == 0)
            {
                return true;
            }

            //exception
            if (palindrom.Length == 1)
            {
                return true;
            }

            //recursion
            if (palindrom[start] == palindrom[final])
            {
                return Palfinalrom(palindrom, start + 1, final - 1);
            }
            else
            {
                return false;
            }
        }
    }
}

