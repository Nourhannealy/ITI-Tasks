using Microsoft.VisualBasic;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            // Data system

            Console.WriteLine("=== Welcome to system ===");

            int id;
            string name;
            int age;
            double salary;

            do
            {
                Console.WriteLine("Enter ID: ");
                id = int.Parse(Console.ReadLine());

            } while (id < 0);


            bool yes;

            do
            {
                yes = false;

                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();

                for(int i = 0; i < name.Length; i++)
                {
                    if(!char.IsLetter(name[i]))

                    {
                        yes = true;
                    }
                }


            } while (yes);

            do
            {
                Console.WriteLine("Enter age: ");
                age = int.Parse(Console.ReadLine());


            } while (age < 0);


            do
            {
                Console.WriteLine("Enter salary: ");
                salary = int.Parse(Console.ReadLine());

            } while(salary < 0);



        }

    }
    
}