namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            introductionMessage(); //This intro is in its own method to keep the Main clean

            string repeat = "y";
            while (repeat == "y")
            {
                Console.Write("\nEnter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                int result = calculationLogic(number); //Using a separate method for the math keeps the Main focus on the flow and not the calculations
                Console.WriteLine($"\nCalculated Result: {result}");

                if (result > 10)
                {
                    Console.WriteLine("The result is greater than 10.");
                }
                else
                {
                    Console.WriteLine("The result is 10 or less.");
                }

                Console.Write("\nWould you like to run the program again? (y/n): ");
                repeat = Console.ReadLine();
            }
            Console.WriteLine("\nProgram Ended");

        }

        static void introductionMessage() //Purpose: This shows the intro message at the begining of the program
        {
            Console.WriteLine("Welcome to the Program Organizer!");

        }
        static int calculationLogic(int value) //Purpose: This handles the calculation logic so the Main isn't doing it directly
        {                                      // Scope work: value and doubled only exists inside this method so nothing outside this method can mess with it. 
            int doubled = value * 2;  
            return doubled;
        }
    }
}
