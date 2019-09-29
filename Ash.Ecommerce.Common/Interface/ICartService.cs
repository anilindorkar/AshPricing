using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ash.Ecommerce.Common
{
    public interface ICartService
    {
        void AddToCart(Model.CartItem cartItem);
        decimal GetSubTotal();

        decimal GetTotal();

        decimal GetTotalDiscount();
    }
}
