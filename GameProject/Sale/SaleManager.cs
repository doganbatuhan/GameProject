using GameProject.Campaigns;
using GameProject.Customer;
using GameProject.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Sale
{
    class SaleManager : ISaleService
    {
        Campaign _campaign;
        public SaleManager(Campaign campaign)
        {
            _campaign = campaign;
        }
        public void Sell(Gamer gamer, Game game)
        {
            
            int v = DateTime.Compare(DateTime.Today, _campaign.StartDate);
            int u = DateTime.Compare(DateTime.Today, _campaign.EndDate);
            if ((v < 0) || (u > 0))
            {
                Console.WriteLine("Kampanyamız şuanlık yok sayın " + gamer.FirstName + " " + gamer.LastName +
                    " " + game.GameName + " için ödeyeceğiniz fiyat: " + game.Price);
            }
            else
            {
                Console.WriteLine("Kampanyamız var sayın " + gamer.FirstName + " " + gamer.LastName +
                    " " + game.GameName + " için ödeyeceğiniz fiyat: " + (game.Price - (game.Price*_campaign.DiscountRate)));
            }
            
        }
    }
}
