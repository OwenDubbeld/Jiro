using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Microsoft.EntityFrameworkCore;
using razorapp;

namespace razorapp.Pages
{
    public class IndexModel : PageModel
    {

        public string Message { get; private set; } = "Razor Is Awesome";

        public void OnGet()
        {
            using (var db = new GameContext())
            {
                ViewData["break"] = "    |    ";
                Game foundGame1 = db.Games.Find(1);
                ViewData["Game1title"] = foundGame1.Title;
                ViewData["Game1platform"] = foundGame1.Platform;
                ViewData["Game1genre"] = foundGame1.Genre;
                ViewData["Game1pegi"] = foundGame1.Pegi;

                Game foundGame2 = db.Games.Find(2);
                ViewData["Game2title"] = foundGame2.Title;
                ViewData["Game2platform"] = foundGame2.Platform;
                ViewData["Game2genre"] = foundGame2.Genre;
                ViewData["Game2pegi"] = foundGame2.Pegi;

                Game foundGame3 = db.Games.Find(3);
                ViewData["Game3title"] = foundGame3.Title;
                ViewData["Game3platform"] = foundGame3.Platform;
                ViewData["Game3genre"] = foundGame3.Genre;
                ViewData["Game3pegi"] = foundGame3.Pegi;

                Game foundGame4 = db.Games.Find(4);
                ViewData["Game4title"] = foundGame4.Title;
                ViewData["Game4platform"] = foundGame4.Platform;
                ViewData["Game4genre"] = foundGame4.Genre;
                ViewData["Game4pegi"] = foundGame4.Pegi;

                Game foundGame5 = db.Games.Find(5);
                ViewData["Game5title"] = foundGame5.Title;
                ViewData["Game5platform"] = foundGame5.Platform;
                ViewData["Game5genre"] = foundGame5.Genre;
                ViewData["Game5pegi"] = foundGame5.Pegi;
            }

            ViewData["Foo"] = "<h1>Check deze!</h1>";
        }
    }
}