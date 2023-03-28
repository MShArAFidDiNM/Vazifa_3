namespace Vazifa_Tempratura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 3;
            qaytakirit:
            Console.Write("Enter Celcius : ");
            f--;
            string c = Console.ReadLine();
            bool t = double.TryParse(c, out double r);
                if (!t)
                {
                    Console.WriteLine($"Error !!! {c}");                    
                    if (f <= 0)
                    {
                        Console.WriteLine("Your attempt has ended. Please try again later");
                    return;
                    }
                    Console.WriteLine("Enter again");
                    Console.WriteLine($"You have {f} attempts left");                 
                    goto qaytakirit;   
                } 
                else
            {
                Console.WriteLine($"Kelvin : {r * 10.1}");
                Console.WriteLine($"Farengeyt : {r * 2.86666667}");
            }
            Main(args);
        }
    }
}