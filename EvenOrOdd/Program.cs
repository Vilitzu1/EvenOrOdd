using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string inputFromUser = Console.ReadLine();
            int numTemporary;
            int number;
            if (int.TryParse(inputFromUser, out number))
            {
                numTemporary = number;
            }
            else
            {
                numTemporary = 0;
                Console.WriteLine("Value entered was no number. Value was set as 0.");
            }



            if (number % 2 != 0)
            {
                Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("Even");
            }
        }
    }
}
