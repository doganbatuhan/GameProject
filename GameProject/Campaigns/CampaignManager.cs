using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Campaigns
{
    public class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns;
        public CampaignManager()
        {
            campaigns = new List<Campaign>();
        }
        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("Kampanya eklendi");
        }

        public List<Campaign> CampaignDb()
        {
            return campaigns;
        }

        public void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
