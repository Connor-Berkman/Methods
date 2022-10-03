using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int score;

        static void Main(string[] args)
        {
            Console.WriteLine("Methods!!! :)");
            Console.WriteLine();

            score = 0;
            int enemyPoints;
            enemyPoints = 100;

            ShowHub();
            simple();
            Addscore(enemyPoints);
            simple();
            ShowHub();
            simple();
            Console.WriteLine("You defeated 2 bad guys.");
            simple();
            Addscore(enemyPoints * 2);
            simple();
            ShowHub();
            simple();
            times(2, enemyPoints);
            simple();
            ShowHub();



            Console.ReadKey();
        }

        static void simple()
        {
            Console.WriteLine();
        }

        static void Addscore(int points)
        {
            Console.WriteLine(points + "+");
            score = score + points;
        }

        static void ShowHub()
        {
            Console.WriteLine("+-------------------+");
            Console.WriteLine(" Score: " + score );
            Console.WriteLine("+-------------------+");
        }

        static void times(int a, int points)
        {
            Console.WriteLine("Your score increased by a factor of " + a);
            simple();
            Console.WriteLine(points * a + "+");
            score = score + points * a;

        }
    }
}
