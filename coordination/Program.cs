using System;
using System.Collections.Generic;
using System.Linq;

namespace _29._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 29/5

            Console.Write("Enter edges: ");
            int pairs = int.Parse(Console.ReadLine());

            //contain coordinates of x and y
            List<string> pairsList = new List<string>();

            Console.WriteLine("Enter all pairs separete with comma");
            for (int i = 0; i < pairs; i++)
            {
                Console.Write("(x,y)= ");
                pairsList.Add(Console.ReadLine());
            }

            double max = 0;
            for (int i = 1; i < pairsList.Count - 1; i++)
            {
                for (int j = 0; j < pairsList.Count; j++)
                {
                    //continue if its neighbour
                    if (i == j || i == j - 1 || i == j + 1)
                    {
                        continue;
                    }
                    else
                    {
                        var xy1 = pairsList[i].Split(',').Select(int.Parse).ToArray();
                        var xy2 = pairsList[j].Split(',').Select(int.Parse).ToArray();

                        //we take all coordinates
                        int a1 = xy2[0]; //x1
                        int a2 = xy2[1]; //y1

                        int a3 = xy1[0]; //x2
                        int a4 = xy1[1]; //y2

                        int x = a1 - a3;
                        int y = a2 - a4;

                        //lenght of line
                        double lengh = Math.Sqrt(x * x + y * y);


                        if (lengh > max)
                        {
                            max = lengh;
                        }
                    }
                }
            }
            Console.WriteLine($"Longest is {max}");
        }
    }
}
