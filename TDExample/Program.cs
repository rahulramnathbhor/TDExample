using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] arr = new int[3, 4]
            {
               { 1,2,3,4},
               {5,6,7,8 },
               {9,10,11,12 }
            };
            int[,] arr2 = new int[3, 3]
                {
                  {1,2,3 },
                {4,5,6 },
                  {7,8,9 }
                };
            for (int i = 0; i < arr.GetLength(0); i++)  
            {
                for (int j = 0; j < arr.GetLength(1); j++)  
                {
                    Console.Write($"arr[{i},{j}]= {arr[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}]= {arr2[i, j]}  ");
                }
                Console.WriteLine();
            }
            foreach (var i in arr)
            {
                Console.Write(i);
            }
        }      
	

	}

    
}
