using System;
using System.Collections.Generic;
using System.Linq;

namespace _61._1
{
    class Program
    {

        static void Main(string[] args)
        {
            //            61/1
            string bracketsText = Console.ReadLine();

            List<char> brackets = new List<char>();

            if (bracketsText[0] == ')')
            {
                Console.WriteLine("Brackets are not balanced!");
                return;
            }

            for (int i = 0; i < bracketsText.Length; i++)
            {

                if (bracketsText[i] == '(')
                {
                    brackets.Add('(');
                }

                if (bracketsText[i] == ')')
                {
                    if (brackets.Count > 0)
                    {
                        brackets.Remove('(');
                    }
                    else
                    {
                        Console.WriteLine("Brackets are not balanced!");
                        return;
                    }
                }
            }

            if (brackets.Count == 0)
            {
                Console.WriteLine("Brackets are balanced!");
            }
            else
            {
                Console.WriteLine("Brackets are not balanced!");
            }
        }
    }
}
