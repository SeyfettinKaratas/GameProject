using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public OrderManager()
        {
        }

        public void Order(Game game, Gamer gamer, Discount discount)
        {
            void Add(Order order)
            {
                Console.WriteLine("Oyun Eklendi : " + order.GameName);
            }
            void Delete(Order order)
            {
                Console.WriteLine("Oyun Silindi : " + order.GameName);
            }
            void Update(Order order)
            {
                Console.WriteLine("Oyun Güncellendi : " + order.GameName);
            }
        }

        public void Order(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
