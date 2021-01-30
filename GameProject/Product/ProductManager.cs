using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Product
{
    class ProductManager : IProductService
    {
        List<Game> games;
        public ProductManager()
        {
            games = new List<Game>();
        }
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("Oyun eklendi");
        }

        public void Delete(Game game)
        {
            games.Remove(game);
            Console.WriteLine("Oyun silindi");
        }

        public List<Game> GameDb()
        {
            return games;
        }

        public void Update(Game product)
        {
            Console.WriteLine("Oyun güncellendi");
        }
    }
}
