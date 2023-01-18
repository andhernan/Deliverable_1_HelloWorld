using System.Reflection.Metadata;

namespace deliverable1_helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution (1): Hello, World!");
            Console.WriteLine(" ");

            string stg = "Hello, World!";
            Console.WriteLine("Solution (2): " + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a User's Name: ");
            string userName = Console.ReadLine(); 
            Console.WriteLine("The user's name is "+ userName);
            Console.WriteLine(" ");

            Console.WriteLine("Enter the User's Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            int userAge = int.Parse(Console.ReadLine());
            //my original thought was
            //string userAge = Console.ReadLine();
            Console.WriteLine("'The user's age is "+ userAge);
            Console.WriteLine(" ");


            Console.WriteLine("That's All :)");
        }
    }
}