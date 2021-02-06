using System;

namespace ConsoleApp1
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Arrs Arrs = new Arrs();

            Console.WriteLine("Введите 10 чисел для заполнения");
            int size = 5;
            int[] arr = new int[size];

            Arrs.Input(arr);


            Array.Sort(arr);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=============");
            Arrs.Print(arr);
            Console.WriteLine("=============");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            int Key;

            

            Console.WriteLine("Введите ключ");
            Key = int.Parse(Console.ReadLine());

            int Low = 0;
            int Height = size - 1;

            int mid;
            mid = (Low + Height) / 2;
            bool result = false;

            while(Low <= Height)
            {
                

                if(Key == arr[mid])
                {
                    result = true;
                    break;
                }

                if(arr[mid] > Key)
                {
                    Height = mid - 1;
                }    

                else if(arr[mid] < Key)
                {
                    Low = mid + 1;
                }
            }



            if(result == true)
            {
                Console.WriteLine(mid);
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
