using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.manager
{
    class GameManager : IGamerService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "EKLEMDİ." + '\n');
        }

        public void Add(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "SİLİNDİ." + '\n');
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "GÜNCELLENDİ." + '\n');
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IGameServices
    {
    }
}
