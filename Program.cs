using System;
using System.Drawing;

namespace Devoir1
{
    class Program
    {
        public static void Main()
        {
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());

            Point p = new(x, y);

            Console.Write("x_objectif: ");
            int x_objectif = int.Parse(Console.ReadLine());
            Console.Write("y_objectif: ");
            int y_objectif = int.Parse(Console.ReadLine());

            string directionX = p.directionX(x_objectif);
            string directionY = p.directionY(y_objectif);

            Console.WriteLine("Chemin: " + directionX + directionY);

            Console.WriteLine("Entrez les directions (N, S, E, P");
            string direction = Console.ReadLine().ToUpper();

            for (int i = 0; i < direction.Length; i++)
            {
                switch (direction[i])
                {
                    case 'N': 
                        p.Nord();
                        Console.WriteLine($"x: {p.x} y: {p.y}"); 
                        break;
                    case 'S':
                       p.Sud();
                        Console.WriteLine($"x: {p.x} y: {p.y}"); 
                        break;
                    case 'E': 
                        p.Est();
                        Console.WriteLine($"x: {p.x} y: {p.y}"); 
                        break;
                    case 'O': 
                       p.Ouest();
                        Console.WriteLine($"x: {p.x} y: {p.y}"); 
                        break;
                    default: Console.WriteLine("Mauvaises directives"); break;
                }

            }

            Console.WriteLine($"Position finale: x: {p.x} y: {p.y}");

        }

    }
}
