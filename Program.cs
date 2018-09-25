using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Model;
using Microsoft.EntityFrameworkCore;

namespace razorapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new GameContext())
            {
                //functies die instanties van de games maken om toe te voegen*************************
                // Game g = new Game
                // {
                //     Title = "Counter Strike : Global Offensive",
                //     Platform = "Steam",
                //     Genre = "FPS",
                //     Pegi = "16+"
                // };
                // Game h = new Game
                // {
                //     Title = "Dead by Daylight",
                //     Platform = "Steam",
                //     Genre = "Survival",
                //     Pegi = "16+"
                // };
                // Game i = new Game
                // {
                //     Title = "Rocket League",
                //     Platform = "Steam",
                //     Genre = "Driving",
                //     Pegi = "3+"
                // };
                // Game j = new Game
                // {
                //     Title = "GTA V",
                //     Platform = "Steam",
                //     Genre = "RPG",
                //     Pegi = "18+"
                // };

                //functies voor het invoegen van de games in de database*****************************
                // db.Games.Add(h);
                // db.Games.Add(i);
                // db.Games.Add(j);
                //functie om de database op te slaan*************************************************
                //db.SaveChanges();
            }

            // functie die de game wijzigt
            // using (var db = new GameContext())
            // {
            //     Game foundGame = db.Games.Find(3);
            //     foundGame.Title = "Dead by Daylight";
            //     foundGame.Pegi = "16+";
            //     db.SaveChanges();
            // }

            // functie die de game wijzigt
            // using (var db = new GameContext())
            // {
            //     Game foundGame = db.Games.Find(3);
            //     foundGame.Title = "Another Game Title";
            //     foundGame.Pegi = "123456789+";
            //     db.SaveChanges();
            // }

            CreateWebHostBuilder(args).Build().Run();
            ReadGameData();
            

        }

        static void ReadGameData()
        {
            using (var db = new GameContext())
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                foreach (var game in db.Games)
                {
                    Console.WriteLine(" {0} | {1} | {2} | {3} ", game.Title, game.Platform, game.Genre, game.Pegi);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
