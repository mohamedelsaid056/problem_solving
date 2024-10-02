namespace Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number to check if it's even or odd:");

            // Improved input handling with TryParse
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Enter a valid number:");
            }

            CheckOddorEven(number);
        }
        public static void CheckOddorEven(int numbert)
        {
            if (numbert % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

    }
}
