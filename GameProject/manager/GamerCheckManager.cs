using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {
            if(gamer.IdNumber==1 && gamer.FirstName=="seyfo" && gamer.LastName=="kara" && gamer.BirthYear==1994)
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
