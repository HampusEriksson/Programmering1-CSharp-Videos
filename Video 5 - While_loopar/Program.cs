namespace Video_5___While_loopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secret_word = "secret";

            // Sätt 1
            while (true)
            {
                Console.WriteLine("Guess the secret");
                string guess = Console.ReadLine().ToLower();

                if (guess == secret_word)
                {
                    Console.WriteLine("Correct guess!");
                    break;
                }
            }

            secret_word = "password";
            string guess2 = "";

            // Sätt 2
            while (secret_word  != guess2)
            {
                Console.WriteLine("Guess the second secret");
                guess2 = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Correct guess!");
        }
    }
}
