using System;

namespace GameProject
{
    class Program
    {
        private static object gamer;

        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());            
            gamerManager.Add(new Gamer { BirthYear = 1994, FirstName = "seyfo", IdNumber = 1, LastName = "kara" });

            Game game = new Game();
            game.GameId = 1;
            game.GameName = "The Last Day Of The World";
            game.GamePrice = 125;

            Discount discount = new Discount();
            discount.DiscountId = 1;
            discount.DiscountName = "Christmas Campaign";
            discount.DiscountPercent = 50;

            Console.WriteLine("Dear  Gamer "              
                + " , you got  "
                + discount.DiscountName
                + ", you have %"
                + discount.DiscountPercent
                + " discount at this game "
                + game.GameName);




        }
    }
}
