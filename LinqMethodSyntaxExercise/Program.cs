using System;
using System.Collections.Generic;

using System.Linq;

namespace LinqMethodSyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method Syntax
            var videoGames = new List<string>
            {  "Madden", "Backyard Baseball", "Halo", "NCAA Football '08" };

            var orderedGames = videoGames.OrderBy(game => game.Length);
            foreach(var game in orderedGames)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine();

            //Query Syntax
            string[] cars = { "Honda", "Suburban", "Volvo", "Chevy", "Ole truck" };

            
            var carsWithO = from car in cars 
                            where car.Contains("o")
                            || car.Contains("O")
                            orderby car ascending
                            select car;

            foreach (var i in carsWithO)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}   
