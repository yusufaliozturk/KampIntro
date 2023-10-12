using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class BaseGameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("New game added, Game Name: "+game.GameName);
        }

        public void Remove(Game game)
        {
            Console.WriteLine("Game removed, Game Name: "+game.GameName);
        }

        public void UpdatePrice(Game game)
        {
            Console.WriteLine("Game is updated price, Game Name: " + game.GameName);
        }
    }
}
