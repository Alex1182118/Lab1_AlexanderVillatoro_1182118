using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1_AlexanderVillatoro_1182118.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Game;

namespace WebApplication1.Game
{
    public class Game : Games1
    {
        List<Game> listgames = new List<Game>();

        public Game()
        {

            listgames.Add(new Game()
            {
                Id = 11858,
                Name = "Alex",
                Puntuation = 115,

            });
            Game est2 = new Game()
            {
                Id = 154854,
                Name = "Jose",
                Puntuation = 4545,
            };
            listgames.Add(est2);
            Game est3 = new Game();
            est3.Id = 1554;
            est3.Name = "Pedro";
            est3.Puntuation = 454;
            listgames.Add(est3);
        }

        public List<Game> GetGames()
        {
            return listgames;
        }

        public Game GetGame(int id)
        {
            Game games =
                listgames.FirstOrDefault(x => x.Id == id);
            return games;
        }
        public Game AddGame(IFormCollection collection)
        {
            Game games = new Game()
            {
                Id = Convert.ToInt16(collection["Id"]),
                Name = collection["Name"].ToString(),
                Puntuation = Convert.ToInt16(collection["Puntuation"])
            };
            listgames.Add(games);
            return games;
        }
    }
}
