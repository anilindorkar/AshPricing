using Ash.Ecommerce.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ash.Ecommerce.Common.Interface
{
    public class BaseProduct
    {
        Guid ProductID { get; set; }

        string ProductName { get; set; }

        string Description { get; set; }

        string ImagePath { get; set; }

        double? UnitPrice { get; set; }        

        double? Discount { get; set; }
    }
}
