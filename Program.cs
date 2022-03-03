using System;
using System.Collections.Generic;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1, 2, 2, 2, 3, 4, 5, 5, 5, 6, 4, 4, 7, 6, 7, 8};

            List<int> noRepeted = new List<int>();

            foreach(int i in array)
            {
                if(noRepeted.Count == 0)
                {
                    noRepeted.Add(i);
                }
                else
                {
                    int count = 0;
                    foreach(int check in noRepeted)
                    {
                        if(i == check)
                        {
                            count++;
                        }
                    }

                    if(count < 1)
                    {
                        noRepeted.Add(i);
                    }
                }
                
            }

            foreach(int i in noRepeted)
            {
                Console.Write(i + " ");
            }
        }
    }
}
