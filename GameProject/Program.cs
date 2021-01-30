using GameProject.Customer;
using GameProject.Validation;
using GameProject.Sale;
using GameProject.Product;
using GameProject.Campaigns;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1996,
                FirstName = "Batuhan",
                LastName = "Doğan",
                NationalityId = 12345
            });

            SaleManager saleManager = new SaleManager(new Campaign
            {
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 5, 10),
                DiscountRate = 0.35
            });

            saleManager.Sell(new Gamer
            {
                BirthYear = 1996,
                FirstName = "Batuhan",
                LastName = "Doğan",
                Id = 2,
                NationalityId = 12345
            }, new Game
            {
                GameId = 27,
                GameName = "Fifa21",
                Price = 250.75
            });

        }
    }
}
