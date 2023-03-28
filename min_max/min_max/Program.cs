namespace min_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number3 = 0;
            int number4 = 0;
            int min = 0;
            int max = 0;
        again1:
            Console.Write("number 1 : ");
            string number1_str = Console.ReadLine();
            bool check1 = int.TryParse(number1_str, out int number1);
            if (!check1)
            {
                Console.WriteLine($"Error : {number1_str}");
                Console.WriteLine("Try again !");
                goto again1;
            }
        again2:
            Console.Write("number 2 : ");
            string number2_str = Console.ReadLine();
            bool check2 = int.TryParse(number2_str, out int number2);
            if (!check2)
            {
                Console.WriteLine($"Error : {number2_str}");
                Console.WriteLine("Try again !");
                goto again2;
            }

        again3:
            Console.Write("number 3 : ");
            string number3_str = Console.ReadLine();
            bool check3 = int.TryParse(number3_str, out number3);
            if (!check3)
            {
                Console.WriteLine($"Error : {number3_str}");
                Console.WriteLine("Try again !");
                goto again3;
            }

        again4:
            Console.Write("number 4 : ");
            string number4_str = Console.ReadLine();
            bool check4 = int.TryParse(number4_str, out number4);
            if (!check4)
            {
                Console.WriteLine($"Error : {number4_str}");
                Console.WriteLine("Try again !");
                goto again4;
            }
            if(number1 < number2 && number1 < number3 && number1 < number4)
            {
                Console.WriteLine($"MIN : {number1}");
            }
            else if(number2 < number1 && number2 < number3 && number2 < number4)
            {
                Console.WriteLine($"MIN : {number2}");
            } 
            else if(number3 < number1 && number3 < number2 && number3 < number4)
            {
                Console.WriteLine($"MIN : {number3}");
            }
            else if(number4 < number1 && number4 < number2 && number4 < number3)
            {
                Console.WriteLine($"MIN : {number4}");
            }  
             if(number1 > number2 && number1 > number3 && number1 > number4)
            {
                Console.WriteLine($"MAX : {number1}");
            }
            else if(number2 > number1 && number2 > number3 && number2 > number4)
            {
                Console.WriteLine($"MAX : {number2}");
            } 
            else if(number3 > number1 && number3 > number2 && number3 > number4)
            {
                Console.WriteLine($"MAX : {number3}");
            }
            else if(number4 > number1 && number4 > number2 && number4 > number3)
            {
                Console.WriteLine($"MAX : {number4}");
            }
        }

    }
}