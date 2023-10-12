using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class BaseCampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Deleted to Campaigns: " + campaign.CampaignName);
        }
        public void Enter(Campaign campaign)
        {
            Console.WriteLine("New entered to Campaigns: " + campaign.CampaignName);
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Updated to: " + campaign.CampaignName);
        }
        
    }
}
