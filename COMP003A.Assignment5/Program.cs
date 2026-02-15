namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            introductionMessage();

                Console.Write("\nEnter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

        }

        static void introductionMessage()
        {
            Console.WriteLine("Welcome to the Program Organizer!");

        }
    }
}
