using System;
using System.Collections.Generic;

using System.Linq;

namespace LinqMethodSyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>
            {  "Madden", "Backyard Baseball", "Halo", "NCAA Football '08" };

            var orderedGames = videoGames.OrderBy(game => game.Length);
            foreach(var game in orderedGames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
