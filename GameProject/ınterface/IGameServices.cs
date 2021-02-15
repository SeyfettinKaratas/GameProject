using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.ınterface
{
    interface IGameServices
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
