using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ash.Ecommerce.Common;
using Ash.Ecommerce.Common.Model;
using Ninject; 

namespace Ash.Ecommerce.Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var service = kernel.Get<ICartService>();
            var cartItem = new CartItem() { ItemId = Guid.NewGuid(), CartId = Guid.NewGuid(),DateCreated = DateTime.Now, Product = new Product(),Quantity = 1,ProductId  = Guid.NewGuid()};
            service.AddToCart(new CartItem());
            service.GetTotal();
            service.GetTotalDiscount();
        }
    }
}
