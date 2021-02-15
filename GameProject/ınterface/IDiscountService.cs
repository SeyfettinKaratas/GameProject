using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IDiscountService
    {
        void Add(Discount discount);
        void Delete(Discount discount);
        void Update(Discount discount);
    }
}
