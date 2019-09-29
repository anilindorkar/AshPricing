using Ash.Ecommerce.Cart.Library.Service;
using Ash.Ecommerce.Common;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ash.Ecommerce.Cart
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
             
            Bind<ICartService>().To<CartServiceImpl>();
            //Bind<ILogging>().To<MockLogging>();
            





                    



        }
    }
}
