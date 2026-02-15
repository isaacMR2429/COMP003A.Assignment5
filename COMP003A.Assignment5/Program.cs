namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            introductionMessage();

            string repeat = "y";
            while (repeat == "y")
            {
                Console.Write("\nEnter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                int result = calculationLogic(number);
                Console.WriteLine($"\nCalculated Result: {result}");
            }

        }

        static void introductionMessage()
        {
            Console.WriteLine("Welcome to the Program Organizer!");

        }
        static int calculationLogic(int value)
        {
            int doubled = value * 2;
            return doubled;
        }
    }
}
