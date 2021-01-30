using GameProject.Customer;
using GameProject.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Sale
{
    interface ISaleService
    {
        void Sell(Gamer gamer, Game game);
    }
}
