namespace Tub_son
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            string a = Console.ReadLine();
            bool b = int.TryParse(a, out int c);
            int g = 0;
            if (b) {
                for (int i = 2; i <= c; i++)
                {
                    if (c % i == 0)
                    {
                        g++;
                    }                   
                }
                if (g == 1)
                {
                    Console.WriteLine($"{a} a prime number");
                }
                else
                {
                    Console.WriteLine($"{a} is not a prime number");

                }
            }else
            {
                Console.WriteLine("You didn't enter a number");
            }
            Main(args);
        }
    }
}