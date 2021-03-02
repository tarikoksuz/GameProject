using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManager : ISaleService
    {
        
        public void Sales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.GameName + " " + campaign.DiscountRate + " " + "İndirimle Aldı");
        }
    }
}
