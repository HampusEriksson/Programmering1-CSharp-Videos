namespace Video_4___For_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int j = 7; j < 100; j+=2)
            {
                Console.WriteLine(j);
            }

            for (int k = 100; k >= 0; k--)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("Pick a startnumber");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick a stopnumber");
            int stop = int.Parse(Console.ReadLine());

            for (int whatever = start; whatever <= stop; whatever++)
            {
                Console.WriteLine(whatever);
            }

        }
    }
}
