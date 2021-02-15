using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class DiscountManager : IDiscountService
	{
		public DiscountManager()
		{
			 void Add(Discount discount)
			{
				Console.WriteLine("Kampanya Eklendi : " + discount.DiscountName);
			}
			 void Delete(Discount discount)
			{
				Console.WriteLine("Kampanya Silindi : " + discount.DiscountName);
			}
            void Update(Discount discount)
			{
				Console.WriteLine("Kampanya Güncellendi : " + discount.DiscountName);
			}
		}

        public void Add(Discount discount)
        {
            throw new NotImplementedException();
        }

        public void Delete(Discount discount)
        {
            throw new NotImplementedException();
        }

        public void Update(Discount discount)
        {
            throw new NotImplementedException();
        }
    }
}
