using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Campaigns
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
        List<Campaign> CampaignDb();
    }
}
