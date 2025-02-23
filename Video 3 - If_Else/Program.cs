namespace Video_3___If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boolean - Datatyp som är true eller false


            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            // Rätt ordning
            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else if (age >= 13)
            {
                Console.WriteLine("You are a teenager");
            }
            else
            {
                Console.WriteLine("You are a child.");
            }

            // Fel ordning
            if (age >= 13)
            {
                Console.WriteLine("You are a teenager");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a child.");
            }

            int hp = 100;
            bool isDead = false;

            Console.WriteLine("How much damage do you take?");
            // Subtraherar från hp med -=
            hp -= int.Parse(Console.ReadLine());

            if (hp <= 0)
            {
                isDead = true;
            }



            if (isDead)
            {
                Console.WriteLine("You are dead");
            }
            else
            {
                Console.WriteLine("You are still alive");
            }

            
            
        }
    }
}
