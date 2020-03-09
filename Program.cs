using System;
using System.Collections.Generic;

namespace elmt_unique
{
    class Program

    {

        static void Main(string[] args)
        {

            var numbers = new List<int> { 5, 5, 8, 2, 9, 8, 7, 1, 9 };
            var unique = new List<int>(7);
            // List<int> unique = new List<int>(7);


            for (int i = 0; i < numbers.Count - 1; i++)
            {

                if (!unique.Contains(numbers[i]))
                {
                    unique.Add(numbers[i]);
                }


            }
 //2
            // Console.WriteLine(unique);
            //Console.Write("'{0}' ", unique);

        }
    }
}

