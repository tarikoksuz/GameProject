using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Id:" + " " + campaign.CampaignId + " " + "Kampanya Adı:" + " " + campaign.CampaignName + " " + "İndirim Oranı:" + " " + campaign.DiscountRate + " " + "Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Id:" + " " + campaign.CampaignId + " " + "Kampanya Adı:" + " " + campaign.CampaignName + " " + "İndirim Oranı:" + " " + campaign.DiscountRate + " " + "Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Id:" + " " + campaign.CampaignId + " " + "Kampanya Adı:" + " " + campaign.CampaignName + " " + "İndirim Oranı:" + " " + campaign.DiscountRate + " " + "Güncellendi");
        }
    }
}
