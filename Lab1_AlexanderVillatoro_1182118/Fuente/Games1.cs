using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1_AlexanderVillatoro_1182118.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace Lab1_AlexanderVillatoro_1182118
{
    public interface IGame
    {
        List<Game> GetGames();
        Game GetGame(int id);
        // GameModel EditGame(int id, string name, int puntuation);
        Game AddGame(IFormCollection collection);
        //GameModel SearchGame(int id);
    }
}