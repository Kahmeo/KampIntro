using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { 
                Id = 1, 
                BirthYear = 1985, 
                FirstName = "ENGİN", 
                LastName = "DEMİROĞ",
                IdentityNumber=12345
            });

            Game game = new Game() { Id = 1, GameName = "Counter", Price = 10 };
            Campaign campaign = new Campaign() { Id = 1, CampaignName = "Kampanya1", CampaignPrice = 8 };

            SaleManager saleManager = new SaleManager();

            saleManager.Sale(gamer, game);
            saleManager.CampaignSale(gamer, game, campaign);

        }
    }
}
