using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string name;
            int index;
            float pv;

            Console.Write("Enter the number of enemies: ");
            num = int.Parse(Console.ReadLine());

            Foe[] enemies = new Foe[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter name for enemy {i + 1}: ");
                name = Console.ReadLine();
                enemies[i] = new Foe(name);
            }

            Console.WriteLine("All enemies:");

            foreach (Foe enemy in enemies)
            {
                Console.WriteLine(enemy.GetName());
            }

            Console.Write("Health or Shield? : ");
            PowerUp powerUp = (PowerUp)Enum.Parse(typeof(PowerUp), 
            Console.ReadLine(), true);

            Console.Write("Enter PowerUp value: ");
            pv = float.Parse(Console.ReadLine());

            Console.Write("Enter index of enemy: ");
            index = int.Parse(Console.ReadLine());
        }
    }
}