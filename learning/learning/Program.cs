using System.Collections.Specialized;

namespace learning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // check if the number positive or negative

            Console.WriteLine("Enter Number: ");
            int num = int.Parse(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }



            // check if the number is even or odd

            Console.WriteLine("Enter Number: ");
            int x= int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }


            // check if the rectangle is square

            Console.WriteLine("Enter the width of the rectangle: ");
            int width=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of the rectangel: ");
            int lenght = int.Parse(Console.ReadLine());

            if(width == lenght)
            {
                Console.WriteLine("The rectangle is a square");
            }
            else
            {
                Console.WriteLine("The rectangle is not square");
            }

        }
    }
}
