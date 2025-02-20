
    internal class Video2_Operatorer    
    {
        static void Main(string[] args)
        {
            // Operatorer
            int my_age = 31;

            Console.WriteLine("How old are you?");
            int their_age = int.Parse(Console.ReadLine());

            // Addition
            int total_age = my_age + their_age;
            Console.WriteLine($"You and Hampus are {total_age} years old together.");

            // Subtraktion
            int years_until_pension = 65 - their_age;
            Console.WriteLine($"You have {years_until_pension} years until pension.");

            // Multiplikation
            int number1 = 13;
            int number2 = 7;
            int product = number1 * number2;
            Console.WriteLine($"{number1} multiplied with {number2} is {product}");

            // Division
            double number3 = 14;
            double number4 = 7;
            double quotient = number3 / number4;
            Console.WriteLine($"{number3} divided by {number4} is {quotient}");

            // Modulus
            int number5 = 18;
            int number6 = 3;
            int rest_bullar = number5 % number6;
            Console.WriteLine($"If you have {number5} bullar split by {number6} people, there will be {rest_bullar} left.");
        }
    }
