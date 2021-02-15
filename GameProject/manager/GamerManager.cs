using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IGamerCheckService gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            this.gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (gamerCheckService.Check(gamer) == true)
            {
                Console.WriteLine("Kayıt Oluşturuldu");
            }
            else
            {
                Console.WriteLine("Kayıt İşlemi Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
