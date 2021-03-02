using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer();
            gamer1.GamerId = 1;
            gamer1.FirstName = "Fernando";
            gamer1.LastName = "Muslera";
            gamer1.IdentityNumber = 123456789;
            gamer1.BirthYear = 1986;
            
            Gamer gamer2 = new Gamer();
            gamer2.GamerId = 2;
            gamer2.FirstName = "Henry";
            gamer2.LastName = "Onyekuru";
            gamer2.IdentityNumber = 987654321;
            gamer2.BirthYear = 1997;



            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Süper Lig İndirimi";
            campaign.DiscountRate = 0.50;



            GameManager gameManager = new GameManager();
            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "FIFA 2021";
            game1.GamePrice = 250;
            game1.Stock = 500;
            
            Game game2 = new Game();
            game2.GameId = 2;
            game2.GameName = "PES 2021";
            game2.GamePrice = 200;
            game2.Stock = 400;



            SaleManager saleManager = new SaleManager();
            


            gamerManager.Add(gamer1);
            gameManager.Add(game1);
            campaignManager.Add(campaign);
            saleManager.Sales(gamer1, game1, campaign);
        }
    }
}
