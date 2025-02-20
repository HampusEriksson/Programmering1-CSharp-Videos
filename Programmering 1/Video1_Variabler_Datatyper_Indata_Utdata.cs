internal class Video1_Variabler_Datatyper_Indata_Utdata
{
    private static void Main(string[] args)
    {
        // Variabler
        // Datatyper
        // string - text
        string first_name = "Hampus";
        string last_name = "Eriksson";

        // int-heltal (integer)
        int age = 31;
        age = 107;

        // double - decimaltal
        double godis_price = 6.5;

        // char - tecken
        char bokstav = 'H';

        // Utdata
        Console.WriteLine("Hello world");

        Console.WriteLine($"Hello {first_name} {last_name}. You are {age} years old.");


        // Indata
        Console.WriteLine("What do you like to do?");
        string like_to_do = Console.ReadLine();
        Console.WriteLine($"Oh how fun. I also like {like_to_do}.");

        // Konvertera indata till int
        Console.WriteLine("How old are you?");
        int user_age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Oh how nice, you are {user_age} years old.");

    }
}