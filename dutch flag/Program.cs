using System;

namespace _106._5
{
    class Program
    {
        private static void ArangeColors(string[] array)
        {
            int firstIndexRed = 0;
            int lastIndexWhite = array.Length - 1;
            for (int i = 0; i < lastIndexWhite - 1; i++)
            {
                if (array[i] == "red")
                {
                    SwapMethod(array, firstIndexRed++, i--);
                }
                else if (array[i] == "white")
                {
                    SwapMethod(array, i--, lastIndexWhite--);
                }
            }
        }

        static void Main(string[] args)
        {
            //106/5
            string[] array = {};

            ArangeColors(array);

            for (int i = 0; i <array.Length ; i++)
            {
                Console.Write(array[i]+" ");
            }

        }

        static void SwapMethod(string[] array, int one, int two)
        {
            string swap = array[one];
            array[one] = array[two];
            array[two] = swap;
        }
    }
}