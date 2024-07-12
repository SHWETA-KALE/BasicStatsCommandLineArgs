using System;

namespace CommandLineDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 5)
            {
                Console.WriteLine("Please provide 5 integers as command-line arguments.");
                return;
            }

            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            
                arr[i] = Convert.ToInt32(args[i]);
            

            int sum = 0;
            float avg;
            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (arr[i] < min)
                
                    min = arr[i];
                

                if (arr[i] > max)
                
                    max = arr[i];
                
            }

            avg = (float)sum / arr.Length;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Count: " + arr.Length);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);

            Console.ReadLine();
        }
    }
}
