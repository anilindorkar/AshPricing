using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ash.Ecommerce.Common.Model
{
    public class CartItem
    {
        
        public Guid ItemId { get; set; }

        public Guid CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public Guid ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}
