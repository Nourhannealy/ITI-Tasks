using System.Collections.Specialized;

namespace Task2_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int sz = int.Parse(Console.ReadLine());

            int[] arr = new int[sz];

            Console.WriteLine("Enter the degrees: ");
            for(int i=0; i< sz; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            // finding the maximum degree
            int max = arr[0];

            for(int i=1; i< sz; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("Maximum degree: " +max);
            

        }
    }
}