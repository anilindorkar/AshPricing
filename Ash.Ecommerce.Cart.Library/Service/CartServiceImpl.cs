using Ash.Ecommerce.Common;
using Ash.Ecommerce.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ash.Ecommerce.Cart.Library.Service
{
    public class CartServiceImpl : ICartService
    {
        public CartServiceImpl()
        {
            _cartItems = new List<CartItem>();
        }
        public string ShoppingCartId { get; set; }

        private List<CartItem> _cartItems { get; set; }

        public void AddToCart(CartItem cartItem)
        {
            if(cartItem != null)
            _cartItems.Add(cartItem);
        }

        public List<CartItem> GetCartItems()
        {
            if (_cartItems == null) { _cartItems = new List<CartItem>(); }
            return _cartItems;
        }

        public decimal GetSubTotal()
        {
            throw new NotImplementedException();
        }

        public decimal GetTotal()
        {
            
            // Multiply product price by quantity of that product to get        
            // the current price for each of those products in the cart.  
            // Sum all product price totals to get the cart total.   
            decimal? total = decimal.Zero;
            total = (decimal?)(from cartItems in _cartItems
                               select (int?)cartItems.Quantity *
                               cartItems.Product.UnitPrice).Sum();
            return total ?? decimal.Zero;
        }

        public decimal GetTotalDiscount()
        {
            decimal? total = decimal.Zero;
            total = (decimal?)(from cartItems in _cartItems
                               select (int?)cartItems.Quantity *
                               cartItems.Product.Discount).Sum();
            return total ?? decimal.Zero;
        }
    }
}
