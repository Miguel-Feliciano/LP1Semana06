using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string name;

            Console.Write("Enter the number of enemies: ");
            num = int.Parse(Console.ReadLine());

            Foe[] enemies = new Foe[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter name for enemy {i + 1}: ");
                name = Console.ReadLine();
                enemies[i] = new Foe(name);
            }

        }
    }
}