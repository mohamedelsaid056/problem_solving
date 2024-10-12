namespace swap
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            while (true)
            {
                Console.WriteLine("Enter first number");
                var success = int.TryParse(Console.ReadLine(), out a);
                if (success)
                {
                    break;
                }
                Console.WriteLine("Please enter a valid number");


            }
            while (true)
            {
                Console.WriteLine("Enter second number");
                var success = int.TryParse(Console.ReadLine(), out b);
                if (success)
                {
                    break;
                }
                Console.WriteLine("Please enter a valid number");

            }
            Console.WriteLine("Before swap a = {0} and b = {1}", a, b);

            Swap( ref a,ref b);
            Console.WriteLine("After swap a = {0} and b = {1}", a, b);


        }
        static void Swap( ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
