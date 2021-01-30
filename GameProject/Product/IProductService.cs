using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Product
{
    interface IProductService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        List<Game> GameDb();
    }
}
