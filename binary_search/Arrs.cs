using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Arrs
    {

        public static void Input(int[] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
