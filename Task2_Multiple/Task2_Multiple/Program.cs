namespace Task2_Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number for the multiplication table: ");
            int num = int.Parse(Console.ReadLine());


            Console.WriteLine($"Multiplication Table for {num}:");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {num * i}");
            }

        }

    }
}