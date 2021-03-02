using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game Id:" + game.GameId + " " + "Game Adı:" + game.GameName + " " + "Game Price:" + game.GamePrice + " " + "Stok Adedi:" + game.Stock + " " + "Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game Id:" + game.GameId + " " + "Game Adı:" + game.GameName + " " + "Game Price:" + game.GamePrice + " " + "Stok Adedi:" + game.Stock + " " + "Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game Id:" + game.GameId + " " + "Game Adı:" + game.GameName + " " + "Game Price:" + game.GamePrice + " " + "Stok Adedi:" + game.Stock + " " + "Güncellendi");
        }
    }
}
