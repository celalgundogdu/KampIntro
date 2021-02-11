using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class SaleManager : ISaleService
    {
        public void CampaignOrder(Campaign campaign, Gamer gamer, Game game)
        {
            Console.WriteLine("Kampanyalı sipariş alındı");
        }

        public void Order(Gamer gamer, Game game)
        {
            Console.WriteLine("Sipariş alındı");
        }
    }
}
